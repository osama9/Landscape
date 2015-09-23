using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class BuildingDetails : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Description { get; set; }
        public string SpaceDetail { get; set; }

        public virtual Building Building { get; set; }
        public virtual BuildingAttributesMaster BuildingAttributesMaster { get; set; }
        
    }
}
