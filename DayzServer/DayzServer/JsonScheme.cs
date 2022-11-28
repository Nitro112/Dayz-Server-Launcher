using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayzServer
{

    public class DayzServerData
    {
        public string dayzDirectory { get; set; }
        public string modsDirectory { get; set; }
        public string launchParams { get; set; }
        public List<String> modlist { get; set; }
    }

    public static class ServerMethods
    {
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        public static void CopyKeys(string source, string target)
        {
            var diSource = new DirectoryInfo(source);
            var diTarget = new DirectoryInfo(target);

            Directory.CreateDirectory(diTarget.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in diSource.GetFiles())
            {
                if(fi.Name.EndsWith(".bikey"))
                    fi.CopyTo(Path.Combine(diTarget.FullName, fi.Name), true);
            }
        }
    }

}
