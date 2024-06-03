using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public class BasicResponse<T>
    {
        public string Code { get; set; }

        public T Data { get; set; }

        public string Message { get; set; }        
    }
}
