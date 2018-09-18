using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHarjoituspäivä2
{
    class Program
    {
        static void Main(string[] args)
            {
                List<int> integerLista = new List<int>();       //määritellään int-tyyppinen lista 
                int intLuku = 0;                                //määritellään int-tyyppinen muuttuja ja sijoitetaan siihen nolla
                string strNimi= "0";                           //tätä muuttujaa käytetään kun luetaan luku konsolilta
                while (strNimi.Length > 0)                      //lopetetaan, jos käyttäjä ei antanut enää uutta arvoa
                {                                               //aloitetaan DO - WHILE -silmukka
                    Console.Write("Anna nimi: ");               //kysytään uusi luku
                    strNimi = Console.ReadLine();               //talletetaan käyttäjän antama luku muuttujaan
                    //if (strNimi != "")
                        //if (int.Parse(strNimi) > 10000)
                        //{
                        //    Console.WriteLine("Liian suuri luku: " + strNimi);
                        //}
                        //else
                        //{
                        //    intLuku = int.Parse(strNimi);           //talletetaan käyttäjän antama luku muuttujaan
                        //    integerLista.Add(intLuku);              //lisätään listaan uusi alkio
                        //}
                }

            Console.WriteLine();
            Console.WriteLine("Haluatko lajitella nousevassa vai laskevassa järjestyksessä? ");


                integerLista.Sort();                            //Lajitellaan LISTA nousevaan järjestykseen
                integerLista.Reverse();                           //Lajitellaan LISTA laskevaan järjestykseen
                for (int i = 0; i < integerLista.Count; i++)      //aloitetaan FOR -silmukka. Kierroksia niin monta, kuin LISTASSA on alkioita
                {
                    if (integerLista[i] >= 1000)
                    {
                        Console.WriteLine("Listan alkio (" + i + ") on: " + integerLista[i]);
                    }
                }
                //Console.WriteLine("Lukujen Summa on: " + intSumma.ToString());    //Kirjoitetaan intSumma konsolille, eli lukujen summalaskun tulos
                Console.WriteLine();                            //Kirjoitetaan tyhjä rivi
                Console.Write("Paina enter lopettaaksesi");     //Annetaan ohje siitä miten ohjelman suoritus päätetään
                Console.ReadLine();
            }
        }
    }