using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace BL
{
    public class BLdues
    {
        public static void BLAddDuesByAddingMember(string tc, string name, string surname, string email, decimal pay, bool PaySituation, DateTime PaidDate)
        {
            // Dues tablosuna sadece TC, Name, Surname, ve Email ekleyeceğimiz için diğer sütunlara değer eklemiyoruz.
            OleDbCommand duesCommand = new OleDbCommand("insert into Dues (TC, NAME, SURNAME, Email,PayAmount,Paid,DatePaid,DuesMonth) " +
                                                        "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7,@p8)", conn.con);

            duesCommand.Parameters.AddWithValue("@p1", tc);
            duesCommand.Parameters.AddWithValue("@p2", name);
            duesCommand.Parameters.AddWithValue("@p3", surname);
            duesCommand.Parameters.AddWithValue("@p4", email);
            duesCommand.Parameters.AddWithValue("@p5", pay);
            duesCommand.Parameters.AddWithValue("@p6", PaySituation);
            duesCommand.Parameters.AddWithValue("@p7", PaidDate.ToString("yyyy-MM-dd"));
            duesCommand.Parameters.AddWithValue("@p8", new DateTime(PaidDate.Year, PaidDate.Month, 15));
            duesCommand.ExecuteNonQuery();
        }

        public static int BLPayDues(ELDues tcnumber)
        {
            OleDbCommand aidat = new OleDbCommand("UPDATE Dues SET DatePaid = @PaymentDate, Paid = @Paid WHERE MakbuzID = @PaymentID", conn.con);
            if (aidat.Connection.State != ConnectionState.Open)
            {
                aidat.Connection.Open();
            }
            aidat.Parameters.AddWithValue("@PaymentDate", tcnumber.PaidDate.ToString("yyyy-MM-dd"));
            aidat.Parameters.AddWithValue("@Paid", tcnumber.Paid);
            aidat.Parameters.AddWithValue("@PaymentID", tcnumber.DuesID);

            return aidat.ExecuteNonQuery();
        }

        public static int BLsetdues(ELDues PayAmount)
        {
            OleDbCommand setpay = new OleDbCommand("INSERT INTO Dues (TC, Name, Surname, Email,PayAmount, DuesMonth) " +
                                "SELECT M.TC, M.NAME, M.SURNAME, M.Email, @PayAmount, @DuesMonth " +
                                "FROM Member M " +
                                "WHERE M.Situation = true", conn.con);
            setpay.Parameters.AddWithValue("@PayAmount", PayAmount.PayAmount);
            setpay.Parameters.AddWithValue("@DuesMonth", new DateTime (DateTime.Now.Year, DateTime.Now.Month,15).AddMonths(1));

            if (setpay.Connection.State != ConnectionState.Open)
            {
                setpay.Connection.Open();
            }

            return setpay.ExecuteNonQuery();
        }

        public static int BLUpdatePaymentWithTc(ELDues dues)
        {

            OleDbCommand oleDbCommand = new OleDbCommand("UPDATE Dues SET DatePaid = @PaymentDate, Paid = @Paid WHERE TC = @MemberTcNo", conn.con);
            if (oleDbCommand.Connection.State != ConnectionState.Open)
            {
                oleDbCommand.Connection.Open();
            }
            oleDbCommand.Parameters.AddWithValue("@PaymentDate", dues.PaidDate.ToString("yyyy-MM-dd"));
            oleDbCommand.Parameters.AddWithValue("@Paid", dues.Paid);
            oleDbCommand.Parameters.AddWithValue("@MemberTcNo", dues.TC);

            return oleDbCommand.ExecuteNonQuery();
        }
    }
}
