using EL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALdebt
    {
        public static void ProcessAllDebts()
        {
            string query = "SELECT TC, Name, Surname, Email, SUM(PayAmount) AS TotalPayAmount " +
                           "FROM Dues " +
                           "WHERE Paid = false " +
                           "GROUP BY TC, Name, Surname, Email " +
                           "HAVING COUNT(*) > 1"; // Sadece iki kayıta sahip olanları seç

            conn.con.Open();

            using (OleDbCommand command = new OleDbCommand(query, conn.con))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tcNumber = reader["TC"].ToString();
                        string name = reader["Name"].ToString();
                        string surname = reader["Surname"].ToString();
                        string email = reader["Email"].ToString();
                        decimal totalPayAmount = decimal.Parse(reader["TotalPayAmount"].ToString());

                        // Debts tablosunda belirtilen TC numarasına ait kaydın var olup olmadığını kontrol et
                        if (!IsDeptExists(tcNumber))
                        {
                            // "Debts" tablosuna ekleme işlemi
                            string insertDebtQuery = "INSERT INTO Debts (TC, Name, Surname, Email, DebtAmount) " +
                                                     "VALUES (@MemberTcNo, @MemberName, @MemberSurname, @Email, @DebtAmount)";

                            using (OleDbCommand insertDebtCommand = new OleDbCommand(insertDebtQuery, conn.con))
                            {
                                insertDebtCommand.Parameters.AddWithValue("@MemberTcNo", tcNumber);
                                insertDebtCommand.Parameters.AddWithValue("@MemberName", name);
                                insertDebtCommand.Parameters.AddWithValue("@MemberSurname", surname);
                                insertDebtCommand.Parameters.AddWithValue("@Email", email);
                                insertDebtCommand.Parameters.AddWithValue("@DebtAmount", totalPayAmount);

                                insertDebtCommand.ExecuteNonQuery();

                                Console.WriteLine($"Borç eklendi - Üye TC: {tcNumber}, Ad: {name}, Soyad: {surname}, Email: {email}, Borç Miktarı: {totalPayAmount}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Üye TC: {tcNumber} için zaten bir borç kaydı bulunmaktadır.");
                        }
                    }
                }
            }

            conn.con.Close();
        }

        public static bool IsDeptExists(string tcNumber)
        {
            using (OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Debts WHERE TC = @tc", conn.con))
            {
                command.Parameters.AddWithValue("@tc", tcNumber);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public static bool IsMemberExists(string tcNumber)
        {
            OleDbCommand isexist = new OleDbCommand("SELECT COUNT(*) FROM Debts WHERE TC = @tc", conn.con);
            isexist.Parameters.AddWithValue("@tc", tcNumber);

            if (isexist.Connection.State != ConnectionState.Open)
            {
                isexist.Connection.Open();
            }

            int count = (int)isexist.ExecuteScalar();
            return count > 0;

        }

        public static List<ELDebt> debtSearch(string tc)
        {
            List<ELDebt> listsearch = new List<ELDebt>();
            OleDbCommand command6 = new OleDbCommand("SELECT * FROM Debts WHERE TC LIKE @param + '%'", conn.con);
            command6.Parameters.AddWithValue("@param", tc);

            if (command6.Connection.State != ConnectionState.Open)
            {
                command6.Connection.Open();
            }

            OleDbDataReader reader = command6.ExecuteReader();
            GetDebtsInfo(listsearch, reader);
            return listsearch;
        }

        public static List<ELDebt> debtList()
        {
            List<ELDebt> listsearch = new List<ELDebt>();
            OleDbCommand command2 = new OleDbCommand("select * from Debts", conn.con);

            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }

            OleDbDataReader reader = command2.ExecuteReader();

            GetDebtsInfo(listsearch, reader);
            return listsearch;
        }

        public static List<ELDebt> GetDebts()
        {
            List<ELDebt> listsearch = new List<ELDebt>();
            OleDbCommand command6 = new OleDbCommand("SELECT DebtAmount, Email,Name,Surname FROM Debts", conn.con);

            try
            {
                if (command6.Connection.State != ConnectionState.Open)
                {
                    command6.Connection.Open();
                }

                OleDbDataReader reader = command6.ExecuteReader();

                while (reader.Read())
                {
                    ELDebt member = new ELDebt();
                    
                    member.email = reader["email"].ToString();
                    member.Name = reader["Name"].ToString();
                    member.Surname = reader["Surname"].ToString();
                    
                    if (decimal.TryParse(reader["DebtAmount"].ToString(), out decimal debtAmount))
                    {
                        member.DeptAmount = debtAmount;
                    }
                    else
                    {
                        member.DeptAmount = 0; // veya başka bir varsayılan değer
                    }

                    listsearch.Add(member);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                if (command6.Connection.State == ConnectionState.Open)
                {
                    command6.Connection.Close();
                }
            }

            return listsearch;
        }

        private static void GetDebtsInfo(List<ELDebt> listsearch, OleDbDataReader reader)
        {
            while (reader.Read())
            {
                ELDebt member = new ELDebt();
                member.TC = reader["TC"].ToString();
                member.Name = reader["NAME"].ToString();
                member.Surname = reader["SURNAME"].ToString();
                member.email = reader["email"].ToString();
                member.DeptAmount = decimal.Parse(reader["DebtAmount"].ToString());
                member.DeptID = Convert.ToInt32(reader["DebtID"].ToString());

                listsearch.Add(member);


            }
            reader.Close();
        }
    }
}
