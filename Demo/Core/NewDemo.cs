using JobPortalDatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core
{
    public class NewDemo
    {
        public async Task<string> Add(Model.Job value) 
        {
            using (JobPortalDatabaseDataContext context = new JobPortalDatabaseDataContext()) 
            {
                Role role = new Role();
                role.RoleName = value.Role;
                context.Roles.InsertOnSubmit(role);
                context.SubmitChanges();
                return "role added successfully";
            }
        }
    }
}
