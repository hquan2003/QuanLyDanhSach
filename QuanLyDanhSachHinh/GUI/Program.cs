using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyDanhSachHinh.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            var form = new FormMain();
            form.Injection(new DAO.HinhDAO("D:\\Desktop\\QuanLyDanhSach\\QuanLyDanhSachHinh\\Models\\Data.txt"));
            Application.Run(form);
        }
    }
}