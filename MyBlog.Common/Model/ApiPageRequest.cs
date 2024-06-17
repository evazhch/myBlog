using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public class ApiPageRequest<T>
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public T SearchEntity { get; set; }
    }
}
