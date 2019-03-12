using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.ViewModels.Threads
{
    public class ThreadsViewModel
    {
        public Guid? ThreadId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsPublished { get; set; }



    }
}
