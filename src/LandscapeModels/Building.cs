using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class Building :BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public String RegisteryNumber { get; set; }
        public String Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int NumberOfFloors { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<BuildingDetails> BuildingDetails { get; set; }
        public virtual ICollection<House> Houses { get; set; }
        public virtual ICollection<Landlord> Landlords { get; set; }
    }
}
