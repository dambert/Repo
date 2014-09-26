namespace MappingDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextoDB : DbContext
    {
        public ContextoDB()
            : base("name=ContextoDB")
        {
        }

        public virtual DbSet<ASIENTO> ASIENTO { get; set; }
        public virtual DbSet<ASIENTO_EVENTO> ASIENTO_EVENTO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<ESTADOASIENTO> ESTADOASIENTO { get; set; }
        public virtual DbSet<EVENTO> EVENTO { get; set; }
        public virtual DbSet<TIPO_ASIENTO> TIPO_ASIENTO { get; set; }
        public virtual DbSet<TIPOEMPLEADO> TIPOEMPLEADO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<VENTA> VENTA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASIENTO>()
                .Property(e => e.Letra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ASIENTO>()
                .HasMany(e => e.ASIENTO_EVENTO)
                .WithRequired(e => e.ASIENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.RUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.NUsername)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.NPassword)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .HasMany(e => e.VENTA)
                .WithRequired(e => e.EMPLEADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOASIENTO>()
                .Property(e => e.NEstadoAsiento)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTO>()
                .Property(e => e.NEvento)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTO>()
                .Property(e => e.TDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTO>()
                .HasMany(e => e.ASIENTO_EVENTO)
                .WithRequired(e => e.EVENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVENTO>()
                .HasMany(e => e.VENTA)
                .WithRequired(e => e.EVENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_ASIENTO>()
                .Property(e => e.NTipoAsiento)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ASIENTO>()
                .Property(e => e.NColor)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ASIENTO>()
                .Property(e => e.TDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOEMPLEADO>()
                .Property(e => e.NTipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.NNombres)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.NAPellidos)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.TDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasOptional(e => e.CLIENTE)
                .WithRequired(e => e.USUARIO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<USUARIO>()
                .HasOptional(e => e.EMPLEADO)
                .WithRequired(e => e.USUARIO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VENTA>()
                .Property(e => e.FBoleta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENTA>()
                .Property(e => e.FFactura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENTA>()
                .Property(e => e.RUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENTA>()
                .HasMany(e => e.ASIENTO)
                .WithMany(e => e.VENTA)
                .Map(m => m.ToTable("DETALLE_VENTA").MapLeftKey("CVenta").MapRightKey("CASiento"));
        }
    }
}
