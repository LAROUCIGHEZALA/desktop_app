using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Promo
    {
        public Promo( string name)
        {
            
            Name= name;
        }

       
        public String Name{ get; private set; }
    }
}
