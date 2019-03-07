using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppScuola
{
    class Program
    {
        static void Main(string[] args)
        {
            //input : nome e classe(5 classi)
            //output: classe : nome degli studenti

            const string Si = "s";

            do
            {
                Menu();


                Console.WriteLine("Vuoi tornare al menu principale? (s/n)");
            } while (Console.ReadLine().Equals(Si, StringComparison.InvariantCultureIgnoreCase));



            Console.ReadLine();
        }

        static Dictionary<int, List<string>> _elementiClasse = new Dictionary<int, List<string>>();


        static void Menu()
        {
            const string Nuovo = "N";
            const string Lista = "L";
            const string Fine = "F";

            string sceltaIns;



            //do
            //{
            Console.WriteLine(@"Inserisci una delle opzioni disponibili:
            'N' = Nuovo studente
            'L' = Visualizza Lista degli studenti
            //'C' = cerca uno specifico studente
            'F' = Fine");

            sceltaIns = Console.ReadLine();

            if (Nuovo.Equals(sceltaIns, StringComparison.InvariantCultureIgnoreCase))
            {
                inserimentoStudente(sceltaIns);


            }
            else if (Lista.Equals(sceltaIns, StringComparison.InvariantCultureIgnoreCase))
            {
                listaStud(sceltaIns);
            }
            else if (Fine.Equals(sceltaIns, StringComparison.InvariantCultureIgnoreCase))
            {

            }
            else
            {
                Console.WriteLine("scelta non valida");
                Console.ReadLine();
                return;
            }

            //    Console.ReadLine();
            //} while (!Fine.Equals(sceltaIns, StringComparison.InvariantCultureIgnoreCase));

        }



        static void inserimentoStudente(string a)
        {
            int nStudenti;


            Console.WriteLine("Quanti studenti vuoi inserire?");
            Int32.TryParse(Console.ReadLine(), out nStudenti);


            for (int i = 0; i < nStudenti; i++)
            {
                int _class;


                Console.WriteLine("inserisci il nome dello studente");

                string nomeStud = Console.ReadLine();

                Alunno alunno = new Alunno(nomeStud);




                //if (!string.IsNullOrWhiteSpace(name))
                //{



                Console.WriteLine("inserisci la classe dello studente");
                Int32.TryParse(Console.ReadLine(), out _class);


                while (!(_class > 0 && _class < 6))
                {
                    Console.WriteLine("Classe non valida. La classe deve essere compresa tra 1 e 5");
                    Console.WriteLine("Inserisci nuovamente la classe");
                    _class = Convert.ToInt32(Console.ReadLine());
                }

                if (!_elementiClasse.ContainsKey(_class))
                {
                    //List<string> studenti = new List<string>();
                    //studenti.Add(name);
                    //_elementiClasse.Add(_class, studenti);
                    _elementiClasse.Add(_class, new List<string>());
                }
                //else
                //{

                //List<string> studenti = _elementiClasse[_class];
                //studenti.Add(name);
                //}
                _elementiClasse[_class].Add(alunno._name);




            }
            foreach (KeyValuePair<int, List<string>> item in _elementiClasse)
            {

                foreach (string ite in item.Value)
                {
                    Console.WriteLine(item.Key + ite);
                }
                
                
            }
        }

        static void listaStud(string a)
        {


            Console.WriteLine("inserisci la classe di cui desideri visualizzare la lista degli studenti");
            int classeInserita = Convert.ToInt32(Console.ReadLine());


            foreach (KeyValuePair<int, List<string>> item in _elementiClasse)
            {
                if (item.Key == classeInserita)
                {
                    foreach (string ite in item.Value)
                    {
                        Console.WriteLine(ite);

                    }
                }
            }
        }

    }




}




