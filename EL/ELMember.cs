using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ELMember
    {
        // TC, üyenin TC kimlik numarasını temsil eden bir özelliktir.
        public string TC { get; set; }
        // NAME, üyenin adını temsil eden bir özelliktir.
        public string NAME { get; set; }
        // SURNAME, üyenin soyadını temsil eden bir özelliktir.
        public string SURNAME { get; set; }
        // BloodGroup, üyenin kan grubunu temsil eden bir özelliktir.
        public string BloodGroup { get; set; }
        // PhoneNumber, üyenin telefon numarasını temsil eden bir özelliktir.
        public string PhoneNumber { get; set; }
        // MailAdress, üyenin e-posta adresini temsil eden bir özelliktir.
        public string MailAdress { get; set; }
        // Adress, üyenin adresini temsil eden bir özelliktir.
        public string Adress { get; set; }
        // City, üyenin yaşadığı şehiri temsil eden bir özelliktir.
        public string City { get; set; }
        // Situation, üyenin genel durumunu temsil eden bir boolean özelliktir.
        public bool Situation { get; set; }
        // MemberDate, üyenin üye olduğu tarihi temsil eden bir özelliktir.
        public DateTime MemberDate { get; set; }
        // PaySituation, üyenin ödeme durumunu temsil eden bir boolean özelliktir.
        public bool PaySituation { get; set; }
        // Dues, üyenin ödenmemiş borcunu temsil eden bir özelliktir. Decimal türü, finansal veriler içindir.
        public decimal Dues { get; set; }
    }
}
