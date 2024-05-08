using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{
    public class BLmember
    {



        public static int BLaddmember(ELMember tcnumber)
        {
            if (tcnumber.TC != null && tcnumber.TC.Length == 11)
            {

                OleDbCommand command = new OleDbCommand("insert into Member" +
                    " (TC,NAME,SURNAME,PhoneNumber,BloodGroup,Email,City,Adress,Situation,PaySituation,MemberDate,Dues) " +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", conn.con);


                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                command.Parameters.AddWithValue("@p1", tcnumber.TC);
                command.Parameters.AddWithValue("@p2", tcnumber.NAME);
                command.Parameters.AddWithValue("@p3", tcnumber.SURNAME);
                command.Parameters.AddWithValue("@p4", tcnumber.PhoneNumber);
                command.Parameters.AddWithValue("@p5", tcnumber.BloodGroup);
                command.Parameters.AddWithValue("@p6", tcnumber.MailAdress);
                command.Parameters.AddWithValue("@p7", tcnumber.City);
                command.Parameters.AddWithValue("@p8", tcnumber.Adress);
                command.Parameters.AddWithValue("@p9", tcnumber.Situation);
                command.Parameters.AddWithValue("@p10", tcnumber.PaySituation);
                command.Parameters.AddWithValue("@p11", tcnumber.MemberDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@p12", tcnumber.Dues);


                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    // Üye eklenmişse, Dues tablosuna da ekleyebiliriz.
                    BL.BLdues.BLAddDuesByAddingMember(tcnumber.TC, tcnumber.NAME, tcnumber.SURNAME, tcnumber.MailAdress, tcnumber.Dues, tcnumber.PaySituation, tcnumber.MemberDate);
                }

                return result;
            }

            return -1;
        }

        public static int BLdeletemember(string tcnumber)
        {
            bool ifexisting = DALmember.IsMemberExists(tcnumber);
            if (ifexisting)

            {
                OleDbCommand command2 = new OleDbCommand("delete from Member where TC=@tc", conn.con);
                if (command2.Connection.State != ConnectionState.Open)
                {
                    command2.Connection.Open();
                }
                command2.Parameters.AddWithValue("@tc", tcnumber);
                return command2.ExecuteNonQuery();

            }
            else
            {
                return -1;
            }
        }

        public static int BLupdateMembers(ELMember tcnumber)
        {
            if (tcnumber.TC != null)
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE Member SET NAME = @p2,SURNAME = @p3,PhoneNumber = @p4, " +
               "BloodGroup = @p5, Email = @p6, City = @p7, Adress = @p8, Situation = @p9, " +
               "PaySituation = @p10,  MemberDate = @p11, Dues= @p12 WHERE TC = @p1;", conn.con);

                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                cmd.Parameters.AddWithValue("@p2", tcnumber.NAME);
                cmd.Parameters.AddWithValue("@p3", tcnumber.SURNAME);
                cmd.Parameters.AddWithValue("@p4", tcnumber.PhoneNumber);
                cmd.Parameters.AddWithValue("@p5", tcnumber.BloodGroup);
                cmd.Parameters.AddWithValue("@p6", tcnumber.MailAdress);
                cmd.Parameters.AddWithValue("@p7", tcnumber.City);
                cmd.Parameters.AddWithValue("@p8", tcnumber.Adress);
                cmd.Parameters.AddWithValue("@p9", tcnumber.Situation);
                cmd.Parameters.AddWithValue("@p10", tcnumber.PaySituation);
                cmd.Parameters.AddWithValue("@p11", tcnumber.MemberDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@p12", tcnumber.Dues);
                cmd.Parameters.AddWithValue("@p1", tcnumber.TC);



                return cmd.ExecuteNonQuery();
            }
            return -1;
           

        }

        public static int BLsetDuesMember(ELMember PayAmount)
        {

            OleDbCommand setpay1 = new OleDbCommand("UPDATE Member SET Dues = @PaymentAmount", conn.con);
            setpay1.Parameters.AddWithValue("@PaymentAmount", PayAmount.Dues);
            return setpay1.ExecuteNonQuery();

        }

        public static void BLupdateSituation()
        {

            string sql = "UPDATE Member SET Situation = false , PaySituation = false " +
             "WHERE TC IN (SELECT Member.TC FROM Member " +
             "INNER JOIN Debts ON Member.TC = Debts.TC)";

            conn.con.Open();

            OleDbCommand command = new OleDbCommand(sql, conn.con);

            int rowsAffected = command.ExecuteNonQuery();

            conn.con.Close();
        }



        

    }
}
