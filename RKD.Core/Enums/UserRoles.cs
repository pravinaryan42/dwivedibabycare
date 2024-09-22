using System.ComponentModel;

namespace RKD.Core
{
  
    public enum UserRoles
    {
        [Description("SuperAdmin")]
        SuperAdmin = 1,
        [Description("CompanyAdmin")]
        CompanyAdmin = 2,
        [Description("User")]
        User = 3,
    }

   
}