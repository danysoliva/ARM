﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;
using System.Data;

namespace ARM.Classes
{
    class Security
    {
        public bool Validate_Account(string domain, string userName, string password)
        {
            using (PrincipalContext PriCon = new PrincipalContext(ContextType.Domain, domain))
            {
                return PriCon.ValidateCredentials(userName, password);
            }
        }
    }
}
