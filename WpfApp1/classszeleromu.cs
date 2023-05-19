using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class classszeleromu
    {

        //Az erőmű helyszíne, mennyi egységből áll, teljesítménye, és a működés kezdetének éve.

        string helyszin;
        int egysegekszama;
        int teljesitemyn;
        int evszam;

        public classszeleromu(string helyszin, int egysegekszama, int teljesitemyn, int evszam)
        {
            this.helyszin = helyszin;
            this.egysegekszama = egysegekszama;
            this.teljesitemyn = teljesitemyn;
            this.evszam = evszam;
        }

        public string Helyszin { get => helyszin; set => helyszin = value; }
        public int Egysegekszama { get => egysegekszama; set => egysegekszama = value; }
        public int Teljesitemyn { get => teljesitemyn; set => teljesitemyn = value; }
        public int Evszam { get => evszam; set => evszam = value; }

        public char Kategoria()
        {
            if (teljesitemyn >= 1000)
            {
                return 'A';
            }
            else if (teljesitemyn >= 500 && teljesitemyn < 1000)
            {
                return 'B';
            }
            else
            {
                return 'C';
            }



        }
}
