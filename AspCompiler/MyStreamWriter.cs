using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCompiler
{
    public class MyStreamWriter : System.IO.StreamWriter
    {
        public MyStreamWriter(string file) : base(file)
        {

        }
        public void say(string s)
        {
            base.Write(s);
        }

        public void say(int s)
        {
            base.Write(s);
        }

        public void say(double s)
        {
            base.Write(s);
        }

        public void say(object s)
        {
            base.Write(s);
        }
    }
}
