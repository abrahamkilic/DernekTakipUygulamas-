using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ELDues
    {

        // DuesID, ödenmemiş/ödenmiş aidatın benzersiz kimliğini temsil eden bir özelliktir.
        public int DuesID { get; set; }
        // TC, ödenmemiş/ödenmiş/ödenmiş aidatı taşıyan kişinin TC kimlik numarasını temsil eden bir özelliktir.
        public string TC { get; set; }
        // NAME, ödenmemiş/ödenmiş aidatı taşıyan kişinin adını temsil eden bir özelliktir.
        public string NAME { get; set; }
        // Surname, ödenmemiş/ödenmiş aidatı taşıyan kişinin soyadını temsil eden bir özelliktir.
        public string Surname { get; set; }
        // DuesMonth, ödenmemiş/ödenmiş aidatın ait olduğu ayı temsil eden bir özelliktir.
        public DateTime DuesMonth { get; set; }
        // PaidDate, aidatın ödendiği tarihi temsil eden bir özelliktir.
        public DateTime PaidDate { get; set; }
        // PayAmount, ödenmemiş/ödenmiş aidatın miktarını temsil eden bir özelliktir. Decimal türü, finansal veriler için uygundur.
        public decimal PayAmount { get; set; }
        // Paid, aidatın ödenip ödenmediğini belirten bir boolean özelliğidir.
        public bool Paid { get; set; }
        // Email, ödenmemiş/ödenmiş aidatı taşıyan kişinin e-posta adresini temsil eden bir özelliktir.
        public string Email { get; set; }
    }
}
