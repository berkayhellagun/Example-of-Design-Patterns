using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biseler
{
    class EntityManager
    {
        IEntityService _entityService;

        public EntityManager(IEntityService entityService)
        {
            _entityService = entityService;
        }

        public void Serialize()
        {
            _entityService.Serialize();
        }
    }
}
