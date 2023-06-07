using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4PDTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string time = Console.ReadLine();
             int count = 0;
             if (time.Length == 7)
             {
                 for (int x = 48; x < 50; x++)
                 {
                     if (time[0] == x)   //to check 1st digit of time is 0 ,1 or 2 
                     {
                         count++;
                         Console.WriteLine("time[0] ");
                         Console.WriteLine("count" + count);

                     }
                 }
                 for (int y = 1; y < 5; y = y + 3)   // only  checks first and fourth index of time
                 {
                     for (int x = 48; x < 58; x++)   //to check  digit is from 0 to 9
                     {
                         if (time[y] == x)
                         {
                             count++;
                             Console.WriteLine("Time[x" + x + " " + y + "y] ");
                             Console.WriteLine("count" + count);

                         }
                     }
                 }
                 if (time[2] == 58)  //to check second index of time
                 {
                     count++;       //58 is ascii value semi colon :
                     Console.WriteLine("time[2]");
                     Console.WriteLine("count" + count);

                 }
                 for (int x = 48; x < 54; x++)
                 {
                     if (time[3] == x)
                     {
                         count++;      //to check 3rd index is 0 to 5 
                         Console.WriteLine("time[3]");
                         Console.WriteLine("count" + count);

                     }
                 }
                 if (time[5] == 'P' || time[5] == 'A')
                 {
                     count++;
                     Console.WriteLine("time[5]");
                     Console.WriteLine("count" + count);


                 }
                 if (time[6] == 'M')
                 {
                     count++;
                     Console.WriteLine("time[6]");
                     Console.WriteLine("count" + count);


                 }
             }
             Console.WriteLine("count" + count);
             if (count == 7)
             {
                 Console.WriteLine("Welcome");
                 Console.WriteLine("count" + count);

             }*/
            //  Console.Read();

            ship shipObj = new ship();
            List<ship> ShipList = new List<ship>();
            Console.Clear();
            int options;
            do
            {

                options = menu();
                if (options == 1)
                {
                    addShip(ShipList,shipObj);
                }
                else if (options == 2)
                {
                    Console.WriteLine("Enter Ship Serial Number to find its position:");
                    string number = Console.ReadLine();

                    ship g = new ship();
                    if (g.CheckIt(ShipList, number) != null)
                    {
                        printShipLocation(ShipList, number);

                    }
                    else
                    {
                        Console.WriteLine("Not exist");
                    }


                    /*foreach(ship s in ShipList)
                    {
                        Console.WriteLine(s.ShipNumber);
                        if (s.ShipNumber == number)
                        {
                            //Console.Write("found");
                            Console.WriteLine("Latitude"+s.Latitude.degree+ "\u00b0" + s.Latitude.minutes+"`"+s.Latitude.direction);
                            Console.WriteLine("Longitude"+s.Longitude.degree+ "\u00b0" + s.Longitude.minutes+"`"+s.Longitude.direction);
                            
                        }

                    }*/


                }
                else if (options == 3)
                {
                    Console.WriteLine("Enter Ship Latitude");
                    Console.WriteLine("Enter Latitude Degree");
                    int degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Latitude Minutes");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter Latitude Direction");
                    char direction = char.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Ship Latitude");
                    Console.WriteLine("Enter Latitude Degree");
                    int degree2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude Minutes");
                    float minutes2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter Latitude Direction");
                    char direction2 = char.Parse(Console.ReadLine());
                    ship obj = new ship();
                    string check = obj.check(degree, degree2, minutes, minutes2, direction, direction2, ShipList);
                    if (check != null)
                    {
                        Console.WriteLine("ship Serial Number is" + check);
                    }
                    else
                    {
                        Console.WriteLine("Not Exist");
                    }


                }
                else if (options == 4)
                {
                    UpdateShipPosition(ShipList,shipObj);



                }
            }
            while (options != 5);


        }
        static int menu()
        {
            int options;
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("Exist");
            options = int.Parse(Console.ReadLine());
            return options;
        }
        static void addShip(List<ship> ShipList,ship s)
        {


            Console.WriteLine("Enter Ship number");
            string number = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude");
            Console.WriteLine("Enter Latitude Degree");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Latitude Minutes");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Latitude Direction");
            char direction = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ship Latitude");
            Console.WriteLine("Enter Latitude Degree");
            int degree2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude Minutes");
            float minutes2 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Latitude Direction");
            char direction2 = char.Parse(Console.ReadLine());
            s = new ship(degree, minutes, direction, number, degree2, minutes2, direction2);
            s.AddtoList(ShipList, s);



        }
        public static void printShipLocation(List<ship> shipList, string number)
        {
            foreach (var i in shipList)
            {
                if (i.ShipNumber == number)
                {
                    Console.WriteLine("Latitude of Ship is" + i.Latitude.degree + "\u00b0" + i.Latitude.minutes + "`" + i.Latitude.direction);
                    Console.WriteLine("Longitude of ship :" + i.Longitude.degree + "\u00b0" + i.Longitude.minutes + "`" + i.Longitude.direction);
                }
            }


        }
        public static void UpdateShipPosition(List<ship> shipList,ship shipObj) 
        {
            Console.Write("Enter Ship Serial  number to update it>>");
            string number = Console.ReadLine();
            int count = 0;
            foreach (var s in shipList)
            {
                if (s.ShipNumber == number)
                {
                Console.WriteLine("Enter Ship Latitude");
                Console.WriteLine("Enter Latitude Degree");
               s.Latitude.degree = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Latitude Minutes");
                s.Latitude.minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("enter Latitude Direction");
                s.Latitude.direction = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter Ship Latitude");
                Console.WriteLine("Enter Latitude Degree");
                s.Longitude.degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Latitude Minutes");
                s.Longitude.minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("enter Latitude Direction");
                s.Longitude.direction = char.Parse(Console.ReadLine());
                    count = 1;
                  
                }

            }
        if(count == 1)
            {
                Console.WriteLine("Updated Succesfully");
            }
            else
            {
                Console.WriteLine("Not exist");
            }

        


        }


    }
}
