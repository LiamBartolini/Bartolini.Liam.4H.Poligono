using System;

namespace Bartolini.Liam._4H.Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma di Liam, classe poligono");

            //Poligono figura = new Poligono(4, 6.5); metodo gia istanziato

            Console.WriteLine("Inserisci il numero di lati: ");
            string strLati = Console.ReadLine();

            Console.WriteLine("inserisci la lunghezza dei lati: ");
            string strLungh = Console.ReadLine();

            double lati = Convert.ToDouble(strLati);
            double Llati = Convert.ToDouble(strLungh);
               
            //inserisci il numero di lati e la lunghezza da input
            Poligono figura = new Poligono(lati, Llati);
            Poligono quadrato = new Poligono();
            Poligono p2 = new Poligono(6, 9); //inserire numero lati e lunghezza lati manualmente

            figura.Fisso(figura);
            figura.Apotema(figura);
            figura.Fisso(figura);

            figura.Perimetro(figura);
            figura.Area(figura);
            string strNome = figura.Stampa(figura);
            string strConfronta = figura.Confronta(figura, p2);

            Console.WriteLine($"Apotema del poligono di {figura.nLati} lati: \r\nAPOTEMA :{figura.apotema:n3}\r\nIL NUMERO FISSO E' {figura.fisso:n3}");

            Console.WriteLine($"L'area è: {figura.area:n3}\r\nPerimetro è: {figura.perimetro:n3}");
            Console.WriteLine($"Il nome del poligono di {figura.nLati} lati è '{strNome}'");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Poligono passato {p2.nLati} lati e la lunghezza del lato pari a {p2.L_lati}\r\nESITO VERIFICA\r\n{strConfronta}");
            Console.ResetColor();
        }
    }

    class Poligono
    {
        public double nLati;
        public double L_lati;
        public double apotema;
        public double perimetro;
        public double area;
        public double fisso;
        
        public Poligono()
        {
            //costruisce il quadrato di lato 1
            nLati = 4;
            L_lati = 1;
        }

        public Poligono(double lati, double lLati)
        {
            nLati = lati;
            L_lati = lLati;
        }

        //costruttore di un poligono regolare di lato 1
        public Poligono(int lati)
        {
            L_lati = 1;
            nLati = lati;
        }

        public void Area(Poligono p1)
        {
            area = p1.perimetro * p1.fisso / 2;
        }

        public void Perimetro(Poligono p1)
        {
            perimetro = p1.nLati * p1.L_lati;
        }

        public void Apotema(Poligono p1)
        {
            apotema = p1.L_lati / (2 * Math.Tan(Math.PI / nLati));
        }

        public void Fisso(Poligono p1)
        {
            fisso = apotema / p1.L_lati;
        }

        public string Stampa(Poligono p1)
        {
            string strR;

            switch(p1.nLati)
            {
                case 3:
                    strR = "triangolo";
                    break;
                case 4:
                    strR = "quadrato";
                    break;
                case 5:
                    strR = "pentagono";
                    break;
                case 6:
                    strR = "esagono";
                    break;
                case 7:
                    strR = "ettagono";
                    break;
                case 8:
                    strR = "ottagono";
                    break;
                case 9:
                    strR = "ennagono";
                    break;
                case 10:
                    strR = "decagono";
                    break;
                case 11:
                    strR = "endecagono";
                    break;
                default:
                    strR = "non è accettato";
                    break;
            }

            return strR;
        }
    
        public string Confronta(Poligono p1, Poligono p2)
        {
            if(p1.nLati == p2.nLati)
            {
                if (p1.L_lati == p2.L_lati)
                    return "Il poligono passato è uguale";
                if (p1.L_lati < p2.L_lati)
                    return "Il poligono passato è più piccolo";
                else
                    return "Il poligono passato è più grande";
            }
            else
                return "Il poligono passato non è confrontabile";
        }
    }
}