using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Child : Parent
    {
        public Child() : base("이미림")
        {
            Console.WriteLine("자식 생성자 호출");
        }

        public Child(string name) : base(name) 
        {

        }
    }
}
