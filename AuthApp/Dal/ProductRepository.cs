using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal
{
    class ProductRepository : IRepository
    {
        public int add(Model.Model model)
        {
            return 7;
        }

        public Model.Model get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Model.Model> gets()
        {
            throw new NotImplementedException();
        }

        public int remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
