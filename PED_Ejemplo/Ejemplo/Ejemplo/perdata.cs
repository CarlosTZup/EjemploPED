using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Perdata
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public Perdata(int id, string name, string age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;

        }
    }
}
