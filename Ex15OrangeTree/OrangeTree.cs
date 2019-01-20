using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15OrangeTree
{
    public class OrangeTree
    {
        private int age;
        private int height;

        public OrangeTree(int age, int height)
        {
            this.age = age;
            this.height = height;
        }

        public int Age { get; set; }
        public int Height { get; set; }
        public bool TreeAlive { get; set; }
        public int NumOranges { get; set; }
        public int OrangesEaten { get; set; }

        public void OneYearPasses()
        {
            throw new NotImplementedException();
        }

        public void EatOrange(int v)
        {
            throw new NotImplementedException();
        }
    }
}
