using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceTextInXML
{
    public partial class Form1 : Form
    {
        string[] gFileNames;
        string[] gPathsFiles;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = "D:\\RenatWork\\xmlReplace";
            openFileDialog2.InitialDirectory = "D:\\RenatWork\\xmlReplace";
            openFileDialog1.Multiselect = true;
        }

        private void BtOpenFile_Click(object sender, EventArgs e)
        {
            listViewEnterFiles.Items.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            gPathsFiles = openFileDialog1.FileNames;
            gFileNames = openFileDialog1.SafeFileNames;
            labCountFiles.Text = gFileNames.Length.ToString();
            listViewEnterFiles.View = View.List;
            for (int i = 0; i < gFileNames.Length; i++)
            {
                listViewEnterFiles.Items.Add(gFileNames[i]);
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            List<dynamic> listReplacesText = new List<dynamic>();
            
            string oldTemporary = string.Empty;
            string newTemporary = string.Empty;

            Encoding encoding = Encoding.GetEncoding("windows-1251");

            for (int i = 0; i < dgvReplaceText.Rows.Count; i++)
            { 
                if(dgvReplaceText[0, i].Value != null && dgvReplaceText[1, i].Value != null)
                {
                    dynamic replacesText = new ExpandoObject();
                    replacesText.oldText = dgvReplaceText[0, i].Value.ToString();
                    replacesText.newText = dgvReplaceText[1, i].Value.ToString();
                    listReplacesText.Add(replacesText);
                }
            }
            for (int i = 0; i < gPathsFiles.Length; i++)
            {
                //читаем файл
                try
                {
                    using (StreamReader sr = new StreamReader(gPathsFiles[i], encoding))
                    {
                        oldTemporary = sr.ReadToEnd();
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

                // заменяем
                foreach (var item in listReplacesText)
                {
                    var regex = new Regex(Regex.Escape(item.oldText));
                    newTemporary = regex.Replace(oldTemporary, item.newText);
                    oldTemporary = newTemporary;
                }

                // удаляем файл
                //File.Delete(gPathsFiles[i]);

                //string newNameFile = gPathsFiles[i].Substring(0, gPathsFiles[i].Length - 3) + "txt";
               
                //создаем и записываем в файл
                try
                {
                    using (StreamWriter sw = new StreamWriter(gPathsFiles[i], false, encoding, 1))
                    {
                        sw.WriteLine(newTemporary);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

        }

        private void BtInputIsFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            string filePath = openFileDialog2.FileName;

            List<string> listTextIsFile = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listTextIsFile.Add(line);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            int j = 0;
            foreach (var item in listTextIsFile)
            {   
                dgvReplaceText.Rows.Add();
                try
                {
                    dgvReplaceText[0, j].Value = item.Split('-')[0];
                    dgvReplaceText[1, j].Value = item.Split('-')[1];
                }
                catch { }
                j++;
            }

        }

        private void BtClearTable_Click(object sender, EventArgs e)
        {
            if(dgvReplaceText.Rows.Count >= 2)
            {
                dgvReplaceText.Rows.RemoveAt(dgvReplaceText.Rows.Count - 2);
            }
        }
    }
}
