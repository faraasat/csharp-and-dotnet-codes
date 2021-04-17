using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Polymorphism
{
    // IS-A
    class M3 : BMW
    {

        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }

        public void Repair()
        {
            base.Repair();
        }

    }
}
