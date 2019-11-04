using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
namespace WinForm
{
    public partial class Tesseract : Form
    {
        public Tesseract()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() != DialogResult.OK)
            {

            }
        }
    }
}
