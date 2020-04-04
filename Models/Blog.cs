using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CacheExample.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }
}
