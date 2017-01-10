using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class Fisher
    {
        private int[][] systemDecyzyjny;

        public Fisher(int[][] system)
        {
            this.systemDecyzyjny = system;
        }

        //Oblicza S(stopień separacji), 1-wszy wymiar to klasa, 2-gi to obliczone S dla atrybutów 0,1,2...
        private double[][] ObliczS()
        {
            int wysokosc = systemDecyzyjny.Length;
            int szerokosc = systemDecyzyjny[0].Length;

            int[] klasy = ZnajdzKlasy(systemDecyzyjny);
            int iloscKlas = klasy.Count();

            double cardA;
            double cardU = wysokosc;

            double licznikCZDaszkiem;
            double licznikCZDziubkiem;
            double wynikCZDziubkiem;
            double wynikCZDaszkiem;


            double licznikZCZDaszkiem;
            double licznikZCZDziubkiem;
            double wynikZCZDaszkiem;
            double wynikZCZDziubkiem;

            double S = 0;

            double[][] wyniki = new double[iloscKlas][];
            int klasaCentralna = 0;

            foreach (int klasa in klasy)
            {
                wyniki[klasaCentralna] = new double[szerokosc - 1];
                for (int atrybut = 0; atrybut < szerokosc - 1; atrybut++)
                {

                    licznikCZDaszkiem = 0;
                    cardA = 0;
                    wynikCZDaszkiem = 0;
                    licznikCZDziubkiem = 0;
                    wynikCZDziubkiem = 0;
                    wynikCZDziubkiem = 0;
                    licznikZCZDaszkiem = 0;
                    licznikZCZDziubkiem = 0;

                    for (int obiekt = 0; obiekt < wysokosc; obiekt++)
                    {
                        if (klasa == systemDecyzyjny[obiekt][szerokosc - 1])
                        {
                            cardA++;
                            licznikCZDaszkiem += systemDecyzyjny[obiekt][atrybut];
                        }
                        if (klasa != systemDecyzyjny[obiekt][szerokosc - 1])
                        {
                            licznikCZDziubkiem += systemDecyzyjny[obiekt][atrybut];
                        }
                    }
                    wynikCZDaszkiem = licznikCZDaszkiem / cardA;
                    wynikCZDziubkiem = licznikCZDziubkiem / (cardU - cardA);

                    for (int obiekt = 0; obiekt < wysokosc; obiekt++)
                    {
                        if (klasa == systemDecyzyjny[obiekt][szerokosc - 1])
                        {
                            licznikZCZDaszkiem += Math.Pow((systemDecyzyjny[obiekt][atrybut] - wynikCZDaszkiem), 2);
                        }
                        if (klasa != systemDecyzyjny[obiekt][szerokosc - 1])
                        {
                            licznikZCZDziubkiem += Math.Pow((systemDecyzyjny[obiekt][atrybut] - wynikCZDziubkiem), 2);
                        }
                    }

                    wynikZCZDaszkiem = licznikZCZDaszkiem / cardA;
                    wynikZCZDziubkiem = licznikZCZDziubkiem / (cardU - cardA);

                    S = Math.Pow((wynikCZDaszkiem - wynikCZDziubkiem), 2) / (wynikZCZDaszkiem + wynikZCZDziubkiem);
                    wyniki[klasaCentralna][atrybut] = S;
                }
                klasaCentralna++;
            }
            return wyniki;
        }

        //Zwraca listę z najlepiej separującymi atrybutami
        private List<int> Separuj(int liczbaWybranychAtrybutów)
        {
            double[][] tablica = ObliczS();
            int najwiekszyAtrybut;
            List<int> separatory = new List<int>();
            int szerokosc = tablica[0].Length - 1;
            for (int i = 0; i < szerokosc - 1; i++)
            {
                for (int klasa = 0; klasa < tablica.Length; klasa++)
                {
                    najwiekszyAtrybut = Array.IndexOf(tablica[klasa], tablica[klasa].Max());//Indeks najwiekszego atrybutu
                    if (!separatory.Contains(najwiekszyAtrybut) && tablica[klasa][najwiekszyAtrybut] != -1)
                    {
                        separatory.Add(najwiekszyAtrybut);
                        tablica[klasa][najwiekszyAtrybut] = -1;
                    }
                    else
                    {
                        tablica[klasa][najwiekszyAtrybut] = -1;
                    }

                    if (separatory.Count == liczbaWybranychAtrybutów)
                    {
                        return separatory;
                    }
                }
            }
            return separatory;
        }

        //Fukncja zwracająca string z końcowym wynikiem
        public string SystemPoSelekcji(int liczbaWybranychAtrybutow)
        {
            List<int> separatory = Separuj(liczbaWybranychAtrybutow);
            string raport = "                       ";
            for (int k = 0; k < separatory.Count; k++)
            {
                raport+=("atrybut " + (separatory[k]+1)+"    ");    
            }
            raport += Environment.NewLine;
            for (int i = 0; i < systemDecyzyjny.Length; i++)
            {
                raport += "Obiekt[" + (i+1) + "] - ";
                for (int j = 0; j < separatory.Count; j++)
                {
                    raport += "               " + systemDecyzyjny[i][separatory[j]];
                }
                raport += Environment.NewLine;
                raport += Environment.NewLine;
            }
            return raport;
        }


        //Zwraca tablicę z unikalnymi klasami
        private int[] ZnajdzKlasy(int[][] system)
        {
            int wysokosc = systemDecyzyjny.Length;
            int szerokosc = systemDecyzyjny[0].Length;
            int[] klasy = new int[wysokosc];
            for (int rzad = 0; rzad < system.Length; rzad++)
                klasy[rzad] = system[rzad][system[0].Length - 1];
            return klasy.Distinct().ToArray();
        }
    }
}
