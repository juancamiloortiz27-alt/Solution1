using lib_salones.entidades;
using Microsoft.EntityFrameworkCore;

namespace lib_salones.interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Salones>? Salones { get; set; }
    }
}
