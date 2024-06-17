using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Sys
{
    public class SysRole:BaseEntity
    {
        /// <summary>
        /// 可读唯一标识
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Description { get; set; }

        [NotMapped]
        public List<SysMenu> Menus { get; set; }
    }
}
