using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.ViewModels.Faqs
{
    public class FaqImportViewModel
    {
        public Guid? Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public string Description { get; set; }

    }
}