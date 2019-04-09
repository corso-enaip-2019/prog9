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

            /*
            lista di impiegati creata come mock
            per ogni impiegato della lista
               se è il suo giorno di paga
                   calcola la sua paga
                   crea un record con l'id dell'impiegato, la paga, e la data di oggi
                   aggiungi alla lista di record 
             */
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal TotalPayment { get; set; }
            public decimal Pay = 0;
            public bool IsPayDay;

            public virtual decimal CalcolatePay()
            {
                return Pay;
            }
            
        }

        class FixedSalary: Employee
        {
            public decimal Pay = 1500;
            public override decimal CalcolatePay()
            {
                return Pay;
            }

        }

        class HourlyPay:Employee
        {
            public decimal Pay = 0;
            public override decimal CalcolatePay()
            {


                return base.CalcolatePay();
            }
        }

        class CommissionPay:Employee
        {


        }


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
