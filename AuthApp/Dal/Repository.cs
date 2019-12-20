using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal
{
    public abstract class Repository
    {
        public abstract IRepository FactoryMethod(string type);
    }
}
