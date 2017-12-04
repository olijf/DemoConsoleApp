using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    class Persoon
    {
        private Persoon blah;

        public Persoon myBlah
        {
            get { return blah; }
            set { blah = value; }
        }

        public Persoon() => blah = new Persoon();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
