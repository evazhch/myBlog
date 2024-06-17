using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyBlog.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DAL
{
    public class SysDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public SysDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase")).UseSnakeCaseNamingConvention();
        }

        public DbSet<SysUser> SysUsers { get; set; }

        public DbSet<SysRole> SysRoles { get; set; }

        public DbSet<SysMenu> SysMenus { get; set; }

        public DbSet<SysRoleMenu> SysRolesMenu { get; set; }

        public DbSet<SysUserRole> SysUserRoles { get; set; }

        public DbSet<SysLog> SysLogs { get; set; }

    }
}
