using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Z
    {
        public virtual void M() { Console.WriteLine("Z,M"); }
        public void P() { Console.WriteLine("Z,P"); }
    }
    public class Y:Z
    {
        public override void M(){Console.WriteLine("Y,M");}
        public void P() { Console.WriteLine("Y,P"); }
    }
    public class X:Y
    {
        public void M() { Console.WriteLine("X,M"); }
    }
    public class W:X
    {
        public void M() { Console.WriteLine("W,M"); }
    }
}
