using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class Agent : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Email { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }

        public string Address { get; set; }

        [MaxLength(10)]
        public string MobileNumber { get; set; }

        public ICollection<AgentOffice> Offices { get; set; }
        public virtual ICollection<Agreement> HouseAgreements { get; set; }


    }
}
