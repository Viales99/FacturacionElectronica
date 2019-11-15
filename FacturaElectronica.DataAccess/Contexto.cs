using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FacturaElectronica.DataAccess
{
    public class Contexto : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.AspNetUsers>().ToTable("AspNetUsers");
            modelBuilder.Entity<Model.AspNetRoles>().ToTable("AspNetRoles");
            modelBuilder.Entity<Model.AspNetUserClaims>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<Model.AspNetUserLogins>().ToTable("AspNetUserLogins");
            modelBuilder.Entity<Model.AspNetUserRoles>().ToTable("AspNetUserRoles");

            modelBuilder.Entity<Model.Factura>().ToTable("Factura");
            modelBuilder.Entity<Model.Emisor>().ToTable("Emisor");
            modelBuilder.Entity<Model.Receptor>().ToTable("Receptor");
            modelBuilder.Entity<Model.Telefono>().ToTable("Telefono");
            modelBuilder.Entity<Model.Fax>().ToTable("Fax");
            modelBuilder.Entity<Model.Correo>().ToTable("Correo");
            modelBuilder.Entity<Model.Ubicacion>().ToTable("Ubicacion");
            modelBuilder.Entity<Model.Identificacion>().ToTable("Identificacion");
            modelBuilder.Entity<Model.CodigoTipoMoneda>().ToTable("CodigoTipoMoneda");
            modelBuilder.Entity<Model.Exoneracion>().ToTable("Exoneracion");
            modelBuilder.Entity<Model.InformacionDeReferencia>().ToTable("InformacionReferencia");
            modelBuilder.Entity<Model.LineaDetalle>().ToTable("LineaDetalle");
            modelBuilder.Entity<Model.OtrosCargos>().ToTable("OtrosCargos");
            modelBuilder.Entity<Model.Descuento>().ToTable("Descuento");
            modelBuilder.Entity<Model.Impuesto>().ToTable("Impuesto");
            modelBuilder.Entity<Model.ResumenFactura>().ToTable("ResumenFactura"); 
            modelBuilder.Entity<Model.Producto>().ToTable("Producto");

        }

        public DbSet<Model.AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Model.AspNetRoles> AspNetRoles { get; set; }
        public DbSet<Model.AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<Model.AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<Model.AspNetUserRoles> AspNetUserRoles { get; set; }

        public DbSet<Model.Factura> Factura { get; set; }
        public DbSet<Model.Emisor> Emisor { get; set; }
        public DbSet<Model.Receptor> Receptor { get; set; }
        public DbSet<Model.Telefono> Telefono { get; set; }
        public DbSet<Model.Fax> Fax { get; set; }
        public DbSet<Model.Correo> Correo { get; set; }
        public DbSet<Model.Ubicacion> Ubicacion { get; set; }
        public DbSet<Model.Identificacion> Identificacion { get; set; }
        public DbSet<Model.CodigoTipoMoneda> CodigoTipoMoneda { get; set; }
        public DbSet<Model.Exoneracion> Exoneracion { get; set; }
        public DbSet<Model.InformacionDeReferencia> InformacionDeReferencia { get; set; }
        public DbSet<Model.LineaDetalle> LineaDetalle { get; set; }
        public DbSet<Model.OtrosCargos> OtrosCargos { get; set; }
        public DbSet<Model.Descuento> Descuento { get; set; }
        public DbSet<Model.Impuesto> Impuesto { get; set; }
        public DbSet<Model.ResumenFactura> ResumenFactura { get; set; } 
        public DbSet<Model.Producto> Producto { get; set; }

    }
}
