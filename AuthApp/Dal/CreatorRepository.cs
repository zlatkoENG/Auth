using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public  class CreatorRepository : Repository
    {
        public override IRepository FactoryMethod(string type)
        {
           switch (type) {
                case "user": return new UserRepository();
                case "product":return new ProductRepository();
            }
            return null;
            
        }
    }
}
