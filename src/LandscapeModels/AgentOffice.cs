using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class AgentOffice :BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? PinNumber { get; set; }
        [MaxLength(10)]
        public string PhoneNumberOne { get; set; }
        [MaxLength(10)]
        public string PhoneNumberTwo { get; set; }
        [MaxLength(10)]
        public string  MobileNumber { get; set; }

        public int? LandlineNumber { get; set; }

        public virtual City City { get; set; }
    }
}
