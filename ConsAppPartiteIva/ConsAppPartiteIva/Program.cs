using System;
using System.Collections.Generic;

namespace ConsAppPartiteIva
{
    class Program
    {
        static void Main(string[] args)
        {

            VatNumberNormal fatt1 = new VatNumberNormal()
            {
                Code = 1234567890,

                Bills = new List<decimal>() { 500, 136, 190, 1200 },
                Expenses = new List<decimal>() { 100, 200, 50 }

            };

            VatNumberNormal fatt2 = new VatNumberNormal()
            {
                Code = 382613825,

                Bills = new List<decimal>() { 350, 450, 122, 75 },
                Expenses = new List<decimal>() { 35, 100, 98 }

            };

            List<VatNumberNormal> listVatNumberNormal = new List<VatNumberNormal>();
            listVatNumberNormal.Add(fatt1);
            listVatNumberNormal.Add(fatt2);

            VatNumberSimple fatt3 = new VatNumberSimple()
            {
                Code = 19352784,
                Bills = new List<decimal>() { 1500, 345, 700, 600 }

            };

            VatNumberSimple fatt4 = new VatNumberSimple()
            {
                Code = 394618232,
                Bills = new List<decimal>() { 3000, 200, 143, 734 }

            };

            List<VatNumberSimple> listVatNumberSimple = new List<VatNumberSimple>();
            listVatNumberSimple.Add(fatt3);
            listVatNumberSimple.Add(fatt4);



            Console.WriteLine(@"Seleziona una tipologia di fattura tra:
                               1.Fattura normale
                               2.Fattura semplificata");


            int scelta;
            
            while (true)
            {
             bool NumberOK = int.TryParse(Console.ReadLine(), out scelta);

                if (scelta > 0 && scelta <= 2 && NumberOK == true)
                {
                    break;
                }
                else if(scelta < 0 || scelta >2)
                {
                    Console.WriteLine("Il numero scelto non è compreso tra le opzioni valide");
                    
                }
                
                else
                    Console.WriteLine("Non hai inserito un numero, riprova");
            }
            

            switch (scelta)
            {
                case 1:

                    Console.WriteLine(@"Scegli tra:
                    1. Aggiungi Bill a P.Iva
                    2. Aggiungi Expensive a P.Iva
                    3. Calcola Guadagno netto e tasse totali di una P.Iva
                    4. Elenca tutte le P.Iva");


                    int.TryParse(Console.ReadLine(), out scelta);
                    int PIvaSelezionata;
                    switch (scelta)
                    {


                        case 1:
                            Console.WriteLine("Inserisci la P.Iva alla quale vuoi aggiungere la fattura");

                            int.TryParse(Console.ReadLine(), out PIvaSelezionata);

                            foreach (var vat in listVatNumberNormal)
                            {
                                if (vat.Code == PIvaSelezionata)
                                {

                                    Console.WriteLine("inserisci la fattura da aggiungere ");
                                    int.TryParse(Console.ReadLine(), out int _addBills);

                                    vat.Bills.Add(_addBills);


                                }
                                else 
                                {
                                    Console.WriteLine("Partita Iva non trovata");
                                }

                            }




                            break;

                        case 2:
                            Console.WriteLine("Inserisci la P.Iva alla quale vuoi aggiungere una Spesa");

                            int.TryParse(Console.ReadLine(), out PIvaSelezionata);

                            foreach (var vat in listVatNumberNormal)
                            {
                                if (vat.Code == PIvaSelezionata)
                                {

                                    Console.WriteLine("Inserisci la spesa da aggiungere");
                                    int.TryParse(Console.ReadLine(), out int _addExpense);

                                    vat.Expenses.Add(_addExpense);


                                }

                            }
                            break;

                        case 3:

                            decimal BillsTotal = 0;
                            decimal ExpenseTotal = 0;

                            Console.WriteLine("Inserisci la P.Iva della quale vuoi visualizzare il suo guadagno netto e il totale delle sue relative tasse");

                            int.TryParse(Console.ReadLine(), out PIvaSelezionata);

                            foreach (var vat in listVatNumberNormal)
                            {
                                if (vat.Code == PIvaSelezionata)
                                {

                                    foreach (var ite in vat.Bills)
                                    {
                                        BillsTotal += ite;

                                    }
                                    foreach (var ite in vat.Expenses)
                                    {
                                        ExpenseTotal += ite;
                                    }



                                    //Console.WriteLine(TotalBills);

                                }
                                

                            }

                            decimal Profit = BillsTotal - ExpenseTotal;
                            decimal Iva = (Profit*22)/100;
                            decimal Irpef = (Profit * 23) / 100;

                            Console.WriteLine($"Iva complessiva {Iva}");
                            Console.WriteLine($"Irpef {Irpef}");
                            break;

                        case 4:
                            foreach (var item in listVatNumberNormal)
                            {
                                Console.WriteLine($"P.Iva :{item.Code}");
                            }
                            break;


                    }





                    break;
                case 2:
                    break;

            }

            Console.Read();

        }

        class VatNumberNormal
        {
            public int Code;
            public List<decimal> Bills;
            public List<decimal> Expenses;
        }

        class VatNumberSimple
        {
            public int Code;
            public List<decimal> Bills;
        }
    }
}
