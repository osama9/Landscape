using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class Tenant : BaseModel
    {

//Created_Date

//Created_By

//Updation_Date

//Updation_by

//Last_Update_Login
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDScanImage { get; set; }
        public Nationality Nationality { get; set; }
        public string SponsorFirstName { get; set; }
        public string SponsorLastName { get; set; }
        [MaxLength(10)]
        public string MobileNumber { get; set; }
        public virtual ICollection<Agreement> HouseAgreements { get; set; }


        
    }
}
