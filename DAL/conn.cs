using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // conn adında bir sınıf (class) tanımlanıyor.
    public class conn
    {
        // static olarak tanımlanmış bir OleDbConnection nesnesi oluşturdum.
        // static olarak tanımladım diğer sınıflarda paylaşım olması için
        // Yani, bu nesneye sınıf adı üzerinden erişilebilir.
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\AssociationTracking.accdb");
    }
}
