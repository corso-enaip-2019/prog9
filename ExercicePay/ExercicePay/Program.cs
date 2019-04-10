
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

            var employees = CreateMockEmployees();

            var paycheckRecords = new List<PaycheckRecord>();

            var date = new DateTime(2019, 8, 31);

            foreach (var e in employees)
            {
                if (e.IsPayDay(date))
                {
                    var paycheck = e.CalculatePay(date);
                    var record = new PaycheckRecord(e.Id, DateTime.Today, paycheck);
                    paycheckRecords.Add(record);
                }
            }

            Console.Read();
        }

        static List<Employee> CreateMockEmployees()
        {
            var fs = new FixedSalary
            {
                Id = 1,
                Name = "Mario Rossi",
                FPay = 1500.00M,
            };

            var hp = new HourlyPay
            {
                Id = 2,
                Name = "Luigi Neri",
                HourlyRate = 20,
            };
            hp.AddWorkedHours(2019, 8, 31, 4);
            hp.AddWorkedHours(2019, 8, 30, 6);
            hp.AddWorkedHours(2019, 8, 29, 2);
            hp.AddWorkedHours(2019, 8, 14, 5);

            var cp = new CommissionPay
            {
                Id = 3,
                Name = "Anna Gialli",
                Percentage = 2,
            };

            cp.AddCommission(2019, 8, 31, 2000);
            cp.AddCommission(2019, 8, 31, 1500.50M);
            cp.AddCommission(2019, 8, 7, 3000);

            return new List<Employee> { fs, hp, cp };
        }



        /*
        lista di impiegati creata come mock
        per ogni impiegato della lista
           se è il suo giorno di paga
               calcola la sua paga
               crea un record con l'id dell'impiegato, la paga, e la data di oggi
               aggiungi alla lista di record 
         */
    }



    //public static List<Employee> employeesList()
    //{
    //    return new List<Employee>
    //    {
    //        new FixedSalary{Id = 01, Name = "Stefano Aspire"},
    //        new FixedSalary{Id = 03, Name = "Joseph Joestar"},
    //        new HourlyPay{Id = 02,Name = "Giacomo Leopardi"},
    //        new HourlyPay{Id = 07,Name = "Jean Claude Van Damme"},
    //        new HourlyPay{Id = 05, Name ="Sasha Grey"},
    //        new CommissionPay{Id = 04, Name ="Tom Cruise"},
    //    };
    //}

    class PaycheckRecord
    {
        public PaycheckRecord() { }

        public PaycheckRecord(int employeeId, DateTime date, decimal paycheck)
        {
            EmployeeId = employeeId;
            Date = date;
            Paycheck = paycheck;
        }

        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Paycheck { get; set; }
    }
}

abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal TotalPayment { get; set; }
    public abstract bool IsPayDay(DateTime date);
    public abstract decimal CalculatePay(DateTime date);
}

class FixedSalary : Employee
{
    public decimal FPay { get; set; }

    public override bool IsPayDay(DateTime date)
    {
        return (date == GetLastDayOfMonth());

    }

    public override decimal CalculatePay(DateTime date)
    {
        return FPay;
    }

    public static DateTime GetLastDayOfMonth()
    {
        DateTime dt = new DateTime(2019, 01, 20);
        dt = dt.AddMonths(1);
        dt = dt.AddDays(-dt.Day);

        return dt;
    }
}

class HourlyPay : Employee
{
    public HourlyPay()
    {
        _WorkedTimes = new List<WorkedTime>();
    }

    public IEnumerable<WorkedTime> WorkedTimes
    { get { return _WorkedTimes; } }

    private readonly List<WorkedTime> _WorkedTimes;

    public decimal HourlyRate { get; set; }

    public void AddWorkedHours(int year, int month, int day, int workedHours)
    {
        _WorkedTimes.Add(new WorkedTime(year, month, day, workedHours));
    }


    public override bool IsPayDay(DateTime date)
    {
        return (date.DayOfWeek == DayOfWeek.Saturday);

    }

    public override decimal CalculatePay(DateTime date)
    {
        //var now = DateTime.Now.AddDays(1).Date;
        var now = DateTime.Today.AddDays(1);

        var start = now.AddDays(-7);

        var workedHours = WorkedTimes
            .Where(wt => start < wt.Date && wt.Date < now)
            .Sum(wt => wt.Hours);

        return workedHours * HourlyRate;
    }

    public struct WorkedTime
    {
        public WorkedTime(int year, int month, int day, int hours)
        {
            Date = new DateTime(year, month, day);
            Hours = hours;
        }
        public WorkedTime(DateTime date, int hours)
        {
            Date = date;
            Hours = hours;
        }


        public DateTime Date { get; }
        public int Hours { get; }
    }
}


    class CommissionPay : Employee
    {
        public int Percentage { get; set; }

        public struct SoldCommission
        {
            public SoldCommission(int year, int month, int day, decimal amount)
                : this(new DateTime(year, month, day), amount)
            {
            }

            public SoldCommission(DateTime date, decimal amount)
            {
                Date = date;
                CommPay = amount;
            }

            public decimal CommPay { get; }
            public DateTime Date { get; }
        }

        public override bool IsPayDay(DateTime date)
        {
            return true;
        }

        public CommissionPay()
        {
            _SoldCommissions = new List<SoldCommission>();
        }

        public IEnumerable<SoldCommission> SoldCommissions
        {
            get { return _SoldCommissions; }
        }
        private List<SoldCommission> _SoldCommissions;

        public void AddCommission(int year, int month, int day, decimal amount)
        {
            _SoldCommissions.Add(new SoldCommission(year, month, day, amount));
        }

        public override decimal CalculatePay(DateTime date)
        {
            var soldAmount = _SoldCommissions
                .Where(sc => sc.Date == date.Date)
                .Sum(sc => sc.CommPay);

            return soldAmount * Percentage / 100;
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
