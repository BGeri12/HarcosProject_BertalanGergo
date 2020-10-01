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
        public int Tapasztalat { get => tapasztalat;
            set 
            { 
                tapasztalat = value;
                if (tapasztalat == SzintLepeshez)
                {
                    this.Szint = this.szint + 1;
                }    
            
            } 
        }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Eletero { get => eletero; 
            set{ 
                eletero = value;
                
                if (eletero == 0)
                {
                    Tapasztalat = 0;
                }
                if (eletero>MaxEletero)
                {
                    eletero = MaxEletero;
                }
            }
        }
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint*5; }
        public int MaxEletero { get => AlapEletero + szint*3; }

        public void Megkuzd(Harcos MasikHarcos) 
        {
            if (MasikHarcos == this)
            {
                Console.WriteLine("Hiba: Önmagával nem küzdhet meg !!!");
            }
            else if (Eletero == 0 || MasikHarcos.Eletero == 0)
            {
                Console.WriteLine("Hiba: 0 az életerő");
            }
            else
            {
                MasikHarcos.Eletero = MasikHarcos.Eletero - this.Sebzes;
                if (MasikHarcos.Eletero>0)
                {
                    this.Eletero = this.eletero - MasikHarcos.Sebzes;
                    MasikHarcos.Tapasztalat = MasikHarcos.Tapasztalat + 5;
                }
                else
                {
                    this.Tapasztalat = this.Tapasztalat + 10;
                }
                if (this.Eletero>0)
                {
                    this.Tapasztalat = this.Tapasztalat + 5;
                }
                else
                {
                    MasikHarcos.Tapasztalat = MasikHarcos.Tapasztalat + 10;
                }
            }
        }

        public void Gyogyul()
        {
            if (this.Eletero == 0)
            {
                this.Eletero = MaxEletero;
            }
            else
            {
                this.Eletero = this.Eletero + 3;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} - LVL: {1} - EXP: {2} - HP: {3} - DMG: {4} ",nev,szint,tapasztalat/SzintLepeshez,eletero/MaxEletero,Sebzes);
        }

    }
}
