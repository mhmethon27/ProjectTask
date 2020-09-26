using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Model
{
    public class comments
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public int postId { get; set; }
        public string usercomment { get; set; }
        public int islike { get; set; }
        public int isdislike { get; set; }
        public DateTime date { get; set; }

    }
}
