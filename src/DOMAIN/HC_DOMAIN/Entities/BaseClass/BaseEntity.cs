using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.BaseClass
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }

        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
    }
}
