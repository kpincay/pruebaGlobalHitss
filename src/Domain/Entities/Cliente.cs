using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Domain.Entities;

[Table("CL_Cliente", Schema = "dbo")]
public class Cliente
{
    [Column("id", Order = 0, TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    [Column("tipoIdentificacion", Order = 1, TypeName = "varchar")]
    [StringLength(1)]
    public string TipoIdentificacion { get; set; }

    [Column("identificacion", Order = 2, TypeName = "varchar")]
    [StringLength(20)]
    public string Identificacion { get; set; }

    [Column("nombres", Order = 3, TypeName = "varchar")]
    [StringLength(150)]
    public string Nombres { get; set; }

    [Column("apellidos", Order = 4, TypeName = "varchar")]
    [StringLength(150)]
    public string Apellidos { get; set; }

    [Column("direccion", Order = 5, TypeName = "varchar")]
    [StringLength(200)]
    public string Direccion { get; set; }

    [Column("celular", Order = 6, TypeName = "varchar")]
    [StringLength(10)]
    public string Celular { get; set; }

    [Column("correo", Order = 7, TypeName = "varchar")]
    [StringLength(80)]
    public string Correo { get; set; }

    [Column("fechaNacimiento", Order = 8, TypeName = "datetime")]
    public DateTime? FechaNacimiento { get; set; }

    [Column("genero", Order = 9, TypeName = "varchar")]
    [StringLength(1)]
    public string Genero { get; set; }

    [Column("fechaRegistro", Order = 10, TypeName = "datetime2")]
    public DateTime? FechaRegistro { get; set; }

    [Column("servicioActivo", Order = 11, TypeName = "bit")]
    public bool ServicioActivo { get; set; }


}

