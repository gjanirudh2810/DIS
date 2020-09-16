using System;

namespace vehicle
{
    class Vehicle
    {
        public float registration_number = 1234;
        public string color = "white";


        public void aboutvehicle()
        {
            Console.WriteLine("Parent Class");
            Console.WriteLine("Registration Number : " + registration_number);
            Console.WriteLine("Color : " + color);

        }
    }
    class Car : Vehicle
    {
        public string make ;
        public string type;
        public int Modelyear;
        public int number_of_doors;


        public void getcar()
        {
            Console.WriteLine("Enter Car Details :");
            Console.WriteLine("Enter make :");
           make = Console.ReadLine();

            Console.WriteLine("Enter type :");
            type = Console.ReadLine();

            Console.WriteLine("Enter Modelyear :");
             Modelyear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter numberofdoors :");
             number_of_doors = Convert.ToInt32(Console.ReadLine());
           
        }
       
    }
    class Bike : Vehicle
    {
        public string make; 
        public string type ;
        public int number_of_gears;
        public void getbike()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Enter Bike Details :");

            Console.WriteLine("Enter make :");
             make = Console.ReadLine();
            
            Console.WriteLine("Enter type :");
            type = Console.ReadLine();

            Console.WriteLine("Enter numberofgears :");
             number_of_gears = Convert.ToInt32(Console.ReadLine());

            
        }
      
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Bike mybike = new Bike();
            
            myCar.getcar();
            mybike.getbike();

            Console.WriteLine(" ");
            myCar.aboutvehicle();
          
            Console.WriteLine(" ");
            Console.WriteLine("PRINTING CAR DETAILS");
            Console.WriteLine("Make :" + myCar.make);
            Console.WriteLine("Type :" + myCar.type);
            Console.WriteLine("Year :" + myCar.Modelyear);
            Console.WriteLine("Doors :" + myCar.number_of_doors);

            Console.WriteLine(" ");
            Console.WriteLine("PRINTING CAR DETAILS");
            Console.WriteLine("Make :" + mybike.make);
            Console.WriteLine("Type :" + mybike.type);
            Console.WriteLine("Gears :" + mybike.number_of_gears);





        }
    }
}

