using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal
{
   public  interface IRepository
    {
         int add(Model.Model model);
         Model.Model get(int id);
         int remove(int id);
        List<Model.Model> gets();


    }
}
