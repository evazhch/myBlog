using MyBlog.Common.Enum;
using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Sys
{
    public class SysLog:BaseEntity
    {
        /// <summary>
        /// 动作名称
        /// </summary>
        public string ActionName { get; set; } = string.Empty;

        /// <summary>
        /// 动作类型
        /// </summary>
        public LogType ActionType { get; set; }

        /// <summary>
        /// 操作耗时
        /// </summary>
        public int ActineCost { get; set; }

        public DateTime ActionTime { get; set; }

    }
}
