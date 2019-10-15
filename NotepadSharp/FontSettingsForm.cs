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
    public partial class FontSettingsForm : Form
    {
        TextBox _textBox;
        public FontSettingsForm(TextBox textBox)
        {
            InitializeComponent();
            _textBox = textBox;
        }

        private void FontSettingsForm_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                fontLB.Items.Add(font.Name);
            }
            fontLB.Items.RemoveAt(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fontName = (fontLB.SelectedItems.Count == 1 ? fontLB.SelectedItem.ToString() : _textBox.Font.Name);
            int fontSize = Convert.ToInt32(fontSizeUpDown.Value);
            _textBox.Font = new Font(fontName, fontSize);
            this.Close();
        }
    }
}
