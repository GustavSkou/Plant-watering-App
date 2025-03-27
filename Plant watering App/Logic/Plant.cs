using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Plant
    {
        private int id;
        private string name;
        private int size;

        public Plant(int id, string name, int size)
        {
            this.id = id;
            this.name = name;
            this.size = size;
        }
    }
}
