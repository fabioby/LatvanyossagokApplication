using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class City
    {
        private int id;
        private string name;
        private int population;

        public City(int id, string name, int population)
        {
            this.id = id;
            this.name = name;
            this.population = population;
        }

        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
