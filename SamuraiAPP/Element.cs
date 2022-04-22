using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class Element
    {
        public int Id { get; set; }
        public string nmelement { get; set; }
        public string Swordnm { get; set; }

        public List<Samurai> Samurais { get; set; } = new List<Samurai>();
    }
}
