using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;

namespace WendhelAton.FAQ.Web.Infrastructure.Data.Models
{
    public class Thread : BaseModel
    {
        public string Title { get; set; }

        public Guid? UserId { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsPublished { get; set; }

       

    }
}
