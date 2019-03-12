using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Models;

namespace WendhelAton.FAQ.Web.ViewModels.Threads
{
    public class IndexViewModel
    {
        public List<Thread> Threads { get; set; }
    }
}
