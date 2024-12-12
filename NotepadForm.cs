using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace notepad
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            //Opening the file
            FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite);
            StreamReader fileReader = new StreamReader(fileStream);

            //Renaming the document
            this.Text = fileReader.ReadLine();

            //Displaying the file content
            string fileContent = this.Text + Environment.NewLine +  fileReader.ReadToEnd();
            textAreaBox.Text = fileContent;

            fileReader.Close();
            fileStream.Close();
        }
    }
}
