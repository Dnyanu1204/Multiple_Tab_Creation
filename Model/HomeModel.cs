using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Tab_Creation.Model
{
    public class HomeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Fullname { get; set; }


        public HomeModel(string id, string name, string Surename)
        {
            this.Id = id;
            this.Name = name;
            this.Surename = Surename;
            this.Fullname = name+" "+Surename;
            
        }
    }
}
