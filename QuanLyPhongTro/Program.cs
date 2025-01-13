using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, CaiDat.Mutex, out bool tonTai))
            {
                if (!tonTai)
                {
                    Process chuongTrinhHienTai = Process.GetCurrentProcess();
                    Process[] danhSachChuongTrinh = Process.GetProcessesByName(chuongTrinhHienTai.ProcessName);

                    foreach (var chuongTrinh in danhSachChuongTrinh)
                    {
                        if (chuongTrinh.Id != chuongTrinhHienTai.Id)
                        {
                            IntPtr hWnd = chuongTrinh.MainWindowHandle;
                            if (hWnd != IntPtr.Zero)
                            {
                                ShowWindow(hWnd, SW_RESTORE);
                                SetForegroundWindow(hWnd);
                            }
                            break;
                        }
                    }

                    return;
                }
            }

            CaiDat.init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _FormChinh = new Forms.FormChinh();
            Application.Run(_FormChinh);
        }

        public static Form _FormChinh;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;
    }
}
