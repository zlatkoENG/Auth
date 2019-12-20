using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

namespace AuthApp
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { IRepository user_repository= new CreatorRepository().FactoryMethod("product");
            Label1.Text = user_repository.add(new User()).ToString();


        }
    }
}