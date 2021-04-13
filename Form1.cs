using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneCopyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // setting the paths to null 
        private static string folder2_loc = "";
        private static string folder1_loc = "";

        private void button2_Click(object sender, EventArgs e)
        {
            Folder2_location();
        }
        private void phoneloc_Click(object sender, EventArgs e)
        {
            folder1_Location();
        }
        private void Movebtn_Click(object sender, EventArgs e)
        {
            Folder_move(folder1_loc, folder2_loc);
        }

        private void Copybtn_Click(object sender, EventArgs e)
        {
            DirectoryInfo diSource = new DirectoryInfo(folder1_loc);
            DirectoryInfo diTarget = new DirectoryInfo(folder2_loc);
            Folder_copy(diSource, diTarget);
        }
        private static void folder1_Location()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    folder1_loc = dialog.SelectedPath;
                }
            }
        }
        private static void Folder2_location()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    folder2_loc = dialog.SelectedPath;
                }
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            string message = "Are you sure you want to delete this directory";
            string caption = "";
            // Displays the MessageBox.
            DirectoryInfo diSource = new DirectoryInfo(folder1_loc);

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Folder_delete(diSource);
            }
        }



        private bool Folder_copy(DirectoryInfo diSource, DirectoryInfo diTarget)
        {

            Directory.CreateDirectory(diTarget.FullName);

            foreach (FileInfo fi in diSource.GetFiles())
            {

                copyiedfiles.AppendText($"Copying {diTarget.FullName}{fi.Name} \n");
                fi.CopyTo(Path.Combine(diTarget.FullName, fi.Name), true);
            }
            foreach (DirectoryInfo diSourceSubDir in diSource.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    diTarget.CreateSubdirectory(diSourceSubDir.Name);
                Folder_copy(diSourceSubDir, nextTargetSubDir);
            }
            return true;
        }
        private void Folder_delete(DirectoryInfo source)
        {
            copyiedfiles.Text = "";
            foreach (FileInfo fi in source.GetFiles())
            {
                File.Delete(fi.FullName);
                copyiedfiles.AppendText($"Deleting {source.FullName}{fi.Name}\n");

            }
            foreach (DirectoryInfo sourecdi in source.GetDirectories())
            {
                sourecdi.Delete(true);
                copyiedfiles.AppendText($"Deleting {source.FullName}\n");
            }
        }
        private void Folder_move(string source, string target)
        {
            if (Directory.Exists(source) == true)
            {
                DirectoryInfo sourcedi = new DirectoryInfo(source);
                DirectoryInfo targetdi = new DirectoryInfo(target);
                if (Folder_copy(sourcedi, targetdi) == true)
                {

                    Folder_delete(sourcedi);
                }


            }
        }
    }

}

