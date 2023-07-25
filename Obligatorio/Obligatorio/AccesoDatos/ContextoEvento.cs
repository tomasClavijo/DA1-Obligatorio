using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Dominio;

namespace AccesoDatos
{
    public class ContextoEvento : DbContext
    {
        public virtual DbSet<Productor> Productores { get; set; }
        public virtual DbSet<Asistente> Asistentes { get; set; }

        public virtual DbSet<Evento> Eventos { get; set; }

        public virtual DbSet<Compra> Compras { get; set; }

        public virtual DbSet<EntradaVendida> EntradasVendidas { get; set; }

        public virtual DbSet<Cupon> Cupones { get; set; }

        public virtual DbSet<AsistenteCuponEvento> AsistentesCuponesEventos { get; set; }


        public ContextoEvento() : base(nameOrConnectionString: "EventosBD")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>()
                        .HasMany<Ticket>(e => e.Tickets)
                        .WithRequired(t => t.Evento)
                        .WillCascadeOnDelete(true);

            modelBuilder.Entity<Evento>()
                        .HasMany<Funcion>(e => e.Funciones)
                        .WithRequired(f => f.Evento)
                        .WillCascadeOnDelete(true);

            modelBuilder.Entity<Funcion>()
                .HasMany<ParTicketCantidad>(f => f.ListaTickets)
                .WithRequired(p => p.Funcion)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Compra>()
                .HasMany<Codigo>(compra => compra.Codigos)
                .WithRequired(codigo => codigo.Compra)
                .WillCascadeOnDelete(true);
        }
    }
}
