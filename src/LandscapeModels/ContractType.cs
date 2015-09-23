using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class ContractType : BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
    }
}
