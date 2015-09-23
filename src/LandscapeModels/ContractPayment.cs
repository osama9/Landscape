using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeModels
{
    public class ContractPayment : BaseModel
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public ContractType ContractType { get; set; }
    }
}
