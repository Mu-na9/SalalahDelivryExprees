using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpres.Modles.EXpress
{
    public class Customer : person
    {
        public string address { get; set; } 

        public Customer(int id, string name, string phone, string address) : base(id, name, phone)
        {
            this.address = address;
        }


        public override string ToString()
        {
            return $"Customer : {Name} | Phone: {Phone} | adress : {address}";
        }


    }
}
