using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyBlog.DAL;
using MyBlog.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.Sys
{
    public class SysUserLogic
    {        

        protected readonly IConfiguration Configuration;

        protected readonly SysDbContext sysDbContext;

        public SysUserLogic(IConfiguration configuration, SysDbContext sysDbContext)
        {
            Configuration = configuration;
            this.sysDbContext = sysDbContext;
        }

        /// <summary>
        /// 根据用户名返回用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public SysUser GetSysUser(string userName)
        {
            SysUser sysUser= sysDbContext.SysUsers.Where(x => x.UserName == userName && !x.IsDeleted).FirstOrDefault();

            if (sysUser != null)
            {
                List<string> roleCodes = sysDbContext.SysUserRoles.Where(x => x.UserId == sysUser.Id && !x.IsDeleted).Select(x=>x.RoleCode).ToList();
                if(roleCodes.Any())
                {
                    sysUser.Roles = sysDbContext.SysRoles.Where(x => roleCodes.Contains(x.Code) && !x.IsDeleted).ToList();
                }                
            }            
            return sysUser;
        }
    }
}
