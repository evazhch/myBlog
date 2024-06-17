using MyBlog.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public class CustomException(int code,string message) :Exception(message)
    {
        public int Code { get; set; } = code;

        public string Messenger { get; set; } = message;

    }
}
