using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class User
    {
        private string name;
        private string email;
        private string phone;
        public string this[string propName]
        {
            get
            {
                switch (propName)
                {
                    case "name":
                        return name;
                    case "email":
                        return email;
                    case "phone":
                        return phone;
                    default:
                        return null;
                }
            }
            set
            {
                switch (propName)
                {
                    case "name":
                        {
                            name = value;
                            break;
                        }
                    case "email":
                        {
                            email = value;
                            break;
                        }
                    case "phone":
                        {
                            phone = value;
                            break;
                        }
                }
            }
        }
    }
}