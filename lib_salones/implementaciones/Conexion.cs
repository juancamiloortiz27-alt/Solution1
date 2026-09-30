using lib_salones.entidades;
using lib_salones.interfaces;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace lib_salones.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Salones>? Salones { get; set; }
    }
}

// server=localhost;database=db_facturas;uid=sa;pwd=*!;TrustServerCertificate=true;
// server=localhost;database=db_facturas;Integrated Security=True;TrustServerCertificate=true;