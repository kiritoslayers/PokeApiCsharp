using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Pokemon
{
    public class Root
    {
        public int base_experience { get; set; }
        public int height { get; set; }
        //public List<object> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        //public List<object> past_types { get; set; }
        //public List<Type> types { get; set; }
        public int weight { get; set; }
    }
}
