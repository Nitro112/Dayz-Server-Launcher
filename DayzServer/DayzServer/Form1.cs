using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Xml.Linq;
namespace DayzServer
{
    public partial class Form1 : Form
    {
        public string[] allFiles;
        public string modDirectory;
        public List<string> allFilesParsed = new List<string>();
        public List<string> searchResults = new List<string>();
        public List<string> selectedMods = new List<string>();
        public string modstring = "-mod=";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            // Loop through all selectedMods list and open them and copy keys content to Dayz.exe keys folder
            //SaveToJson
            SaveConfiguration();
            MoveModsToDir();
            Process server = new Process
            {
                StartInfo =
                {
                    FileName = dayzExePath.Text,
                    Arguments = launchParamBox.Text + " " + modstring
                }
            };

            server.Start();

            // Start server
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            Regex search = new Regex(searchBox.Text, RegexOptions.IgnoreCase);
            searchResults.Clear();

            foreach (string file in allFilesParsed)
            {
                if (search.IsMatch(file))
                {
                    searchResults.Add(file);
                }
            }



            checkedListBox1.Items.Clear();
            foreach (string file in searchResults)
            {
                checkedListBox1.Items.Add(file);
            }
        }

        private void DayzExeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DayzExeDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                dayzExePath.Text = DayzExeDialog.FileName;
            }
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DayZFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                modPath.Text = DayZFolderBrowser.SelectedPath;
            }
        }

        private void modPath_TextChanged(object sender, EventArgs e)
        {
            modDirectory = modPath.Text;
            GetFiles(modDirectory);
        }

        private void checkedListBox1_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string mod = checkedListBox1.Items[e.Index].ToString().Replace(" ", "-");
                if(!selectedMods.Contains(checkedListBox1.Items[e.Index].ToString()))
                    selectedMods.Add(checkedListBox1.Items[e.Index].ToString());
                modstring += mod +";";
            }
            else
            {
                string mod = checkedListBox1.Items[e.Index].ToString().Replace(" ", "-");
                if (selectedMods.Contains(checkedListBox1.Items[e.Index].ToString()))
                    selectedMods.Remove(checkedListBox1.Items[e.Index].ToString());
            }

        }


        private void SaveConfiguration()
        {
            var configuration = new DayzServerData
            {
                dayzDirectory = dayzExePath.Text,
                modsDirectory = modPath.Text,
                launchParams = launchParamBox.Text,
                modlist = selectedMods
            };

            JsonSerializerOptions opt = new JsonSerializerOptions();
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(configuration, options);
            Debug.WriteLine(json);
            string saveDirectory = Directory.GetCurrentDirectory();
            File.WriteAllText(@$"{saveDirectory}\config.json", json);
        }

        private void LoadConfiguration()
        {

            string loadDirectory = Directory.GetCurrentDirectory();
            if (File.Exists(@$"{loadDirectory}\config.json"))
            {
                string jsonString = File.ReadAllText(@$"{loadDirectory}\config.json");

                DayzServerData? loadData = JsonSerializer.Deserialize<DayzServerData>(jsonString);
                Debug.WriteLine(loadData?.dayzDirectory);
                Debug.WriteLine(loadData?.modsDirectory);
                Debug.WriteLine(loadData?.modlist);
                SetupVariables(loadData);
            }
        }

        private void SetupVariables(DayzServerData loadData)
        {
            selectedMods = loadData.modlist;
            dayzExePath.Text = loadData.dayzDirectory;
            launchParamBox.Text = loadData.launchParams;
            modPath.Text = loadData.modsDirectory;
        }

        private void GetFiles(string modDirectory)
        {
            allFiles = Directory.GetDirectories(modDirectory);

            foreach (string file in allFiles)
            {
                string fileName = file.Split('\\').Last();

                allFilesParsed.Add(fileName);
                if (selectedMods.Contains(fileName))
                {
                    checkedListBox1.Items.Add(fileName, true);
                }
                else
                {
                    checkedListBox1.Items.Add(fileName, false);
                }
            }
        }

        private void MoveModsToDir()
        {
            string dayzRootPath = dayzExePath.Text.Remove(16);
            

            foreach(string mod in selectedMods)
            {
                string destFolder = mod.Replace(" ", "-");
                string source = Path.Combine(modPath.Text, mod);
                string destination = Path.Combine(dayzRootPath, destFolder);
                if(!Directory.Exists(destination))
                {
                    string keySouce = Path.Combine(source, "Keys");
                    string keyDest = Path.Combine(dayzRootPath, "Keys");
                    ServerMethods.Copy(source, destination);
                    ServerMethods.CopyKeys(keySouce, keyDest);
                }
            }
        }

        //public static void Copy(string sourceDirectory, string targetDirectory)
        //{
        //    var diSource = new DirectoryInfo(sourceDirectory);
        //    var diTarget = new DirectoryInfo(targetDirectory);

        //    ServerMethods.CopyAll(diSource, diTarget);
        //}

        //public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        //{
        //    Directory.CreateDirectory(target.FullName);

        //    // Copy each file into the new directory.
        //    foreach (FileInfo fi in source.GetFiles())
        //    {
        //        fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
        //    }

        //    // Copy each subdirectory using recursion.
        //    foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
        //    {
        //        DirectoryInfo nextTargetSubDir =
        //            target.CreateSubdirectory(diSourceSubDir.Name);
        //        CopyAll(diSourceSubDir, nextTargetSubDir);
        //    }
        //}

    }
}