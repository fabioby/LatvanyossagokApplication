using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Shew
    {
        private int id;
        private string name;
        private string description;
        private int price;
        private int city_id;
        
        public Shew(int id, string name, string description, int price, int city_id)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.city_id = city_id;
        }
    }
}
