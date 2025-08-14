using Assignment__3__Grup_calismasi___08._08_.Concretes;
using Assignment__3__Grup_calismasi___08._08_.Enums;

namespace Assignment__3__Grup_calismasi___08._08_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle v1 = new Car() { Brand = "Opel", DailyPrice = 300, FuelType = FuelType.Diesel, Model = "Corsa" };
            Vehicle v2 = new ElectricCar()
                { Brand = "Tesla", DailyPrice = 1200, FuelType = FuelType.Eelctric, Model = "T1" };
            Vehicle v3 = new Minibus()
                { Brand = "Minibus1", DailyPrice = 1000, FuelType = FuelType.Fueloil, Model = "M1" };
            Vehicle v4 = new SUV()
                { Brand = "Nissan", DailyPrice = 1100, FuelType = FuelType.Fueloil, Model = "Qasqai" };
            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(v3);
            vehicles.Add(v4);

            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer() { Name = "Burak can", Surname = "Koca", Email = "bkoca@mail.com" };
            Customer c2 = new Customer() { Name = "Melih", Surname = "Koca", Email = "melih@mail.com" };
            Customer c3 = new Customer() { Name = "Nurettin", Surname = "Koca", Email = "nurettin@mail.com" };
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Welcome to vehicle rent app");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("1- Select vehicle to rent");
                    Console.WriteLine("2- Add customer");
                    Console.WriteLine("3 - Add Vehicle");
                    Console.WriteLine("4- List Vehicles");
                    Console.WriteLine("5- List Customers");
                    Console.WriteLine("6- Exit");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Selection : ");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1": // Select vehicle
                            Console.WriteLine("Vehicles Available : ");
                            int i = 0;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            foreach (var vehicle in vehicles)
                            {
                                Console.WriteLine($"{i} - {vehicle.Brand} - {vehicle.Model} - {vehicle.DailyPrice}");
                                i++;
                            }

                            Console.WriteLine("Select a vehicle :");
                            int index = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Select customer from the list : ");
                            int j = 0;
                            foreach (var customer in customers)
                            {
                                Console.WriteLine($"{j} -> {customer.Name} - {customer.Surname} - {customer.Email}");
                                j++;
                            }

                            int index2 = int.Parse(Console.ReadLine());
                            Customer selectedCustomer = customers[index2];
                            Console.WriteLine("How many days would you like to rent the vehicle ?");
                            int days = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Rent is created !");
                            RentalProcesses rent = new RentalProcesses() { Vehicle = vehicles[index],Customer = selectedCustomer,Days = days,DailyPrice = vehicles[index].DailyPrice, TotalPrice = vehicles[index].DailyPrice * days };
                            Console.WriteLine(rent.GetRentInfo());
                            break;
                        case "2"://Add customer
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("== Customers in database ==");
                            int k = 0;
                            foreach (var customer in customers)
                            {
                                Console.WriteLine($"{k} -> {customer.Name} - {customer.Surname} - {customer.Email}");
                                k++;
                            }

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Add new customer..");
                            Console.WriteLine("New customer's name : ");
                            string name = Console.ReadLine();
                            Console.WriteLine("New customer's surname : ");
                            string surname = Console.ReadLine();
                            Console.WriteLine("New customer's email : ");
                            string email = Console.ReadLine();
                            Customer c = new Customer() { Email = email, Name = name, Surname = surname };
                            customers.Add(c);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Customer - {c.Name} - {c.Surname} - {c.Email} is added to database !");

                            break;
                        case "3"://Add vehicle
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Which type of vehicle do you like to add ?(0-Car,1-ElectricCar,2-Minibus,3-SUV)");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 0:
                                    //Add Car
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Adding car..");
                                    Console.WriteLine("Brand name : ");
                                    string brand = Console.ReadLine();
                                    Console.WriteLine("Model name : ");
                                    string model = Console.ReadLine();
                                    Console.WriteLine("Fuel type (0-Electric,1-Fueloil,2-Diesel,3-Gas)");
                                    int choice2 = int.Parse(Console.ReadLine());

                                    Vehicle car = new Car()
                                        { Brand = brand, Model = model, FuelType = (FuelType)choice2 };
                                    vehicles.Add(car);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Vehicle : {car.Brand} - {car.Model} - {car.FuelType} - {car.DailyPrice} is added to database...");
                                    break;
                                case 1://Add Electriccar
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Adding electric car..");
                                    Console.WriteLine("Brand name : ");
                                    string brand1 = Console.ReadLine();
                                    Console.WriteLine("Model name : ");
                                    string model1 = Console.ReadLine();

                                    Vehicle electricCar = new ElectricCar() {Brand = brand1,Model = model1,FuelType = FuelType.Eelctric};
                                    vehicles.Add(electricCar);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Electric Car : {electricCar.Brand} - {electricCar.Model} - {electricCar.FuelType} - {electricCar.DailyPrice} is added to database...");

                                    break;
                                case 2://Add minibus
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Adding minibus..");
                                    Console.WriteLine("Brand name : ");
                                    string brand2 = Console.ReadLine();
                                    Console.WriteLine("Model name : ");
                                    string model2 = Console.ReadLine();
                                    Console.WriteLine("Fuel type (0-Electric,1-Fueloil,2-Diesel,3-Gas)");
                                    int choice3 = int.Parse(Console.ReadLine());

                                    Vehicle minibus = new Minibus() {Brand = brand2,Model = model2,FuelType = (FuelType)choice3};
                                    vehicles.Add(minibus);
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine($"Minibus : {minibus.Brand} - {minibus.Model} - {minibus.FuelType} - {minibus.DailyPrice} is added to database...");

                                    break;
                                case 3://Adding SUV
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Adding SUV..");
                                    Console.WriteLine("Brand name : ");
                                    string brand3 = Console.ReadLine();
                                    Console.WriteLine("Model name : ");
                                    string model3 = Console.ReadLine();
                                    Console.WriteLine("Fuel type (0-Electric,1-Fueloil,2-Diesel,3-Gas)");
                                    int choice4 = int.Parse(Console.ReadLine());

                                    Vehicle suv = new SUV() {Brand = brand3,Model = model3,FuelType = (FuelType)choice4};
                                    vehicles.Add(suv);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"SUV : {suv.Brand} - {suv.Model} - {suv.FuelType} - {suv.DailyPrice} is added to database...");
                                    break;
                   
                            }
                            break;
                        case "4"://List vehicles
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vehicles on database.....");
                            int a = 0;
                            foreach (var vehicle in vehicles)
                            {
                                Console.WriteLine($"{a} - {vehicle.Brand} - {vehicle.Model} - {vehicle.FuelType} - {vehicle.DailyPrice}");
                                a++;
                            }
                            break;
                        case "5"://List customers
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            int b = 0;
                            foreach (var customer in customers)
                            {
                                Console.WriteLine($"{b} - {customer.Name} - {customer.Surname} - {customer.Email}");
                                b++;
                            }
                            break;
                        case "6"://Exit
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Exiting the app...");
                            return;
                        default:
                            Console.WriteLine("Wrong input !!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }
        }
    }
}
