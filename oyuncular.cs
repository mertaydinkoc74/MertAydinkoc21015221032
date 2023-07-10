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
    public partial class oyuncular : Form
    {
        public static ListViewItem item;
        public static string text;
        public List<(string , string ,string)> Liste = new List<(string, string, string)>();
        public List<(string, string, int)> Liste2 = new List<(string, string, int)>();
        public string error;
        
        public oyuncular()
        {
            InitializeComponent();
        }

        public void oyuncular_Load(object sender, EventArgs e)
        {
            ListView listView = new ListView();
            listView = oyunculiste;
            listView.Items.Clear();
            int i;
            Liste = dBCon.tumOyuncular(out error);
            for (i = 0; i < Liste.Count; i++)
            {
                (string, string, string) a = Liste[i];
                
                listView.Items.Add(a.Item1);
                listView.Items[i].SubItems.Add(a.Item2);
                listView.Items[i].SubItems.Add(a.Item3);

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oyuncuEkle_Click(object sender, EventArgs e)
        {
            Form2 ekle = new Form2();
            ekle.ShowDialog();
        }

        private void oyuncuAll_Click(object sender, EventArgs e)
        {
            oyuncular_Load(sender,e);
        }

        private void oyuncuUpdate_Click(object sender, EventArgs e)
        {
            try { item = oyunculiste.SelectedItems[0]; ; }
            catch { return; }
            item = oyunculiste.SelectedItems[0];
            Form2 update = new Form2() 
            {
                Text ="Oyuncu Güncelle"
            };
            update.ShowDialog();
        }

        private void oyuncuDelete_Click(object sender, EventArgs e)
        {
            try { item = oyunculiste.SelectedItems[0]; ; }
            catch { return; }
            item = oyunculiste.SelectedItems[0];
            dBCon.oyuncuSil(item.Text, out error);
            oyuncular_Load(sender,e);
        }

        private void oyuncuBul_Click(object sender, EventArgs e)
        {
            bul bul = new bul();
            bul.ShowDialog();
            
            bul.Close();
            ListView listView = new ListView();
            listView = oyunculiste;
            listView.Items.Clear();
            int i;
            Liste2 = dBCon.oyuncuBul(text, out error);
            try { 
            for (i = 0; i < Liste2.Count; i++)
            {
                (string, string, string) a = Liste[i];

                listView.Items.Add(a.Item1);
                listView.Items[i].SubItems.Add(a.Item2);
                listView.Items[i].SubItems.Add(a.Item3);
            };
            }
            catch { return; }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
