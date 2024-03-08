using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Category
    {
       public Guid Id {get; set;}
       public string Name {get; set;}
       public ICollection<Article> Articles {get; set;}

    }
}