using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class HouseAttributesMaster :BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<HouseDetails> HouseDetails { get; set; }

    }
}
