using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ABB
    {

        public ABB Menor { get; private set; }
        public ABB Mayor { get; private set; }
        
        public int value { get; private set; }

        public ABB(int value, ABB lesserNode = null, ABB greaterNode = null)
        {
            this.value = value;
            this.Menor = lesserNode;
            this.Mayor = greaterNode;
        }


    }
}
