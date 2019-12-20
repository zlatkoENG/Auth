using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class User : Model
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int retryAttemps { get; set; }
        public bool isLocked { get; set; }
        public DateTime lockedDateTime { get; set; }

        public User(string userName, string password, string email, int retryAttemps, bool isLocked, DateTime lockedDateTime)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.retryAttemps = retryAttemps;
            this.isLocked = isLocked;
            this.lockedDateTime = lockedDateTime;
        }

        public User()
        {
        }
    }
}
