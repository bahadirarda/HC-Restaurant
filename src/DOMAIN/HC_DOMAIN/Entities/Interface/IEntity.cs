using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.Interface
{
    public interface IEntity<TEntity>
    {
        TEntity ID { get; set; } // Full control on ID
    }
}
