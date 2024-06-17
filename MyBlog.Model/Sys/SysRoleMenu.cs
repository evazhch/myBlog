using MyBlog.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model.Sys
{
    public class SysRoleMenu:BaseEntity
    {
        public string RoleCode { get; set; }

        public string MenuCode { get; set; }
    }
}
