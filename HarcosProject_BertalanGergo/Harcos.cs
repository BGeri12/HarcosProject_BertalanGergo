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

        public Harcos(string nev, int szint, int tapasztalat, int eletero, int alapEletero, int alapSebzes, int statuszSablon)
        {

            this.nev = nev;
            szint = 1;
            tapasztalat = 0;

            if (alapEletero == 15)
            {
                alapSebzes = 3;
            }else if (alapEletero == 12)
            {
                alapSebzes = 4;
            }
            else if(alapEletero == 8)
            {
                alapSebzes = 5;
            }

        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => AlapEletero + szint * 3; }

        public override string ToString()
        {
            return string.Format("{0} - LVL: {1} - EXP: {2} - HP: {3} - DMG: {4} ",nev,tapasztalat/SzintLepeshez,eletero/MaxEletero,Sebzes);
        }

    }
}
