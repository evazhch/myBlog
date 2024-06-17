using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public class PageRequest<T>
    {
        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public T Parament { get; set; }
    }
}
