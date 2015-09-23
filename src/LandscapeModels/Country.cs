using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class Country : BaseModel
    {
        public int Id { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
