using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBlueBox
{
    public class GlobalHub
    {
        public const string Version = "1.0";
        public const string Subversion = "0";
        public static DateTime ExeCreateDate = DateTime.MinValue;
        public static DateTime ExeUpdateDate = DateTime.MinValue;

        public const int TmpFileMaxCount = 5;
        public const int TmpLogFileMaxCount = 200;

        public event EventHandler CloseApp;

        public static GlobalHub Default { get; } = new GlobalHub();
        public bool EnableLogToFile { get; internal set; }
        public bool IsDebugging { get; internal set; }

        public int StartPointX { get; set; }
        public int StartPointY { get; set; }

        private GlobalHub()
        {
            
        }

        public void FireCloseApp()
        {
            CloseApp?.Invoke(null, null);
        }
    }


    public class PowerTool
    {
        public static byte[] BitmapToBytes(System.Drawing.Bitmap bitmap)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            ms.Dispose();

            return bytes;
        }
        public static Bitmap BytesToBitmap(byte[] imageByte)
        {
            using (MemoryStream stream = new MemoryStream(imageByte))
            {
                var bitmap = new Bitmap(new Bitmap(stream)); //need nest this, or get error when saving file to disk
                return bitmap;
            }
        }
    }


    public class PowerLog
    {
        public static PowerLog One { get; } = new PowerLog();


        private string _Path;
        private string _Folder;
        private DateTime _PathDate = DateTime.MinValue;

        public PowerLog()
        {
            //_PathDate = DateTime.Today;
            //_Path = GetDefaultPath();
        }

        private static string GetDefaultPath()
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            string exeDirectory = Path.GetDirectoryName(exePath);
            string subFolder = Path.Combine(exeDirectory, "tmp-log");

            string fileName = "ocr-log-" + DateTime.Now.ToString("yyyy-MMdd") + ".log";
            string path = Path.Combine(subFolder, fileName);

            if (!Directory.Exists(subFolder))
            {
                Directory.CreateDirectory(subFolder);
            }

            if (Directory.GetFiles(subFolder).Length > GlobalHub.TmpLogFileMaxCount)
            {
                try
                {
                    Directory.Delete(subFolder, true);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }

                Directory.CreateDirectory(subFolder);
            }

            return path;
        }

        public void Console(string message, string source = null)
        {
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now:H:mm:ss.fff} [{source}]: {message}");
        }

        public void SaveAsync(string message, string source = null, bool saveScreen = false)
        {
            System.Diagnostics.Debug.WriteLine($"{source} - {message}");

            if (!GlobalHub.Default.EnableLogToFile)
            {
                System.Diagnostics.Debug.WriteLine($"Not going to log to file, switch is off");
                return;
            }

            CheckDayRollover();

            string detail = $"{DateTime.Now:H:mm:ss.fff} [{source}] - {message}{(saveScreen ? ", screen shot saved" : null)}";
            Bitmap screenShot = null;
            Graphics graphics = null;
            DateTime createTime = DateTime.Now;

            if (saveScreen)
            {
                screenShot = new Bitmap(width: Screen.PrimaryScreen.Bounds.Width, height: Screen.PrimaryScreen.Bounds.Height);
                graphics = Graphics.FromImage(screenShot);
                graphics.CopyFromScreen(new Point(0, 0), new Point(0, 0), screenShot.Size);
            }

            //write to disk, do it on background thread
            Task.Factory.StartNew(() =>
            {
                if (saveScreen)
                {
                    string imageName = $"{Path.GetFileNameWithoutExtension(_Path)}-screen-{createTime.ToString("HHmmss")}.bmp";
                    screenShot.Save(Path.Combine(_Folder, imageName));
                    graphics.Dispose();
                    screenShot.Dispose();
                }

                File.AppendAllText(_Path, detail + Environment.NewLine);
            });
        }


        private void CheckDayRollover()
        {
            if (_PathDate != DateTime.Today)
            {
                _PathDate = DateTime.Today;
                _Path = GetDefaultPath();
                _Folder = Path.GetDirectoryName(_Path);
                System.Diagnostics.Debug.WriteLine($"log file path: {_Path}");
            }
        }

        public void SaveAsync(string message, string source, byte[] imageData)
        {
            Console(message, source);

            if (!GlobalHub.Default.EnableLogToFile)
            {
                System.Diagnostics.Debug.WriteLine($"not going to log to file, switch is off");
                return;
            }

            CheckDayRollover();

            string detail = $"{DateTime.Now:H:mm:ss.fff} [{source}]: {message}{", bytes saved"}";
            DateTime createTime = DateTime.Now;

            //write to disk, do it on background thread
            Task.Factory.StartNew(() =>
            {
                string imageName = $"{Path.GetFileNameWithoutExtension(_Path)}-bytes-before-{createTime.ToString("HHmmss")}.bmp";
                string imagePath = Path.Combine(_Folder, imageName);

                using (Bitmap image = PowerTool.BytesToBitmap(imageData))
                {
                    image.Save(imagePath);
                }

                File.AppendAllText(_Path, detail + Environment.NewLine);
            });
        }


    }



    public static class FormLEOExt
    {
        public const int DisableControlDelayMS = 220;
        public const int SelectControlDelayMS = 300;
        public const int DisableControlDelayLittleMS = 100;

        public static void OnError(this Form form, Exception e)
        {
            string message;

            if (GlobalHub.Default.IsDebugging)
            {
                message = GetAggregateMessage(e, true);
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            else
            {
                message = GetAggregateMessage(e, false);
            }

            form.RunOnMain(() => MessageBox.Show(message));
            form.RunOnMain(() => GlobalHub.Default.FireCloseApp(), 1000);
        }

        public static string GetAggregateMessage(Exception e, bool hasDetail)
        {
            var ae = e as AggregateException;

            if (ae != null)
            {
                return $"Multi errors: {(hasDetail ? string.Join(",", ae.InnerExceptions) : string.Join(",", ae.InnerExceptions.Select(aei => aei.Message)))}";
            }
            else
            {
                return hasDetail ? e.ToString() : e.Message;
            }
        }


        public static bool IsDeadExt(this Form form)
        {
            return form.Disposing || form.IsDisposed;
        }

        public static void RunOnMain(this Form form, Action action)
        {
            if (action == null) return;
            if (form.IsDeadExt()) return;

            //System.Diagnostics.Debug.WriteLine($"RunOnMain - is dead: {form.IsDead()}, disp: {form.Disposing}, disped:{form.IsDisposed} - before if");
            if (form.InvokeRequired)
            {
                if (form.IsDeadExt()) return; //not sure why, the is dead check above not working sometimes, do it again here
                if (form.Disposing || form.IsDisposed) return;
                //System.Diagnostics.Debug.WriteLine($"RunOnMain - is dead: {form.IsDead()}, disp: {form.Disposing}, disped:{form.IsDisposed}");
                form.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public static void RunOnMain(this Form form, Action action, int delayMS)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(delayMS);
                RunOnMain(form, action);
            });
        }

        public static void RunOnMainAsync(this Form form, Action action)
        {
            if (action == null) return;
            if (form.IsDeadExt()) return;

            if (form.InvokeRequired)
            {
                form.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        public static void RunOnMainAsync(this Form form, Action action, int delayMS)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(delayMS);
                RunOnMainAsync(form, action);
            });
        }

        public static PowerLog Log(this Form form)
        {
            return PowerLog.One;
        }

        public static void DisableLabelShorterTime(this Form form, Label control)
        {
            DisableLabelWithTime(form, control, DisableControlDelayLittleMS);
        }


        public static void DisableLabelShortTime(this Form form, Label control)
        {
            DisableLabelWithTime(form, control, DisableControlDelayMS);
        }

        public static void DisableLabelWithTime(this Form form, Label control, int delayMS)
        {
            var oldForeColor = control.ForeColor;
            var oldBackColor = control.BackColor;


            control.ForeColor = System.Drawing.Color.White;
            control.BackColor = System.Drawing.Color.LightGray;
            control.Enabled = false;

            form.RunOnMain(() =>
            {
                control.ForeColor = oldForeColor;
                control.BackColor = oldBackColor;
                control.Enabled = true;
            }, delayMS);
        }

        public static void DisableButtonShortTime(this Form form, Button control)
        {
            DisableButtonWithTime(form, control, DisableControlDelayMS);
        }

        public static void DisableButtonWithTime(this Form form, Button control, int intervalMS)
        {
            var oldForeColor = control.ForeColor;
            var oldBackColor = control.BackColor;

            //leotodo, tmp fix for action bar, or else only the first click will work, and button become disabled forever
            //is this caused by the transparent background/color ?
            oldForeColor = System.Drawing.Color.Black;
            oldBackColor = System.Drawing.Color.White;


            control.ForeColor = System.Drawing.Color.White;
            control.BackColor = System.Drawing.Color.LightGray;
            control.Enabled = false;

            form.RunOnMainAsync(() =>
            {
                control.ForeColor = oldForeColor;
                control.BackColor = oldBackColor;
                control.Enabled = true;
            }, intervalMS);
        }

      

    

        public static void SetVersion(this Form form)
        {
            form.Text = $"SBB-V{GlobalHub.Version}.{GlobalHub.Subversion}";
        }

    }
}
