using DAL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Data.Common;

namespace BL
{
    public class BLdebts
    {

        public static int BLdeletedebt(string tcnumber)
        {
            bool ifexisting = DALdebt.IsMemberExists(tcnumber);
            if (ifexisting)

            {
                OleDbCommand cmd = new OleDbCommand("delete from Debts where TC=@tc", conn.con);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.AddWithValue("@tc", tcnumber);
                ELDues dues = new ELDues();
                dues.TC = tcnumber;
                dues.Paid = true;
                dues.PaidDate = DateTime.Now;
                BLdues.BLUpdatePaymentWithTc(dues);
                return cmd.ExecuteNonQuery();

            }
            else
            {
                return -1;
            }
        }

        public static void BLProcessAllDebts()
        {
            string query = "SELECT TC, Name, Surname, Email, SUM(PayAmount) AS TotalPayAmount " +
                           "FROM Dues " +
                           "WHERE Paid = false " +
                           "GROUP BY TC, Name, Surname, Email " +
                           "HAVING COUNT(*) > 1"; // Sadece iki kayıta sahip olanları seç

            conn.con.Open();

            OleDbCommand command = new OleDbCommand(query, conn.con);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string tcNumber = reader["TC"].ToString();
                string name = reader["Name"].ToString();
                string surname = reader["Surname"].ToString();
                string email = reader["Email"].ToString();
                decimal totalPayAmount = decimal.Parse(reader["TotalPayAmount"].ToString());

                bool IsDeptExists = DALdebt.IsDeptExists(tcNumber);
                // Debts tablosunda belirtilen TC numarasına ait kaydın var olup olmadığını kontrol et
                if (!IsDeptExists)
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

                        
                    }
                }
                else
                {
                   
                }


            }

            conn.con.Close();
        }

    }
}
