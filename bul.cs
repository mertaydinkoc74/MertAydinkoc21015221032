using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class bul : Form
    {
        public static string textboxtext;
        public bul()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            oyuncular.text = textBox1.Text;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
