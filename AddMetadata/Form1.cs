using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddMetadata
{
    public partial class Form1 : Form
    {
        public string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            filePath = tBoxRvtFilePath.Text;

        }



    }
}
