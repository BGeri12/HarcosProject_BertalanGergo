using System;
using System.Collections.Generic;
using System.Text;

namespace HarcosProject_BertalanGergo
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev, int statuszSablon)
        {

            this.nev = nev;
            szint = 1;
            tapasztalat = 0;

            if (statuszSablon == 1)
            {
                alapEletero = 15;
                alapSebzes = 3;
            }else if (statuszSablon == 2)
            {
                alapEletero = 12;
                alapSebzes = 4;
            }
            else if(statuszSablon == 3)
            {
                alapEletero = 8;
                alapSebzes = 5;
            }

            eletero = MaxEletero;

        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint*5; }
        public int MaxEletero { get => AlapEletero + szint*3; }

        public void Megkuzd(Harcos MasikHarcos) 
        {
        }

        public void Gyogyul()
        {

        }
        public override string ToString()
        {
            return string.Format("{0} - LVL: {1} - EXP: {2} - HP: {3} - DMG: {4} ",nev,szint,tapasztalat/SzintLepeshez,eletero/MaxEletero,Sebzes);
        }

    }
}
