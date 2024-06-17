using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Model
{
    /// <summary>
    /// 基本实体类
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// id
        /// </summary>                
        public Guid Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string? Creator { get; set; }
        
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdatedTime { get; set;}

        /// <summary>
        /// 更新人
        /// </summary>
        public string? Updater { get; set; }
    }
}
