using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Patron
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNr{ get; set; }
        public int PatronID { get; set; }

        public Patron(string name, string address, string phoneNr, int patronId)
        {
            Name = name;
            Address = address;
            PhoneNr = phoneNr;
            PatronID = patronId;
        }
        public Patron()
        {

        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, PhoneNr: {PhoneNr}, PatronID: {PatronID}";
        }
    }
}
