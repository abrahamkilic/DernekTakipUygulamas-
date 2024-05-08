using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ELDebt
    {

        public int DeptID { get; set; }
        // DeptID, borç varlığının benzersiz kimliğini temsil eden bir özelliktir.
        public string TC { get; set; }
        // TC, borç sahibinin TC kimlik numarasını temsil eden bir özelliktir.
        public string Name { get; set; }
        // Name, borç sahibinin adını temsil eden bir özelliktir.
        public string Surname { get; set; }
        // Surname, borç sahibinin soyadını temsil eden bir özelliktir.
        public string email { get; set; }
        // email, borç sahibinin e-posta adresini temsil eden bir özelliktir.
        public Decimal DeptAmount { get; set; }
        // DeptAmount, borç miktarını temsil eden bir özelliktir. Decimal türü, finansal veriler için daha uygundur.
    }
}
