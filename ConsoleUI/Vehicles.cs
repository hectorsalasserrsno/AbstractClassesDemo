using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
   
    
    internal abstract class Vehicles
    {
        public string Year { get; set; } = "something Generic";
        public string Make { get; set; } = "something Generic";
        public string Model { get; set; } = "something Generic";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive Method");
        }
        
        

        
    }   

 }

