using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpres.Modles.EXpress
{
    public class person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }


        public person(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public string UpdatePhone(string newPhone)
        {
            Phone = newPhone;
            Console.WriteLine($"Phone {Name} updated ");
        }

        public virtual string ToString()
        {
            return $"ID: {Id} | الاسم: {Name} | الهاتف: {Phone}";
        }
    



    }
}
