using SalalahDeliveryExpres.Modles.@enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpres.Modles.EXpress
{
    public class Delivery
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public DeliveryStatus Status { get; set; } 
        public string Items { get; set; }
        public DateTime DeliveryDate { get; set; } 
        public DayOfWeek DeleveridDay { get; set; }

        public Delivery(int id, Customer customer, Driver driver, string items, DateTime deliveryDate, DayOfWeek DeleveridDay)
        {
            Id = id;
            Customer = customer;
            Driver = driver;
            Status = DeliveryStatus.Pending; 
            Items = items;
            DeliveryDate = deliveryDate;
            DeleveridDay = deliveryDay;
        }

        public void UpdateStatus(DeliveryStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"✓ تم تحديث حالة الطلب #{Id} إلى: {GetStatus()}");
        }

        public string GetStatus()
        {
            return Status switch
            {
                DeliveryStatus.Pending => "PENDING",
                DeliveryStatus.OnTheWay => "ON THE WAY",
                DeliveryStatus.Delivered => "DELIVERD",
                _ => Status.ToString()
            };
        }

        public override string ToString()
        {
            return $"order #{Id} | customer: {Customer.Name} | " + " driver: {Driver.Name} | " +
                   $"status: {GetStatus()} | items: {Items} | " +
                   $"delivery date: {DeliveryDate.ToShortDateString()} | " +
                   $"preferred day: {deliveryDay}"; 

         }





}
}
}
