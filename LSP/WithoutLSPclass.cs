using System;

namespace LSP
{
    public class WithoutLSPclass
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : WithoutLSPclass
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}

