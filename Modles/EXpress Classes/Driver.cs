using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpres.Modles.EXpress
{
    public class Driver : person
    {
        public string Vehicle { get; set; }

        public Driver(int id, string name, string phone, string vehicle) : base(id, name, phone)
        {
            Vehicle = vehicle;
        }

        public override string ToString()
        {
            return $"Driver: {Name} | Phone: {Phone} | Vehicle: {Vehicle}";
        }
    
    
    }
}

