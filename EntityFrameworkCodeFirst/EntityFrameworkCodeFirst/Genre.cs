using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class Genre
    {
        public Genre()
        {
            Videos = new List<Video>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
    }
}
