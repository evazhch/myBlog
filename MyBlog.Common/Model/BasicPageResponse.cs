using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public  class BasicPageResponse<T>
    {
        public int PageIndex {  get; set; }

        public int PageCount { get; set; }

        public int Total { get; set; }

        public List<T> Rows { get; set; }
    }
}
