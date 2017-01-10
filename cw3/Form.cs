using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw3
{
    public partial class Form : System.Windows.Forms.Form
    {
        int[][] systemDecyzyjny;

        public Form()
        {
            InitializeComponent();
        }

        #region Wczytywanie Systemu
        private void btn_Wybierz_Click(object sender, EventArgs e)
        {
            var wynik = ofd.ShowDialog();
            if (wynik != DialogResult.OK)
                return;

            if (wynik == DialogResult.OK)
            {

                tb_Sciezka.Text = ofd.FileName;
                string trescPliku = System.IO.File.ReadAllText(ofd.FileName);
                string[] poziomy = trescPliku.Split('\n');
                int[][] daneZPliku = new int[poziomy.Length][];

                for (int i = 0; i < poziomy.Length; i++)
                {
                    string poziom = poziomy[i].Trim();
                    string[] miejscaParkingowe = poziom.Split(' ');
                    daneZPliku[i] = new int[miejscaParkingowe.Length];
                    for (int j = 0; j < miejscaParkingowe.Length; j++)
                    {
                        daneZPliku[i][j] = int.Parse(miejscaParkingowe[j]);

                    }
                }

                systemDecyzyjny = daneZPliku;
            }
        }

        #endregion

        private void btn_Oblicz_Click(object sender, EventArgs e)
        {
            Fisher fisher = new Fisher(systemDecyzyjny);

            int liczbaAtrybutow;
            try
            {
                liczbaAtrybutow = int.Parse(tb_LiczbaAtrybutow.Text);
            }
            catch (Exception)
            {
                liczbaAtrybutow = 1;
            }
            textBox1.Text = fisher.SystemPoSelekcji(liczbaAtrybutow);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ofd.Filter = "Text (.txt) |*.txt";
        }
    }
}
