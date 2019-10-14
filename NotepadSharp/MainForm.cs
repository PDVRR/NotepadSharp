using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadSharp
{
    public interface INotepadForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler OpenFileClick;
        event EventHandler SaveFileClick;
        event EventHandler SaveAsFileClick;
        event EventHandler ContentChanged;
    }

    public partial class MainForm : Form, INotepadForm
    {
        private string filePath;

        public MainForm()
        {
            InitializeComponent();
        }

        public string FilePath
        {
            get
            {
                return filePath;
            }
        }

        public string Content
        {
            get
            {
                return textContentFld.Text;
            }
            set
            {
                textContentFld.Text = value;
            }
        }

        public event EventHandler OpenFileClick;
        public event EventHandler SaveFileClick;
        public event EventHandler SaveAsFileClick;
        public event EventHandler ContentChanged;

        public void SetSymbolCount(int count)
        {
            symbolCountLbl.Text = "Symbol count: " + count;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void openFileMenuBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                OpenFileClick?.Invoke(sender, EventArgs.Empty);
                saveFileMenuBtn.Enabled = true;
            }
        }

        private void saveFileMenuBtn_Click(object sender, EventArgs e)
        {
            SaveFileClick?.Invoke(sender, EventArgs.Empty);
        }

        private void textContentFld_TextChanged(object sender, EventArgs e)
        {
            linesCountLbl.Text = "Lines count: " + textContentFld.Lines.Length;
            ContentChanged?.Invoke(sender, EventArgs.Empty);
        }

        private void saveAsFileMenuBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                SaveAsFileClick?.Invoke(sender, EventArgs.Empty);
                saveFileMenuBtn.Enabled = true;
            }
        }

        private void newFileMenuBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save changes?";
            string caption = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(filePath))
                {
                    saveAsFileMenuBtn_Click(sender, e);
                }
                else
                {
                    saveAsFileMenuBtn_Click(sender, e);
                }
                textContentFld.Text = String.Empty;
                filePath = String.Empty;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                textContentFld.Text = String.Empty;
                filePath = String.Empty;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            newFileMenuBtn_Click(sender, e);
        }

        private void exitMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
