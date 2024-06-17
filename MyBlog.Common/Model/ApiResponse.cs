using MyBlog.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    public class ApiResponse<T>
    {
        public APIStatus Code { get; set; }= APIStatus.Success;

        public T Data { get; set; }

        public string Message { get; set; }        

        public ApiResponse() {
            Code = APIStatus.Success;
        }

        public ApiResponse(APIStatus code, T data)
        {
            Code = code;
            Data = data;
        }

        public ApiResponse(T data)
        {
            Code= APIStatus.Success;
            Data = data;
        }

        public ApiResponse(string message)
        {
            Code = APIStatus.Fail;
            Message = message;
        }
    }
}
