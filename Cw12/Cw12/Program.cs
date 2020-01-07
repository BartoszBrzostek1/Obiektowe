using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw12
{
    class Program
    {
        static void Main(string[] args)
        {

            Napoj kawa1 = new MalaKawaZMlekiem();
            Napoj czekolada1 = new SredniaGoracaCzekoladaBezMleka();
            Console.WriteLine(kawa1.Opis + " kosztuje: " + $"{kawa1.Koszt}");
            Console.WriteLine(czekolada1.Opis + " kosztuje: " + $"{czekolada1.Koszt}");
            Console.ReadKey();

        }

        public abstract class Napoj
        {
            public string Opis { get { return this._opis; } } // get pobiera, set ustawia
            public double Koszt { get { return this._koszt; } }
            protected string _opis;
            protected double _koszt;
            protected bool mlekoBezLaktozy = false;
            protected bool cukier = false;
            protected bool maly = false;
            protected bool sredni = false;
            protected bool duzy = false;



        }

        class MalaKawaZMlekiem : Napoj
        {
            public MalaKawaZMlekiem()
            {
                this._opis = "Mala kawa z mlekiem";
                this._koszt = 4.00;
                
                this.maly = true;
                this.mlekoBezLaktozy = true;


                if (this.mlekoBezLaktozy)
                {
                    this._koszt += 0.50;
                }
                if (this.cukier)
                {
                    this._koszt += 0.10;
                }
                if (this.maly)
                {
                    this._koszt += 1.00;
                }
            }
        }

        class SredniaGoracaCzekoladaBezMleka : Napoj
        {
            public SredniaGoracaCzekoladaBezMleka()
            {
                this._opis = "Srednia gorąca czegolada bez mleka";
                this._koszt = 3.00;
                
                this.sredni = true;
                this.cukier = true;

                if (this.mlekoBezLaktozy)
                {
                    this._koszt += 0.50;
                }
                if (this.cukier)
                {
                    this._koszt += 0.10;
                }
                if (this.sredni)
                {
                    this._koszt += 2.00;
                }

            }


        }


    }
}
