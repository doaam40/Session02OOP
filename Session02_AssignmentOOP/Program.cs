namespace Session02_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // a) struct: value type, stored in stack, store small data, faster than class in retreving data, copy objects copies the
            // values not references, not support inheritance, allows 3 access modifiers: (public, internal, private), the compiler generates
            // the parameterless constructor even we generate a userdefined constructor or not, not support null unless we make it 
            // nullable, the keyword new is constructor choise, can not control object lifetime.
            // class: reference type, stored in heap and address in stack (not usually), store large data, slower than struct in retreving
            // data, copy objects copies the reference not values, support inheritance, allows all access modifiers, the compiler does not
            // generate the parameterless constructor if we generate a userdefined constructor, support null, keyword new is constructor
            // choice and create object in heap, adds the address in stack, initialize values to the data in the object, controls object
            // lifetime.

            // b) because it controls object lifetime, store large data, support inheritance.
            #endregion

            #region Q2
            // a) the parent class is Shipment
            // b) the child class is ExpressShipment
            // c) trackingcode property is inherited
            // d) to decrese code, easily test, inhance and maintane code

            #endregion
            #endregion

            #region Part 02 : Practical
            #region Q1
            bool flag;
            string trackingCode;
            string description;
            double weight;
            decimal deliveryFee;
            string city;
            string street;
            int buildingNumber;
            bool shipmentAdded;

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i + 1} Data");
                Console.Write("Tracking Code: ");
                trackingCode = Console.ReadLine();
                Console.Write("Description: ");
                description = Console.ReadLine();
                do
                {
                    Console.Write("Weight: ");
                    flag = double.TryParse(Console.ReadLine(), out weight);
                } while (!flag);

                do
                {
                    Console.Write("Delivery Fee: ");
                    flag = decimal.TryParse(Console.ReadLine(), out deliveryFee);
                } while (!flag);

                Console.Write("City: ");
                city = Console.ReadLine();
                Console.Write("Street: ");
                street = Console.ReadLine();
                do
                {
                    Console.Write("Building Number: ");
                    flag = int.TryParse(Console.ReadLine(), out buildingNumber);
                } while (!flag);

                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(city, street, buildingNumber));
                shipmentAdded = deliveryCenter.AddShipment(shipment, i);
                string printStatus = shipmentAdded ? "The shipment was added successfully" : "The delivery center is full";
                Console.WriteLine(printStatus);
            }

            Console.WriteLine("All Shipments");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(deliveryCenter[i]);
            }

            Console.Write("Enter a tracking code to search: ");
            Shipment? ship = deliveryCenter[Console.ReadLine()];
            string printShipment = ship is not null ? $"Shipment found: {ship}" : "Shipment not found";
            Console.WriteLine(printShipment);

            DeliveryAddress address01 = new DeliveryAddress("Cairo", "Tahrir", 15);
            DeliveryAddress address02 = address01;
            address02.Street = "Makram Ebeid";
            address02.BuildingNumber = 20;
            Console.WriteLine($"Original Address: {address01.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {address02.GetFullAddress()}");
            #endregion

            #region Q2

            #endregion

            #region Q3
            
            #endregion
            #endregion
        }
    }
}
