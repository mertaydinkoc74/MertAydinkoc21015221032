using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataBaseCon;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string Id = oyuncuIDbox.Text;
            string oyuncuName = oyuncuNameBox.Text;
            string oyuncuMoney = OyuncuMoneyBox.Text;
            int money;
            int test;
            try { Int32.TryParse(oyuncuMoney, out test); }
            catch { this.Close();}
            string error;
            if (this.Text == "Oyuncu Ekle")
            {
                dBCon.oyuncuEkle(Id, oyuncuName, oyuncuMoney, out error);
                this.Close();
            }
            else
            {
                Int32.TryParse(oyuncuMoney, out money);
                dBCon.oyuncuUpdate(Id, oyuncuName, money , out error);
                this.Close();
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (this.Text == "Oyuncu Ekle")
            {
                string guid = Guid.NewGuid().ToString();
                oyuncuIDbox.Text = guid;
            }
            else
            {
                oyuncuIDbox.Text = oyuncular.item.Text;
                oyuncuNameBox.Text = oyuncular.item.SubItems[1].Text;
                OyuncuMoneyBox.Text = oyuncular.item.SubItems[2].Text;
            }
        }
    }
}
