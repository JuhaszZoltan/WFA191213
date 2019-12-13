using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA191213
{
    class Adas
    {
        public int Ora { get; set; }
        public int Perc { get; set; }
        public int Db { get; set; }
        public string Sofor { get; set; }

        public TimeSpan Ido { get; set; }
        public Adas(string s)
        {
            var t = s.Split(';');
            Ora = int.Parse(t[0]);
            Perc = int.Parse(t[1]);
            Db = int.Parse(t[2]);

            Ido = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), 0);

            Sofor = t[3];
        }
    }
}
