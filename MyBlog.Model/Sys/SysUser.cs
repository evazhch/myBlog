using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Sys
{
    public class SysUser:BaseEntity
    {
        /// <summary>
        /// 登录名-不能重复
        /// </summary>
        public required string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public required string UserPassword { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string? NickName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string? Avature { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string? Phone { get; set; }

        [NotMapped]
        public List<SysRole> Roles { get; set; } 
                
    }
}
