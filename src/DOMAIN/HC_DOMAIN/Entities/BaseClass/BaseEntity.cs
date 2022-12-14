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
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? DeletedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedById { get; set; }
        public Status Status { get; set; }
    }
}
