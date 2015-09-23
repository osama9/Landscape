using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class City : BaseModel
    {
        public Guid Id { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public virtual Country Country { get; set; }
    }
}
