using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Sys
{
    public class SysUserRole:BaseEntity
    {
        public Guid UserId { get; set; }

        public string RoleCode { get; set; }
    }
}
