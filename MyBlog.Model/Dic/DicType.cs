using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Dic
{
    public class DicType:BaseEntity
    {
        /// <summary>
        /// 字典名称
        /// </summary>
        public required string DicName { get; set; }

        /// <summary>
        /// 字典可读标识
        /// </summary>
        public required string DicCode { get; set; }

        /// <summary>
        /// 字典描述
        /// </summary>
        public string? Description { get; set; }
    }
}
