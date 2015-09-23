using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class Landlord : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [MaxLength(10)]
        public string MobileNumber1 { get; set; }

        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }

        public virtual ICollection<House> Houses { get; set; }
        public virtual ICollection<Agreement> HouseAgreements { get; set; }


    }
}
