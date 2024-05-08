using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EL;


namespace DAL
{
    public class DALdues
    {

        public static List<ELDues> GetAllDues()
        {
            List<ELDues> Duessearch = new List<ELDues>();
            OleDbCommand commandDues = new OleDbCommand("SELECT * FROM Dues ", conn.con);
            ReadDuesData(commandDues, Duessearch);
            return Duessearch;
        }

        public static List<ELDues> DuesSearch(string tc)
        {
            List<ELDues> Duessearch = new List<ELDues>();
            OleDbCommand commandDues = new OleDbCommand("SELECT * FROM Dues WHERE TC LIKE @param + '%'", conn.con);
            commandDues.Parameters.AddWithValue("@param", tc);
            ReadDuesData(commandDues, Duessearch);
            return Duessearch;
        }

        public static List<ELDues> BelirliTarihlerArasindakiDues(DateTime baslangicTarihFormati, DateTime bitisTarihFormati)
        {
            List<ELDues> DuesArama = new List<ELDues>();

            OleDbCommand komutDues = new OleDbCommand("SELECT * FROM Dues WHERE (DatePaid BETWEEN @BaslangicTarihi AND @BitisTarihi) OR DatePaid IS NULL", conn.con);

            komutDues.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihFormati);
            komutDues.Parameters.AddWithValue("@BitisTarihi", bitisTarihFormati);

            if (komutDues.Connection.State != ConnectionState.Open)
            {
                komutDues.Connection.Open();
            }

            OleDbDataReader duesreader = komutDues.ExecuteReader();

            while (duesreader.Read())
            {
                ELDues due = new ELDues();

                // Eğer ödeme tarihi null ise, DuesMonth değerini al; aksi takdirde okunan değer atanır.
                due.DuesMonth = duesreader["DatePaid"] is DBNull ? (DateTime)duesreader["DuesMonth"] : (DateTime)duesreader["DatePaid"];
                due.TC = duesreader["TC"].ToString();
                due.DuesID = Convert.ToInt32(duesreader["MakbuzID"]);
                due.Paid = bool.Parse(duesreader["Paid"].ToString());
                due.PayAmount = decimal.Parse(duesreader["PayAmount"].ToString());
                due.NAME = duesreader["Name"].ToString();
                due.Surname = duesreader["Surname"].ToString();
                due.Email = duesreader["Email"].ToString();
                object datePaidValue = duesreader["DatePaid"];
                if (datePaidValue != null && DateTime.TryParse(datePaidValue.ToString(), out DateTime payDate))
                {
                    due.PaidDate = payDate;
                }
                else
                {
                    due.PaidDate = DateTime.MinValue;
                }

                DuesArama.Add(due);
            }

            duesreader.Close();
            komutDues.Connection.Close();

            return DuesArama;
        }

        public static List<ELDues> ListPaid()
        {

            List<ELDues> Duessearch = new List<ELDues>();
            OleDbCommand commandDues = new OleDbCommand("SELECT * FROM Dues where Paid= true ", conn.con);
            ReadDuesData(commandDues, Duessearch);
            return Duessearch;

        }

        public static List<ELDues> ListUnpaid()
        {
            List<ELDues> Duessearch = new List<ELDues>();
            OleDbCommand commandDues = new OleDbCommand("SELECT * FROM Dues where Paid= false ", conn.con);
            ReadDuesData(commandDues, Duessearch);
            return Duessearch;

        }

        public static List<ELDues> ListPaymenByMonths(string selectedMonths)
        {
            List<ELDues> Duessearch = new List<ELDues>();
            OleDbCommand commandDues = new OleDbCommand("SELECT * FROM Dues WHERE DuesMonth= @Month", conn.con);
            commandDues.Parameters.AddWithValue("@Month", selectedMonths);
            ReadDuesData(commandDues, Duessearch);

            return Duessearch;
        }

        public static void ReadDuesData(OleDbCommand command, List<ELDues> Duessearch)
        {
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            OleDbDataReader duesreader = command.ExecuteReader();

            while (duesreader.Read())
            {
                ELDues due = new ELDues();
                due.TC = duesreader["TC"].ToString();
                due.DuesID = Convert.ToInt32(duesreader["MakbuzID"]);
                due.Paid = bool.Parse(duesreader["Paid"].ToString());
                due.PayAmount = decimal.Parse(duesreader["PayAmount"].ToString());
                due.NAME = duesreader["Name"].ToString();
                due.Surname = duesreader["Surname"].ToString();
                due.Email = duesreader["Email"].ToString();
                object duesMonth = duesreader["DuesMonth"];
                if (duesMonth != null && DateTime.TryParse(duesMonth.ToString(), out DateTime dmonth))
                {
                    due.DuesMonth = dmonth;
                }
                else
                {
                    due.DuesMonth = DateTime.MinValue;
                }

                object datePaidValue = duesreader["DatePaid"];
                if (datePaidValue != null && DateTime.TryParse(datePaidValue.ToString(), out DateTime payDate))
                {
                    due.PaidDate = payDate;
                }
                else
                {
                    due.PaidDate = DateTime.MinValue;
                }

                Duessearch.Add(due);
            }
            duesreader.Close();
        }

        
       
    }
   
}
