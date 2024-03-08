using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase, IEntityBase
    {
        public Guid Id {get; set;}
        public Guid FileName{get; set;}
        public Guid FileType {get; set;}
        public ICollection<Article> Articles {get; set;}
    }
}