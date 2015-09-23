using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class HouseDetails : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Description { get; set; }
        public string SpaceDetails { get; set; }
        public virtual HouseAttributesMaster HouseAttributesMaster  { get; set; }
        public virtual House House { get; set; }

        
    }
}
