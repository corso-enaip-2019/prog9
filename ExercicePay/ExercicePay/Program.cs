
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePay
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2019, 01, 31);

            List<Employee> employees = employeesList();
            foreach (var item in employees)
            {
                if (item.IsPayDay(dt))
                {
                    Console.WriteLine($"{item.Id} {item.Name}");
                    item.CalcolatePay();
                    Console.WriteLine($"{dt}");
                }
            }






            Console.Read();

            /*
            lista di impiegati creata come mock
            per ogni impiegato della lista
               se è il suo giorno di paga
                   calcola la sua paga
                   crea un record con l'id dell'impiegato, la paga, e la data di oggi
                   aggiungi alla lista di record 
             */
        }

        

        public static List<Employee> employeesList()
        {
            return new List<Employee>
            {
                new FixedSalary{Id = 01, Name = "Stefano Aspire"},
                new FixedSalary{Id = 03, Name = "Joseph Joestar"},
                new HourlyPay{Id = 02,Name = "Giacomo Leopardi"},
                new HourlyPay{Id = 07,Name = "Jean Claude Van Damme"},
                new HourlyPay{Id = 05, Name ="Sasha Grey"},
                new CommissionPay{Id = 04, Name ="Tom Cruise"},
            };
        }
    }

    abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalPayment { get; set; }
        public abstract bool IsPayDay(DateTime date);
        public abstract void CalcolatePay();
    }

    class FixedSalary : Employee
    {
        public decimal FPay = 1500;

        public override bool IsPayDay(DateTime date)
        {
            if (date == GetLastDayOfMonth())
                return true;
            else
                return false;
        }

        public override void CalcolatePay()
        {
            Console.WriteLine( FPay ); 
        }

        public static DateTime GetLastDayOfMonth()
        {
            DateTime dt = new DateTime();
            dt = dt.AddMonths(1);
            dt = dt.AddDays(-dt.Day);

            return dt;
        }
    }

    class HourlyPay : Employee
    {
        public decimal HPay = 0;
        public decimal oreLavorate { get; set; }

        public override bool IsPayDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday)
                return true;
            else
                return false;
        }

        public override void CalcolatePay()
        {
            HPay = oreLavorate * 10;

            Console.WriteLine( HPay ); 
        }
    }

    class CommissionPay : Employee
    {
        public decimal CommPay = 0;
      
        public override bool IsPayDay(DateTime date)
        {
            return true;
        }

        public static List<Record> records()
        {
            return new List<Record>
            {
                new Record{Vendita=353.6m ,  Date = new DateTime(2019,1,10)},
                new Record{Vendita=1300m ,  Date = new DateTime(2019,1,11)},
                new Record{Vendita=1560.30m ,  Date = new DateTime(2019,1,11)},
                new Record{Vendita=1200m ,  Date = new DateTime(2019,1,15)},
                new Record{Vendita=750.5m ,  Date = new DateTime(2019,1,31)},
                new Record{Vendita=800.7m ,  Date = new DateTime(2019,1,31)},
                new Record{Vendita=400m ,  Date = new DateTime(2019,1,20)},
            };
        }

        public override void CalcolatePay()
        {
        }

        //public override void CalcolatePay(List<Record> list, DateTime date)
        //{

        //    decimal DailyPay = 0;
        //    foreach (var item in list)
        //    {
        //        if (date == item.Date)
        //        {
        //            DailyPay += (item.Vendita / 100) * 10;
        //        }

        //    }

        //    Console.WriteLine(DailyPay); 
        //}
    }

    class Record
    {
        public decimal Vendita { get; set; }
        public DateTime Date { get; set; }
    }
}
/*
     * Esercizio: implementare un sistema di Payroll.
     * Un trigger chiama l'applicazione ogni giorno alle 23:59.
     * L'applicazione itera su tutti gli impiegati registrati,
     *     e in caso sia il loro giorno di paga, calcola la paga e registra un record con il pagamento.
     * Gli impiegati di base hanno Id e Nome. Sono di 3 tipi:
     * 1) A salario fisso
     *     - hanno una proprietà con il salario fisso mensile;
     *     - il giorno di paga è l'ultimo del mese.
     * 2) A ore
     *     - hanno una paga oraria, e un elenco di record che registra per ogni giorno lavorato il numero di ore lavorate;
     *     - il giorno di paga è sempre il sabato, e calcola la paga dei giorni lun-ven della settimana corrente;
     * 3) A commissione
     *     - la paga è una percentuale sulle vendite effettuate; hanno un elenco di record con l'ammontare di una vendita e la data.
     *     - la paga è giorno per giorno, sulle vendite di quel giorno.
     *     
     * Nel Main() è illustrato l'algoritmo che si vuole ottenere.
     */
