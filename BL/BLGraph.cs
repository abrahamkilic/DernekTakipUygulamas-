using DAL;
using EL;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class BLGraph
    {
        public static List<double> GetMonthlyData(DateTime selectedYear)
        {
            List<double> monthlyData = new List<double>();

            for (int month = 1; month <= 12; month++)
            {
                // Bu sorgu, seçilen yılda belirli bir ayın toplam PayAmount'ını getirir
                using (OleDbCommand command = new OleDbCommand("SELECT SUM(PayAmount) AS TotalAmount " +
                                                               "FROM Dues " +
                                                               "WHERE YEAR(DatePaid) = @Year AND MONTH(DatePaid) = @Month AND Paid = true", conn.con))
                {
                    conn.con.Open();
                    command.Parameters.AddWithValue("@Year", selectedYear.Year);
                    command.Parameters.AddWithValue("@Month", month);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // DBNull kontrolü ekleyerek, null değerleri bir varsayılan değerle değiştir
                            double totalAmount = reader["TotalAmount"] != DBNull.Value
                                ? Convert.ToDouble(reader["TotalAmount"])
                                : 0.0; // Varsayılan değeri burada istediğiniz bir değerle değiştirebilirsiniz.

                            monthlyData.Add(totalAmount);
                        }
                    }
                }

                // Close the connection after each iteration
                conn.con.Close();
            }

            return monthlyData;
        }


        public static List<(string City, int MemberCount)> GetMemberStatsByCities()
        {
            string query = "SELECT City, COUNT(*) AS MemberCount FROM Member GROUP BY City";

            List<(string City, int MemberCount)> memberStats = new List<(string City, int MemberCount)>();


            using (OleDbCommand command = new OleDbCommand(query, conn.con))
            {
                conn.con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string city = reader["City"].ToString();
                    int memberCount = Convert.ToInt32(reader["MemberCount"]);

                    memberStats.Add((city, memberCount));
                }

                reader.Close();
                conn.con.Close();
            }


            return memberStats;
        }

        public static List<string> GetYearlyData()
        {
            List<string> yearlyData = new List<string>();

            string query = "SELECT Year(DatePaid) AS PaymentYear, SUM(PayAmount) AS TotalPayment " +
                           "FROM Dues " +
                           "WHERE Paid = true " +
                           "GROUP BY Year(DatePaid)"; // Yılları artan şekilde sırala

            using (OleDbCommand command = new OleDbCommand(query, conn.con))
            {
                conn.con.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string year = reader["PaymentYear"].ToString();
                        yearlyData.Add(year);
                    }
                }
            }

            conn.con.Close();
            return yearlyData;
        }

        public static List<decimal> GetYearlyPaymentTotals()
        {
            List<decimal> yearlyPaymentTotals = new List<decimal>();

            string query = "SELECT Year(DatePaid) AS PaymentYear, SUM(PayAmount) AS TotalPayment " +
                           "FROM Dues " +
                           "WHERE Paid = true " +
                           "GROUP BY Year(DatePaid) " +
                           "ORDER BY Year(DatePaid)";

            using (OleDbCommand command = new OleDbCommand(query, conn.con))
            {
                conn.con.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal totalPayment = Convert.ToDecimal(reader["TotalPayment"]);
                        yearlyPaymentTotals.Add(totalPayment);
                    }
                }
            }

            conn.con.Close();
            return yearlyPaymentTotals;
        }



    }
}

