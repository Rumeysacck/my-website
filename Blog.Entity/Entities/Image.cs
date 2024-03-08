using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Image
    {
        public Guid Id {get; set;}
        public Guid FileName{get; set;}
        public Guid FileType {get; set;}
        public ICollection<Article> Articles {get; set;}
    }
}