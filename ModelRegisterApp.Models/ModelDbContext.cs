using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ModelRegisterApp.Models
{
    public class ModelDbContext : DbContext

    {
        public ModelDbContext()
        {
            //Empty
        }
        public ModelDbContext(DbContextOptions<ModelDbContext>options)
            :base(options)
        {
            //Empty
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 닷넷 프레임워크 기반에서 호출되는 코드 영역: 
            // App.config 또는 Web.config의 연결 문자열 사용
            // 커넥션 스트링 읽기 위한 메소드
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "ConnectionString"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
        }
        // 이까지는 거의 공식
        public DbSet<Model> Models { get; set; }

    }
}
