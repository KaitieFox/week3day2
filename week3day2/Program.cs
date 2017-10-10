using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boatyMcBoatface = new Boat(3, "Boaty McBoatface", 18.6); //create the new boat instance. for another needs a new variable.
            boatyMcBoatface.Move();
            boatyMcBoatface.BoatInfo();

            Boat boatSirAttenborough = new Boat(14, "RRS Sir David Attenborough", 30.8);
            boatSirAttenborough.BoatInfo();


              









        }
    }
}
