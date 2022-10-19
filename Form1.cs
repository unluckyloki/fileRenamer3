using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileRenamer3
{
    public partial class Form1 : Form
    {
        private string path = "";
        private string nameFormat = "%NUM%";
        private bool saveExt = true;
        private bool numOnly = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pathToDirText_TextChanged(object sender, EventArgs e)
        {
            path = pathToDirText.Text;
        }

        private void label1_Click(object sender, EventArgs e){}

        private void pathDirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirBrowseDialog = new FolderBrowserDialog();
            dirBrowseDialog.ShowNewFolderButton = false;
            if (dirBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                path = dirBrowseDialog.SelectedPath;
                pathToDirText.Text = dirBrowseDialog.SelectedPath;
            }
        }

        private void nFormatText_TextChanged(object sender, EventArgs e)
        {
            nameFormat = nFormatText.Text;
        }

        private void startNumbText_TextChanged(object sender, EventArgs e){}

        private void numbOnlyCB_CheckedChanged(object sender, EventArgs e)
        {
            nFormatLable.Enabled = !numbOnlyCB.Checked;
            nFormatText.Enabled = !numbOnlyCB.Checked;
            numOnly = numbOnlyCB.Checked;
        }

        private void errorsText_TextChanged(object sender, EventArgs e){}

        private void renameBtn_Click(object sender, EventArgs e)
        {
            if (numOnly) 
            { 
                try 
                { 
                    if (Renamer.rename(path, Convert.ToInt32(startNumbText.Text), saveExt))
                    {
                        DialogResult res = MessageBox.Show("Succesful!", "File renamer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    errorsText.Enabled = true; errorsText.Text = ex.ToString();
                    DialogResult res = MessageBox.Show("Something went wrong :D", "File renamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                try
                {
                    if (Renamer.rename(path, nameFormat, Convert.ToInt32(startNumbText.Text), saveExt))
                    {
                        DialogResult res = MessageBox.Show("Succesful!", "File renamer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) 
                {
                    errorsText.Enabled = true; errorsText.Text = ex.ToString();
                    DialogResult res = MessageBox.Show("Something went wrong :D", "File renamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void startNumbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void startNumbText_Leave(object sender, EventArgs e)
        {
            if (startNumbText.Text == "") startNumbText.Text = "0";
        }
    }
}
