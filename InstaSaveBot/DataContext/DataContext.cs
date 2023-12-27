using System.Collections.Generic;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_video_saver_bot.Models;

namespace Instagram_video_saver_bot.DataContexts
{
    public class DataContext : DbContext
    {
        string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=Instagram_videoo;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(connectionString);
        }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
