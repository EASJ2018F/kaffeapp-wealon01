using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite: Kaffe
    {

        public FlatWhite()
        {
            Console.WriteLine("FlatWhite");
        }


        public override int Pris()
        {


            return 45;
        }

        public int MiMælk()
        {
            return 160;
        }


        public override string Styrke()
        {
            return "Mild";
        }



    }
}
