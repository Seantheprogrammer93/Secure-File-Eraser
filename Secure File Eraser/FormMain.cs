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

namespace SecureFileEraser
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                checkedListBoxFilesAndFolders.Items.Add(ofd.FileName);
            }
        }

        private void buttonAddFolder_Click_1(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo d = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] Files = d.GetFiles();

                foreach (FileInfo file in Files)
                {
                    checkedListBoxFilesAndFolders.Items.Add(file.FullName);
                }
            }
        }









        //---------- Overwrite Methods Start ----------
        private void overwrite_0x00(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            long fileLength = fi.Length;

            byte[] data = new byte[fileLength];

            using (FileStream
           fileStream = new FileStream(filePath, FileMode.Create))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    fileStream.WriteByte(0x00);
                }

                fileStream.Seek(0, SeekOrigin.Begin);
            }
        }


        private void overwrite_0xFF(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            long fileLength = fi.Length;

            byte[] data = new byte[fileLength];

            using (FileStream
           fileStream = new FileStream(filePath, FileMode.Create))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    fileStream.WriteByte(0xFF);
                }

                fileStream.Seek(0, SeekOrigin.Begin);
            }
        }


        private void overwrite_0xAA(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            long fileLength = fi.Length;

            byte[] data = new byte[fileLength];

            using (FileStream
           fileStream = new FileStream(filePath, FileMode.Create))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    fileStream.WriteByte(0xAA);
                }

                fileStream.Seek(0, SeekOrigin.Begin);
            }
        }


        private void overwrite_0x01(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            long fileLength = fi.Length;

            byte[] data = new byte[fileLength];

            using (FileStream
           fileStream = new FileStream(filePath, FileMode.Create))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    fileStream.WriteByte(0x01);
                }

                fileStream.Seek(0, SeekOrigin.Begin);
            }
        }


        private void overwrite_random(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            long fileLength = fi.Length;

            byte[] data = new byte[fileLength];
            new Random().NextBytes(data);

            using (FileStream
           fileStream = new FileStream(filePath, FileMode.Create))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    fileStream.WriteByte(data[i]);
                }

                fileStream.Seek(0, SeekOrigin.Begin);
            }
        }
        //---------- Overwrite Methods End ----------









        //--------------- Shred Functions Start ---------------
        public void Quick_Shred(string filePath)
        {
            overwrite_0x00(filePath);
            overwrite_random(filePath);
            File.Delete(filePath);
            comboBoxDeletionMethods.SelectedIndex = -1;
        }

        public void GOST_R_50739_95(string filePath)
        {
            overwrite_random(filePath);
            File.Delete(filePath);
            comboBoxDeletionMethods.SelectedIndex = -1;
        }

        public void Bruce_Schneier_Algorithm(string filePath)
        {
            overwrite_0xFF(filePath);
            overwrite_0x00(filePath);
            overwrite_random(filePath);
            overwrite_random(filePath);
            overwrite_random(filePath);
            overwrite_random(filePath);
            overwrite_random(filePath);
            File.Delete(filePath);
            comboBoxDeletionMethods.SelectedIndex = -1;
        }

        public void VSITR(string filePath)
        {
            overwrite_0x00(filePath);
            overwrite_0xFF(filePath);
            overwrite_0x00(filePath);
            overwrite_0xFF(filePath);
            overwrite_0x00(filePath);
            overwrite_0xFF(filePath);
            overwrite_0xAA(filePath);
            File.Delete(filePath);
            comboBoxDeletionMethods.SelectedIndex = -1;
        }

        public void NAVSO_P_5239_26_MDM(string filePath)
        {
            overwrite_0x01(filePath);
            overwrite_0x00(filePath);
            overwrite_random(filePath);
            File.Delete(filePath);
            comboBoxDeletionMethods.SelectedIndex = -1;
        }

        //--------------- Shred Functions End ---------------


        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            string[] deletePaths = checkedListBoxFilesAndFolders.CheckedItems.OfType<string>().ToArray();

            if (deletePaths.Length == 0)
            {
                MessageBox.Show("Please select one or more files to delete", "No Files Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (comboBoxDeletionMethods.SelectedIndex == comboBoxDeletionMethods.FindString("Quick delete (recommended)"))
                {
                    DialogResult d = MessageBox.Show("The file(s) you have selected will be permanently deleted and will not be recoverable. Do you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        foreach (string path in deletePaths)
                        {
                            Quick_Shred(path);
                        }
                        foreach (string item in checkedListBoxFilesAndFolders.CheckedItems.OfType<string>().ToList())
                        {
                            checkedListBoxFilesAndFolders.Items.Remove(item);
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (comboBoxDeletionMethods.SelectedIndex == comboBoxDeletionMethods.FindString("GOST R 50739-95, Russia"))
                {
                    DialogResult d = MessageBox.Show("The file(s) you have selected will be permanently deleted and will not be recoverable. Do you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        foreach (string path in deletePaths)
                        {
                            GOST_R_50739_95(path);
                        }
                        foreach (string item in checkedListBoxFilesAndFolders.CheckedItems.OfType<string>().ToList())
                        {
                            checkedListBoxFilesAndFolders.Items.Remove(item);
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (comboBoxDeletionMethods.SelectedIndex == comboBoxDeletionMethods.FindString("Bruce Schneier Algorithm"))
                {
                    DialogResult d = MessageBox.Show("The file(s) you have selected will be permanently deleted and will not be recoverable. Do you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        foreach (string path in deletePaths)
                        {
                            Bruce_Schneier_Algorithm(path);
                        }
                        foreach (string item in checkedListBoxFilesAndFolders.CheckedItems.OfType<string>().ToList())
                        {
                            checkedListBoxFilesAndFolders.Items.Remove(item);
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (comboBoxDeletionMethods.SelectedIndex == comboBoxDeletionMethods.FindString("VSITR standard, Germany"))
                {
                    DialogResult d = MessageBox.Show("The file(s) you have selected will be permanently deleted and will not be recoverable. Do you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        foreach (string path in deletePaths)
                        {
                            VSITR(path);
                        }
                        foreach (string item in checkedListBoxFilesAndFolders.CheckedItems.OfType<string>().ToList())
                        {
                            checkedListBoxFilesAndFolders.Items.Remove(item);
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (comboBoxDeletionMethods.SelectedIndex == comboBoxDeletionMethods.FindString("NAVSO P-5239-26 (MFM) standard, USA"))
                {
                    DialogResult d = MessageBox.Show("The file(s) you have selected will be permanently deleted and will not be recoverable. Do you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        foreach (string path in deletePaths)
                        {
                            NAVSO_P_5239_26_MDM(path);
                        }
                        foreach (string item in checkedListBoxFilesAndFolders.CheckedItems.OfType<string>().ToList())
                        {
                            checkedListBoxFilesAndFolders.Items.Remove(item);
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a file erasure option!", "File Erasure Option", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
