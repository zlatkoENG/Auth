using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace Dal
{
    class UserRepository : IRepository
    {
        public  int add(Model.Model model)
        {
            User user = (User)model;
            SqlConnection sqlConnection = new SqlConnection();

            return 1;


        }

        public  Model.Model get(int id)
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
