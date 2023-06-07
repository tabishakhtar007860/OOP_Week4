using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4PDTasks
{
    public class ship
    {
        public angle Longitude = new angle() ;
         public angle Latitude= new angle();
        public string ShipNumber;
    
        public ship()
        {

        }
        public ship(int degree , float minutes,char direction,string number, int degree2, float minutes2, char direction2)
        {
            Latitude.degree = degree;
            Latitude.minutes = minutes;
            Latitude.direction = direction;
            this.ShipNumber = number;
            Longitude.degree = degree2;
            Longitude.minutes = minutes2;
            Longitude.direction = direction2;

        }
        public void AddtoList(List<ship> shipList,ship s)
        {
            shipList.Add(s);
        }
        
    
        public ship getPosition(string number,List<ship> s)
        {
           foreach(var i in s)
            {
                Console.WriteLine(i.ShipNumber);
                if(i.ShipNumber == number)
                {
                    return i;
                }
            }
            return null;
        }
        public string check(int degree,int degree2,float minutes,float minutes2,char direction,char direction2, List<ship> ShipList)
        {
            foreach(var i in ShipList )
            {
                if(i.Latitude.degree == degree && i.Latitude.direction == direction && i.Latitude.minutes == minutes && i.Longitude.degree == degree2 && i.Longitude.minutes == minutes2 && i.Longitude.direction == direction2)
                {
                     return i.ShipNumber;
                }
            }
            return null;

        }
        public ship CheckIt(List<ship> ShipList,string number)
        {
            foreach (var s in ShipList)
            {
               if (s.ShipNumber == number)
                {
                    return s;
                }

            }
            return null;
        }
       // public ship CheckItNow( )
       
    }
}
