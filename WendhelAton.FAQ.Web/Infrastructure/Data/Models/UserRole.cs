using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Enums;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;

namespace WendhelAton.FAQ.Web.Infrastructure.Data.Models
{
    public class UserRole : BaseModel
    {

        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}
