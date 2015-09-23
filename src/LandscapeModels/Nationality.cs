using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class Nationality : BaseModel
    {
        public int Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
    }
}
