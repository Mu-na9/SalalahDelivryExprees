using SalalahDeliveryExpres.Modles.@enum;

namespace SalalahDeliveryExpres
{
    internal class Program
    {
        static void Main()
        { 

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("🚚 نظام إدارة التوصيل - صلالة");
            Console.WriteLine(new string('=', 60));

            // إضافة السائقين
            var driver1 = system.AddDriver("أحمد محمد", "92345678", "تويوتا هايلكس");
            var driver2 = system.AddDriver("سالم علي", "91234567", "نيسان");

            // إضافة العملاء
            var customer1 = system.AddCustomer("محمد سعيد", "99887766", "صلالة - الحافة");
            var customer2 = system.AddCustomer("فاطمة أحمد", "98776655", "صلالة - الدهاريز");
            var customer3 = system.AddCustomer("خالد سالم", "97665544", "صلالة - عوقد");

            // إضافة طلبات التوصيل باستخدام DateTime و Enum
            var delivery1 = system.AddDelivery(1, 1, "طرود بريدية (5 قطع)",
                new DateTime(2025, 10, 26), DayOfWeek.Sunday);

            var delivery2 = system.AddDelivery(2, 2, "أثاث منزلي",
                new DateTime(2025, 10, 27), DayOfWeek.Monday);

            var delivery3 = system.AddDelivery(3, 1, "أجهزة إلكترونية",
                new DateTime(2025, 10, 28), DayOfWeek.Tuesday);

            var delivery4 = system.AddDelivery(1, 2, "مواد غذائية",
                new DateTime(2025, 10, 26), DayOfWeek.Sunday);

            // تحديث حالة الطلبات باستخدام Enum
            Console.WriteLine("\n--- تحديث الحالات ---");
            delivery1.UpdateStatus(DeliveryStatus.OnTheWay);
            delivery2.UpdateStatus(DeliveryStatus.Delivered);
            delivery3.UpdateStatus(DeliveryStatus.Pending);

            // اختبار الوراثة
            Console.WriteLine("\n--- اختبار الوراثة ---");
            driver1.UpdatePhone("92999999");
            customer1.UpdateAddress("صلالة - المعمورة");

            // عرض جميع البيانات
            system.DisplayStatistics();
            system.DisplayAllDrivers();
            system.DisplayAllCustomers();
            system.DisplayAllDeliveries();

            // عرض طلبات سائق معين
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine($"📦 طلبات السائق: {driver1.Name}");
            Console.WriteLine(new string('=', 60));
            var driver1Deliveries = system.GetDriverDeliveries(driver1.Id);
            foreach (var d in driver1Deliveries)
            {
                Console.WriteLine($"  {d}");
            }

            // عرض طلبات حسب اليوم
            system.DisplayDeliveriesByDay(DayOfWeek.Sunday);

            // عرض طلبات حسب الحالة
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("📦 الطلبات قيد الانتظار");
            Console.WriteLine(new string('=', 60));
            var pendingDeliveries = system.GetDeliveriesByStatus(DeliveryStatus.Pending);
            foreach (var d in pendingDeliveries)
            {
                Console.WriteLine($"  {d}");
            }

            Console.WriteLine("\n--- اضغط أي مفتاح للخروج ---");
            Console.ReadKey();
        }
    }
}
