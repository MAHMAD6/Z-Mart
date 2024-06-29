using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Mart.DL
{
    public class Essentials
    {
        public static bool RequestAdminPermissions()
        {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";
                Process.Start(startInfo);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error requesting administrator permission: {ex.Message}");
                return false;
            }

        }

        public static bool InitializeAppDirectories(params string[] paths)
        {
            foreach (string path in paths)
            {
                try
                {
                    if (!Directory.Exists(path))
                        System.IO.Directory.CreateDirectory(path);
                }
                catch (AppException ex)
                {
                    MessageBox.Show($"Error creating directory: {path}. Exception: {ex.Message}");
                    return false;
                }
            }
            return true;
        }
        public static bool InitializeTxtFiles(params string[] paths)
        {
            foreach (string path in paths)
            {
                try
                {
                    if (!File.Exists(path))
                        File.CreateText(path).Dispose();
                }
                catch (AppException ex)
                {
                    MessageBox.Show($"Error creating File: {path}. Exception: {ex.Message}");
                    return false;
                }
            }
            return true;
        }
    }
}
