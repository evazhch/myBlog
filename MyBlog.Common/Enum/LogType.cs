using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Enum
{
    public enum LogType
    {
        /// <summary>
        /// 系统自身log
        /// </summary>
        SysLog=1,
        /// <summary>
        /// 系统异常log
        /// </summary>
        ErrorLog=-1,
        /// <summary>
        /// 第三方log
        /// </summary>
        ThirdLog=3
    }
}
