using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.Interface
{
    public interface IBaseEntity
    {
        public Status Status { get; set; }
        // When data added.
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string CreatorUserName { get; set; }
        // When data updated.
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string UpdaterUserName { get; set; }
        // When data deleted.
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }
        public string DeleterUserName { get; set; }
        
    }
}
