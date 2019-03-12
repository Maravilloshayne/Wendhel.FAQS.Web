using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Threads
{
    public class UpdateTitleViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public DateTime UpdatedAt{ get; set; }
    }   
}
