using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class House :BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string HouseNo { get; set; }
        public byte FloorNo { get; set; }
        public string FlatRegisteryNumber { get; set; }
        public DateTime FlatRegisteryDate { get; set; }
        public string FlatElectricityNumber { get; set; }
        public byte NumberOfRooms { get; set; }
        public byte NumberOfToilets { get; set; }
        public int BasePrice { get; set; }

        public HouseType HouseType { get; set; }

        public virtual Landlord Landlord{ get; set; }

        public virtual ICollection<HouseDetails> HouseDetails { get; set; }

        public virtual ICollection<Agreement> HouseAgreements { get; set; }

    }
}
