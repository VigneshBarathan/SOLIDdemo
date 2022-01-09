using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_1
{
    public abstract class WithLSPClass
    {
        public abstract string GetColor();
    }

    public class Apple : WithLSPClass
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : WithLSPClass
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
