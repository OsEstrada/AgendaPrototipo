﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calendario
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class syspolizaEntities : DbContext
    {
        public syspolizaEntities()
            : base("name=syspolizaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<AutomotorClase> AutomotorClase { get; set; }
        public virtual DbSet<Automotores> Automotores { get; set; }
        public virtual DbSet<AutomotoresCoberturas> AutomotoresCoberturas { get; set; }
        public virtual DbSet<AutomotoresMarcas> AutomotoresMarcas { get; set; }
        public virtual DbSet<AutomotoresModelos> AutomotoresModelos { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<BienesAsegurados> BienesAsegurados { get; set; }
        public virtual DbSet<CertificadoAutomotor> CertificadoAutomotor { get; set; }
        public virtual DbSet<CertificadoPersona> CertificadoPersona { get; set; }
        public virtual DbSet<CertificadoPersonaBeneficiario> CertificadoPersonaBeneficiario { get; set; }
        public virtual DbSet<Certificados> Certificados { get; set; }
        public virtual DbSet<CertificadoTransporte> CertificadoTransporte { get; set; }
        public virtual DbSet<Cuotas> Cuotas { get; set; }
        public virtual DbSet<Deducibles> Deducibles { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Exclusiones> Exclusiones { get; set; }
        public virtual DbSet<FormaDePago> FormaDePago { get; set; }
        public virtual DbSet<GastoFraccionado> GastoFraccionado { get; set; }
        public virtual DbSet<GastoInicial> GastoInicial { get; set; }
        public virtual DbSet<GrupoClientes> GrupoClientes { get; set; }
        public virtual DbSet<HistorialUsuario> HistorialUsuario { get; set; }
        public virtual DbSet<HistoricoCuotas> HistoricoCuotas { get; set; }
        public virtual DbSet<HistoricoPagos> HistoricoPagos { get; set; }
        public virtual DbSet<HistoricoPoliza> HistoricoPoliza { get; set; }
        public virtual DbSet<HistoricoPrima> HistoricoPrima { get; set; }
        public virtual DbSet<Inmuebles> Inmuebles { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PersonaContactos> PersonaContactos { get; set; }
        public virtual DbSet<PersonaDirecciones> PersonaDirecciones { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<PolizaAutomotorCoberturas> PolizaAutomotorCoberturas { get; set; }
        public virtual DbSet<PolizaCancelaciones> PolizaCancelaciones { get; set; }
        public virtual DbSet<PolizaComentarios> PolizaComentarios { get; set; }
        public virtual DbSet<PolizaDeducibles> PolizaDeducibles { get; set; }
        public virtual DbSet<PolizaGastosFraccionados> PolizaGastosFraccionados { get; set; }
        public virtual DbSet<PolizaGastosIniciales> PolizaGastosIniciales { get; set; }
        public virtual DbSet<Polizas> Polizas { get; set; }
        public virtual DbSet<PolizaTransporteCoberturas> PolizaTransporteCoberturas { get; set; }
        public virtual DbSet<PolizaTransporteDocumento> PolizaTransporteDocumento { get; set; }
        public virtual DbSet<Primas> Primas { get; set; }
        public virtual DbSet<Ramos> Ramos { get; set; }
        public virtual DbSet<ReclamoDocumento> ReclamoDocumento { get; set; }
        public virtual DbSet<Reclamos> Reclamos { get; set; }
        public virtual DbSet<ReclamoSeguimiento> ReclamoSeguimiento { get; set; }
        public virtual DbSet<TipoBeneficiario> TipoBeneficiario { get; set; }
        public virtual DbSet<TipoBien> TipoBien { get; set; }
        public virtual DbSet<TipoCategoria> TipoCategoria { get; set; }
        public virtual DbSet<TipoCertificado> TipoCertificado { get; set; }
        public virtual DbSet<TipoContribuyentes> TipoContribuyentes { get; set; }
        public virtual DbSet<TipoDireccion> TipoDireccion { get; set; }
        public virtual DbSet<TipoDocumentoLegal> TipoDocumentoLegal { get; set; }
        public virtual DbSet<TipoDocumentoReclamo> TipoDocumentoReclamo { get; set; }
        public virtual DbSet<TipoEndoso> TipoEndoso { get; set; }
        public virtual DbSet<TipoEstatus> TipoEstatus { get; set; }
        public virtual DbSet<TipoGasto> TipoGasto { get; set; }
        public virtual DbSet<TipoPersona> TipoPersona { get; set; }
        public virtual DbSet<TipoPlaca> TipoPlaca { get; set; }
        public virtual DbSet<TipoPoliza> TipoPoliza { get; set; }
        public virtual DbSet<TipoPrima> TipoPrima { get; set; }
        public virtual DbSet<TransporteCoberturas> TransporteCoberturas { get; set; }
        public virtual DbSet<TransporteDetalleFacturas> TransporteDetalleFacturas { get; set; }
        public virtual DbSet<UsuarioDepartamento> UsuarioDepartamento { get; set; }
        public virtual DbSet<UsuarioPuestoFuncional> UsuarioPuestoFuncional { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}