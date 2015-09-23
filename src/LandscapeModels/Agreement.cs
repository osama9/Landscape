using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LandscapeModels
{
    public class Agreement : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime AgreementDate { get; set; }
        public DateTime AgreementStartDate { get; set; }
        public DateTime AgreementEndDate { get; set; }
        public int? Deposit { get; set; }
        public PaymentSchedule PaymentSchedule { get; set; }
        public int RentAmount { get; set; }
        public int PaidAmount { get; set; }
        public string  AgreementWith { get; set; }
        public Agent Agent { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual Landlord Landlord { get; set; }
        public virtual ICollection<ContractPayment> ContractPayments { get; set; }
    }
}
