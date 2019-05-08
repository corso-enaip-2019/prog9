using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBonus(0.7, 3, 100);
            Console.WriteLine("Operation successfull,press a key to exit...");
            Console.Read();
        }

        static void AddBonus(double minProductivity, int maxCount, int bonus)
        {
            var employees = ReadEmployeesFromDb();
            var employeesAboveProd = employees
                .Where(x => x.Productivity > minProductivity)
                .ToList();

            if (employeesAboveProd.Count > maxCount)
            {
                employeesAboveProd = employeesAboveProd
                    .Take(maxCount)
                    .OrderByDescending(x => x.Productivity)
                    .ToList();
            }

            //employeesAboveProd.ForEach(e => e.TotalBonus += bonus);
            foreach (var e in employeesAboveProd)
                e.TotalBonus += bonus;

            UpdateEmployees(employeesAboveProd);
        }

        static List<Employees> ReadEmployeesFromDb()
        {
            var result = new List<Employees>();

            using (var conn = new SqlConnection(@"Server=TRISRV10\SQLEXPRESS;Database=CS2019_Levak_01;Trusted_Connection=True;"))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Id,Name,Productivity,TotalBonus FROM Employees";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var e = new Employees
                            {
                                Id = (int)reader[0],
                                Name = (string)reader["Name"],
                                Productivity = reader.GetDouble(2),
                                TotalBonus = reader.GetInt32(3),
                            };
                            result.Add(e);
                        }
                    }
                }
            }

            return result;
        }

        private static void UpdateEmployees(List<Employees> employees)
        {
            using (var conn = new SqlConnection(@"Server=TRISRV10\SQLEXPRESS;Database=CS2019_Levak_01;Trusted_Connection=True;"))
            {
                conn.Open();


                var updates = employees
                    .Select(e => CreateCmdForUpdate(e, conn));

                foreach (var cmd in updates)
                    cmd.ExecuteNonQuery();
            }
        }

        private static SqlCommand CreateCmdForUpdate(Employees e, SqlConnection conn)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE Employees SET TotalBonus = {e.TotalBonus} WHERE Id = {e.Id}";

            return cmd;
        }
    }
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Productivity { get; set; }
        public int TotalBonus { get; set; }
    }
}
