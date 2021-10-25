using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22ndOctober
{
    class Q7
    {
        public string[] type = new string[2] ;
        public string[] capacity = new string[3];
        public string dimension = "";
        public void buildingConstructor(string[]type, string[]cap, string dim)
        {
            this.type = type;
            cap = capacity;
            dim = dimension;
        }
        public void showData()
        {
            Console.WriteLine("Type of house:" + type + "\n capacity:" + capacity + "\nDimensions:" + dimension);
        }
        static void Main(string[] args)
        {
            Q7 building = new Q7();
            building.buildingConstructor(new string[] { "flat", "villa" }, new string[] { "2BHK", "3BHK", "$BHK" }, "23 X 30 X4 0");
            building.showData();
        }
    }
}
