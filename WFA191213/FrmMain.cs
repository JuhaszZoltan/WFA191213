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

namespace WFA191213
{
    public partial class FrmMain : Form
    {
        List<Adas> adasok;
        public FrmMain()
        {
            adasok = new List<Adas>();
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Beolvasas();
            CbFeltoltese();

            nko.ValueChanged += NUD_ValueChanged;
            nkp.ValueChanged += NUD_ValueChanged;
            nvo.ValueChanged += NUD_ValueChanged;
            nvp.ValueChanged += NUD_ValueChanged;
        }

        private void NUD_ValueChanged(object sender, EventArgs e)
        {
            var kezd = TimeSpan.Parse($"{nko.Value}:{nkp.Value}");
            var veg = TimeSpan.Parse($"{nvo.Value}:{nvp.Value}");

            int db = 0;

            foreach (var a in adasok)
            {
                if (kezd <= a.Ido && veg >= a.Ido)
                {
                    db += a.Db;
                }
            }

            lblIv.Text = db + "";
        }

        private void CbFeltoltese()
        {
            foreach (var a in adasok)
            {
                if(!cbSoforok.Items.Contains(a.Sofor))
                {
                    cbSoforok.Items.Add(a.Sofor);
                }
            }
        }

        private void Beolvasas()
        {
            var sr = new StreamReader("cb.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                adasok.Add(new Adas(sr.ReadLine()));
            }
            sr.Close();
        }

        private void cbSoforok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int db = 0;

            foreach (var a in adasok)
            {
                if(a.Sofor == cbSoforok.SelectedItem.ToString())
                {
                    db += a.Db;
                }
            }

            lblHivasok.Text = db + "";
        }
    }
}
