using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Dic
{
    public class DicItem:BaseEntity
    {
        /// <summary>
        /// 字典标识
        /// </summary>
        public string DicCode { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
