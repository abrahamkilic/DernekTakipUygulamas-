using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EL;


namespace DAL
{
    public class DALmember
    {

        //crud metotları
        //ekle silme güncelleme listeleme
        public static bool IsMemberExists(string tcNumber)
        {
            OleDbCommand isexist = new OleDbCommand("SELECT COUNT(*) FROM Member WHERE TC = @tc", conn.con);
            isexist.Parameters.AddWithValue("@tc", tcNumber);

            if (isexist.Connection.State != ConnectionState.Open)
            {
                isexist.Connection.Open();
            }

            int count = (int)isexist.ExecuteScalar();
            return count > 0;

        }

        public static List<ELMember> memberList()
        {
            List<ELMember> list = new List<ELMember>();
            OleDbCommand command2 = new OleDbCommand("select * from Member", conn.con);

            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }

            OleDbDataReader reader = command2.ExecuteReader();

            while (reader.Read())
            {
                ELMember member = new ELMember();
                member.TC = reader["TC"].ToString();
                member.NAME = reader["NAME"].ToString();
                member.SURNAME = reader["SURNAME"].ToString();
                member.BloodGroup = reader["BloodGroup"].ToString();
                member.PhoneNumber = reader["PhoneNumber"].ToString();
                member.MailAdress = reader["Email"].ToString();
                member.City = reader["City"].ToString();
                member.Adress = reader["Adress"].ToString();
                member.Situation = bool.Parse(reader["Situation"].ToString());
                member.PaySituation = bool.Parse(reader["PaySituation"].ToString());
                member.MemberDate = DateTime.Parse(reader["MemberDate"].ToString());
                member.Dues = decimal.Parse(reader["Dues"].ToString());

                list.Add(member);


            }
            reader.Close();
            return list;
        }

        public static List<ELMember> GetBloodGroup(string selectedBloodGroup)
        {

            List<ELMember> listblood = new List<ELMember>();
            OleDbCommand command3 = new OleDbCommand("SELECT * FROM Member WHERE BloodGroup = @BloodGroup", conn.con);

            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@BloodGroup", selectedBloodGroup);

            OleDbDataReader reader = command3.ExecuteReader();

            while (reader.Read())
            {
                ELMember member = new ELMember();
                member.TC = reader["TC"].ToString();
                member.NAME = reader["NAME"].ToString();
                member.SURNAME = reader["SURNAME"].ToString();
                member.BloodGroup = reader["BloodGroup"].ToString();
                member.PhoneNumber = reader["PhoneNumber"].ToString();
                member.MailAdress = reader["Email"].ToString();
                member.City = reader["City"].ToString();
                member.Adress = reader["Adress"].ToString();
                member.Situation = bool.Parse(reader["Situation"].ToString());
                member.PaySituation = bool.Parse(reader["PaySituation"].ToString());
                member.MemberDate = DateTime.Parse(reader["MemberDate"].ToString());

                listblood.Add(member);


            }
            reader.Close();
            return listblood;
        }

        public static List<ELMember> GetByCities(string selectedcity)
        {

            List<ELMember> citylist = new List<ELMember>();
            OleDbCommand command4 = new OleDbCommand("SELECT * FROM Member WHERE City = @city", conn.con);

            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@city", selectedcity);
            OleDbDataReader reader = command4.ExecuteReader();
            while (reader.Read())
            {
                ELMember member = new ELMember();
                member.TC = reader["TC"].ToString();
                member.NAME = reader["NAME"].ToString();
                member.SURNAME = reader["SURNAME"].ToString();
                member.BloodGroup = reader["BloodGroup"].ToString();
                member.PhoneNumber = reader["PhoneNumber"].ToString();
                member.MailAdress = reader["Email"].ToString();
                member.City = reader["City"].ToString();
                member.Adress = reader["Adress"].ToString();
                member.Situation = bool.Parse(reader["Situation"].ToString());
                member.PaySituation = bool.Parse(reader["PaySituation"].ToString());
                member.MemberDate = DateTime.Parse(reader["MemberDate"].ToString());

                citylist.Add(member);


            }
            reader.Close();
            return citylist;
        }

        public static List<ELMember> GetBySituation(bool selectedSituation)
        {

            List<ELMember> SituationList = new List<ELMember>();
            OleDbCommand command5 = new OleDbCommand("SELECT * FROM Member WHERE Situation = @situation", conn.con);

            if (command5.Connection.State != ConnectionState.Open)
            {
                command5.Connection.Open();
            }
            command5.Parameters.AddWithValue("@situation", selectedSituation);
            OleDbDataReader reader = command5.ExecuteReader();
            while (reader.Read())
            {
                ELMember member = new ELMember();
                member.TC = reader["TC"].ToString();
                member.NAME = reader["NAME"].ToString();
                member.SURNAME = reader["SURNAME"].ToString();
                member.PhoneNumber = reader["PhoneNumber"].ToString();
                member.MailAdress = reader["Email"].ToString();
                member.Situation = bool.Parse(reader["Situation"].ToString());
                member.PaySituation = bool.Parse(reader["PaySituation"].ToString());
                member.Dues = decimal.Parse(reader["Dues"].ToString());
                SituationList.Add(member);
            }
            reader.Close();
            return SituationList;
        }

        public static List<ELMember> memberSearch(string tc)
        {
            List<ELMember> listsearch = new List<ELMember>();
            OleDbCommand command6 = new OleDbCommand("SELECT * FROM Member WHERE TC LIKE @param + '%'", conn.con);
            command6.Parameters.AddWithValue("@param", tc);

            if (command6.Connection.State != ConnectionState.Open)
            {
                command6.Connection.Open();
            }

            OleDbDataReader reader = command6.ExecuteReader();

            while (reader.Read())
            {
                ELMember member = new ELMember();
                member.TC = reader["TC"].ToString();
                member.NAME = reader["NAME"].ToString();
                member.SURNAME = reader["SURNAME"].ToString();
                member.BloodGroup = reader["BloodGroup"].ToString();
                member.PhoneNumber = reader["PhoneNumber"].ToString();
                member.MailAdress = reader["Email"].ToString();
                member.City = reader["City"].ToString();
                member.Adress = reader["Adress"].ToString();
                member.Situation = bool.Parse(reader["Situation"].ToString());
                member.PaySituation = bool.Parse(reader["PaySituation"].ToString());
                member.MemberDate = DateTime.Parse(reader["MemberDate"].ToString());

                listsearch.Add(member);


            }
            reader.Close();
            return listsearch;
        }






    }
}
