using MyBlog.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public class ApiPageResponse<T>
    {
        public APIStatus Code { get; set; } = APIStatus.Success;

        public List<T> Rows { get; set; }

        public string Message { get; set; }= string.Empty;

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int Count { get; set; }

        public int PageCount { get; set; }
    }
}
