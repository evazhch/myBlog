using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Sys
{
    public class SysMenu:BaseEntity
    {
        /// <summary>
        /// 地址
        /// </summary>
        public string MenuPath { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        public string MenuName { get; set; }
        
        /// <summary>
        /// 菜单icon
        /// </summary>
        public string Icon { get; set; }
        
        /// <summary>
        /// 父节点
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort {  get; set; }

        /// <summary>
        /// 是否是展示节点
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// 可读唯一标识
        /// </summary>
        public string MenuCode { get; set; }

        [NotMapped]
        public List<SysMenu> ChildMenus { get; set; }
    }
}
