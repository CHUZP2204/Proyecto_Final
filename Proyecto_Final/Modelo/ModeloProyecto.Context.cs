﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Final.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class segurosEntities1 : DbContext
    {
        public segurosEntities1()
            : base("name=segurosEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Adicciones> Adicciones { get; set; }
        public DbSet<AdiccionesXUsu> AdiccionesXUsu { get; set; }
        public DbSet<BienesInmuebles> BienesInmuebles { get; set; }
        public DbSet<CoberturaPolizas> CoberturaPolizas { get; set; }
        public DbSet<RegistroPoliza> RegistroPoliza { get; set; }
        public DbSet<SegurosDeVida> SegurosDeVida { get; set; }
        public DbSet<TipoSeguro> TipoSeguro { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
    
        public virtual ObjectResult<sp_CoberturaSeguros_Result> sp_CoberturaSeguros(Nullable<int> idSeguro)
        {
            var idSeguroParameter = idSeguro.HasValue ?
                new ObjectParameter("idSeguro", idSeguro) :
                new ObjectParameter("idSeguro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CoberturaSeguros_Result>("sp_CoberturaSeguros", idSeguroParameter);
        }
    
        public virtual ObjectResult<sp_PolizaUsuario_Result> sp_PolizaUsuario(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PolizaUsuario_Result>("sp_PolizaUsuario", cedulaParameter);
        }
    
        public virtual int spEliminaTipoSeguro(Nullable<int> idTipoSeguro)
        {
            var idTipoSeguroParameter = idTipoSeguro.HasValue ?
                new ObjectParameter("idTipoSeguro", idTipoSeguro) :
                new ObjectParameter("idTipoSeguro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminaTipoSeguro", idTipoSeguroParameter);
        }
    
        public virtual int spInsertaTipoSeguro(Nullable<int> idTipoSeguro, string nombre)
        {
            var idTipoSeguroParameter = idTipoSeguro.HasValue ?
                new ObjectParameter("idTipoSeguro", idTipoSeguro) :
                new ObjectParameter("idTipoSeguro", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertaTipoSeguro", idTipoSeguroParameter, nombreParameter);
        }
    
        public virtual int spModificaVehiculo(Nullable<int> idVehiculo, string placa)
        {
            var idVehiculoParameter = idVehiculo.HasValue ?
                new ObjectParameter("IdVehiculo", idVehiculo) :
                new ObjectParameter("IdVehiculo", typeof(int));
    
            var placaParameter = placa != null ?
                new ObjectParameter("Placa", placa) :
                new ObjectParameter("Placa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificaVehiculo", idVehiculoParameter, placaParameter);
        }
    
        public virtual int sp_InsertaUsuario(string cedula, string genero, Nullable<System.DateTime> fechaNacimiento, string nombre, string primerApellido, string segundoApellido, string direccion, string telefonoPrincipal, string telefonoSecundario, string correo, string tipoUsuario, string contrasenia)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("PrimerApellido", primerApellido) :
                new ObjectParameter("PrimerApellido", typeof(string));
    
            var segundoApellidoParameter = segundoApellido != null ?
                new ObjectParameter("SegundoApellido", segundoApellido) :
                new ObjectParameter("SegundoApellido", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoPrincipalParameter = telefonoPrincipal != null ?
                new ObjectParameter("TelefonoPrincipal", telefonoPrincipal) :
                new ObjectParameter("TelefonoPrincipal", typeof(string));
    
            var telefonoSecundarioParameter = telefonoSecundario != null ?
                new ObjectParameter("TelefonoSecundario", telefonoSecundario) :
                new ObjectParameter("TelefonoSecundario", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var tipoUsuarioParameter = tipoUsuario != null ?
                new ObjectParameter("TipoUsuario", tipoUsuario) :
                new ObjectParameter("TipoUsuario", typeof(string));
    
            var contraseniaParameter = contrasenia != null ?
                new ObjectParameter("Contrasenia", contrasenia) :
                new ObjectParameter("Contrasenia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaUsuario", cedulaParameter, generoParameter, fechaNacimientoParameter, nombreParameter, primerApellidoParameter, segundoApellidoParameter, direccionParameter, telefonoPrincipalParameter, telefonoSecundarioParameter, correoParameter, tipoUsuarioParameter, contraseniaParameter);
        }
    
        public virtual ObjectResult<sp_RetornaUsuario_Result> sp_RetornaUsuario(string primerApellido, string nombre)
        {
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("primerApellido", primerApellido) :
                new ObjectParameter("primerApellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaUsuario_Result>("sp_RetornaUsuario", primerApellidoParameter, nombreParameter);
        }
    
        public virtual int sp_Elimina_UsuarioID(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Elimina_UsuarioID", idUsuarioParameter);
        }
    
        public virtual ObjectResult<sp_RetornaUsuarioID_Result> sp_RetornaUsuarioID(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaUsuarioID_Result>("sp_RetornaUsuarioID", idUsuarioParameter);
        }
    
        public virtual int sp_EliminaAdiccionesID(Nullable<int> idAdicciones)
        {
            var idAdiccionesParameter = idAdicciones.HasValue ?
                new ObjectParameter("idAdicciones", idAdicciones) :
                new ObjectParameter("idAdicciones", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaAdiccionesID", idAdiccionesParameter);
        }
    
        public virtual int sp_ModificaAdicciones(Nullable<int> idAdicciones, string nombre, string codigo)
        {
            var idAdiccionesParameter = idAdicciones.HasValue ?
                new ObjectParameter("idAdicciones", idAdicciones) :
                new ObjectParameter("idAdicciones", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var codigoParameter = codigo != null ?
                new ObjectParameter("Codigo", codigo) :
                new ObjectParameter("Codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaAdicciones", idAdiccionesParameter, nombreParameter, codigoParameter);
        }
    
        public virtual ObjectResult<sp_RetornaAdicciones_Result> sp_RetornaAdicciones(string nombre, string codigo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var codigoParameter = codigo != null ?
                new ObjectParameter("Codigo", codigo) :
                new ObjectParameter("Codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaAdicciones_Result>("sp_RetornaAdicciones", nombreParameter, codigoParameter);
        }
    
        public virtual ObjectResult<sp_RetornaAdiccionesID_Result> sp_RetornaAdiccionesID(Nullable<int> idAdicciones)
        {
            var idAdiccionesParameter = idAdicciones.HasValue ?
                new ObjectParameter("idAdicciones", idAdicciones) :
                new ObjectParameter("idAdicciones", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaAdiccionesID_Result>("sp_RetornaAdiccionesID", idAdiccionesParameter);
        }
    
        public virtual int spInsertaAdicciones(string nombre, string codigo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertaAdicciones", nombreParameter, codigoParameter);
        }
    
        public virtual int spModificaUsuarioID(Nullable<int> idUsuario, string cedula, string genero, Nullable<System.DateTime> fecha, string nombre, string primerApellido, string segundoApellido, string direccion, string telefonoPrincipal, string telefonoSecundario, string correo, string tipoUsuario, string contrasenia)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("PrimerApellido", primerApellido) :
                new ObjectParameter("PrimerApellido", typeof(string));
    
            var segundoApellidoParameter = segundoApellido != null ?
                new ObjectParameter("SegundoApellido", segundoApellido) :
                new ObjectParameter("SegundoApellido", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoPrincipalParameter = telefonoPrincipal != null ?
                new ObjectParameter("TelefonoPrincipal", telefonoPrincipal) :
                new ObjectParameter("TelefonoPrincipal", typeof(string));
    
            var telefonoSecundarioParameter = telefonoSecundario != null ?
                new ObjectParameter("TelefonoSecundario", telefonoSecundario) :
                new ObjectParameter("TelefonoSecundario", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var tipoUsuarioParameter = tipoUsuario != null ?
                new ObjectParameter("TipoUsuario", tipoUsuario) :
                new ObjectParameter("TipoUsuario", typeof(string));
    
            var contraseniaParameter = contrasenia != null ?
                new ObjectParameter("contrasenia", contrasenia) :
                new ObjectParameter("contrasenia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificaUsuarioID", idUsuarioParameter, cedulaParameter, generoParameter, fechaParameter, nombreParameter, primerApellidoParameter, segundoApellidoParameter, direccionParameter, telefonoPrincipalParameter, telefonoSecundarioParameter, correoParameter, tipoUsuarioParameter, contraseniaParameter);
        }
    
        public virtual int sp_EliminaCoberturas(Nullable<int> idCobertura)
        {
            var idCoberturaParameter = idCobertura.HasValue ?
                new ObjectParameter("idCobertura", idCobertura) :
                new ObjectParameter("idCobertura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaCoberturas", idCoberturaParameter);
        }
    
        public virtual int sp_InsertaCoberturas(string nombre, string descripcion, string porcentaje)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var porcentajeParameter = porcentaje != null ?
                new ObjectParameter("Porcentaje", porcentaje) :
                new ObjectParameter("Porcentaje", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaCoberturas", nombreParameter, descripcionParameter, porcentajeParameter);
        }
    
        public virtual ObjectResult<sp_RetornaCobertura_Result> sp_RetornaCobertura(string nombre, string porcentaje)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var porcentajeParameter = porcentaje != null ?
                new ObjectParameter("porcentaje", porcentaje) :
                new ObjectParameter("porcentaje", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaCobertura_Result>("sp_RetornaCobertura", nombreParameter, porcentajeParameter);
        }
    
        public virtual ObjectResult<sp_RetornaCoberturaID_Result> sp_RetornaCoberturaID(Nullable<int> idCobertura)
        {
            var idCoberturaParameter = idCobertura.HasValue ?
                new ObjectParameter("idCobertura", idCobertura) :
                new ObjectParameter("idCobertura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaCoberturaID_Result>("sp_RetornaCoberturaID", idCoberturaParameter);
        }
    
        public virtual int spModificaCoberturas(Nullable<int> idCobertura, string nombre, string descripcion, string porcentaje)
        {
            var idCoberturaParameter = idCobertura.HasValue ?
                new ObjectParameter("IdCobertura", idCobertura) :
                new ObjectParameter("IdCobertura", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var porcentajeParameter = porcentaje != null ?
                new ObjectParameter("Porcentaje", porcentaje) :
                new ObjectParameter("Porcentaje", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificaCoberturas", idCoberturaParameter, nombreParameter, descripcionParameter, porcentajeParameter);
        }
    
        public virtual int sp_EliminaAdiccionUsuario(Nullable<int> idIdentificador)
        {
            var idIdentificadorParameter = idIdentificador.HasValue ?
                new ObjectParameter("IdIdentificador", idIdentificador) :
                new ObjectParameter("IdIdentificador", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaAdiccionUsuario", idIdentificadorParameter);
        }
    
        public virtual int sp_InsertAdiccionUsuario(Nullable<int> idAdicciones, Nullable<int> idUsuario)
        {
            var idAdiccionesParameter = idAdicciones.HasValue ?
                new ObjectParameter("IdAdicciones", idAdicciones) :
                new ObjectParameter("IdAdicciones", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertAdiccionUsuario", idAdiccionesParameter, idUsuarioParameter);
        }
    
        public virtual int spModificaAdiccionUsuario(Nullable<int> idIdentificador, Nullable<int> idAdicciones, Nullable<int> idUsuario)
        {
            var idIdentificadorParameter = idIdentificador.HasValue ?
                new ObjectParameter("IdIdentificador", idIdentificador) :
                new ObjectParameter("IdIdentificador", typeof(int));
    
            var idAdiccionesParameter = idAdicciones.HasValue ?
                new ObjectParameter("IdAdicciones", idAdicciones) :
                new ObjectParameter("IdAdicciones", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificaAdiccionUsuario", idIdentificadorParameter, idAdiccionesParameter, idUsuarioParameter);
        }
    
        public virtual ObjectResult<sp_RetornaAdiccionUsuario_Result> sp_RetornaAdiccionUsuario(Nullable<int> idAdicciones, Nullable<int> idUsuario)
        {
            var idAdiccionesParameter = idAdicciones.HasValue ?
                new ObjectParameter("idAdicciones", idAdicciones) :
                new ObjectParameter("idAdicciones", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaAdiccionUsuario_Result>("sp_RetornaAdiccionUsuario", idAdiccionesParameter, idUsuarioParameter);
        }
    
        public virtual ObjectResult<sp_RetornaAdiccionUsuarioID_Result> sp_RetornaAdiccionUsuarioID(Nullable<int> idIdentificador)
        {
            var idIdentificadorParameter = idIdentificador.HasValue ?
                new ObjectParameter("idIdentificador", idIdentificador) :
                new ObjectParameter("idIdentificador", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaAdiccionUsuarioID_Result>("sp_RetornaAdiccionUsuarioID", idIdentificadorParameter);
        }
    
        public virtual int sp_Elimina_RegistroPolizaID(Nullable<int> idRegistro)
        {
            var idRegistroParameter = idRegistro.HasValue ?
                new ObjectParameter("idRegistro", idRegistro) :
                new ObjectParameter("idRegistro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Elimina_RegistroPolizaID", idRegistroParameter);
        }
    
        public virtual int sp_InsertaRegistroPoliza(string montoAsegurado, string porcentajeCobertura, Nullable<int> numeroAdicciones, string montoAdicciones, string primaAntesImpu, string impuestos, string primaFinal, Nullable<int> idSeguro, Nullable<int> idUsuario, Nullable<int> idCobertura)
        {
            var montoAseguradoParameter = montoAsegurado != null ?
                new ObjectParameter("montoAsegurado", montoAsegurado) :
                new ObjectParameter("montoAsegurado", typeof(string));
    
            var porcentajeCoberturaParameter = porcentajeCobertura != null ?
                new ObjectParameter("PorcentajeCobertura", porcentajeCobertura) :
                new ObjectParameter("PorcentajeCobertura", typeof(string));
    
            var numeroAdiccionesParameter = numeroAdicciones.HasValue ?
                new ObjectParameter("NumeroAdicciones", numeroAdicciones) :
                new ObjectParameter("NumeroAdicciones", typeof(int));
    
            var montoAdiccionesParameter = montoAdicciones != null ?
                new ObjectParameter("MontoAdicciones", montoAdicciones) :
                new ObjectParameter("MontoAdicciones", typeof(string));
    
            var primaAntesImpuParameter = primaAntesImpu != null ?
                new ObjectParameter("PrimaAntesImpu", primaAntesImpu) :
                new ObjectParameter("PrimaAntesImpu", typeof(string));
    
            var impuestosParameter = impuestos != null ?
                new ObjectParameter("Impuestos", impuestos) :
                new ObjectParameter("Impuestos", typeof(string));
    
            var primaFinalParameter = primaFinal != null ?
                new ObjectParameter("PrimaFinal", primaFinal) :
                new ObjectParameter("PrimaFinal", typeof(string));
    
            var idSeguroParameter = idSeguro.HasValue ?
                new ObjectParameter("IdSeguro", idSeguro) :
                new ObjectParameter("IdSeguro", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idCoberturaParameter = idCobertura.HasValue ?
                new ObjectParameter("IdCobertura", idCobertura) :
                new ObjectParameter("IdCobertura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaRegistroPoliza", montoAseguradoParameter, porcentajeCoberturaParameter, numeroAdiccionesParameter, montoAdiccionesParameter, primaAntesImpuParameter, impuestosParameter, primaFinalParameter, idSeguroParameter, idUsuarioParameter, idCoberturaParameter);
        }
    
        public virtual int sp_ModificaRegistroPolizaID(Nullable<int> idRegistro, string montoAsegurado, string porcentajeCobertura, Nullable<int> numeroAdicciones, string montoAdicciones, string primaAntesImpu, string impuestos, string primaFinal, Nullable<int> idSeguro, Nullable<int> idUsuario, Nullable<int> idCobertura)
        {
            var idRegistroParameter = idRegistro.HasValue ?
                new ObjectParameter("idRegistro", idRegistro) :
                new ObjectParameter("idRegistro", typeof(int));
    
            var montoAseguradoParameter = montoAsegurado != null ?
                new ObjectParameter("montoAsegurado", montoAsegurado) :
                new ObjectParameter("montoAsegurado", typeof(string));
    
            var porcentajeCoberturaParameter = porcentajeCobertura != null ?
                new ObjectParameter("PorcentajeCobertura", porcentajeCobertura) :
                new ObjectParameter("PorcentajeCobertura", typeof(string));
    
            var numeroAdiccionesParameter = numeroAdicciones.HasValue ?
                new ObjectParameter("NumeroAdicciones", numeroAdicciones) :
                new ObjectParameter("NumeroAdicciones", typeof(int));
    
            var montoAdiccionesParameter = montoAdicciones != null ?
                new ObjectParameter("MontoAdicciones", montoAdicciones) :
                new ObjectParameter("MontoAdicciones", typeof(string));
    
            var primaAntesImpuParameter = primaAntesImpu != null ?
                new ObjectParameter("PrimaAntesImpu", primaAntesImpu) :
                new ObjectParameter("PrimaAntesImpu", typeof(string));
    
            var impuestosParameter = impuestos != null ?
                new ObjectParameter("Impuestos", impuestos) :
                new ObjectParameter("Impuestos", typeof(string));
    
            var primaFinalParameter = primaFinal != null ?
                new ObjectParameter("PrimaFinal", primaFinal) :
                new ObjectParameter("PrimaFinal", typeof(string));
    
            var idSeguroParameter = idSeguro.HasValue ?
                new ObjectParameter("IdSeguro", idSeguro) :
                new ObjectParameter("IdSeguro", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idCoberturaParameter = idCobertura.HasValue ?
                new ObjectParameter("IdCobertura", idCobertura) :
                new ObjectParameter("IdCobertura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaRegistroPolizaID", idRegistroParameter, montoAseguradoParameter, porcentajeCoberturaParameter, numeroAdiccionesParameter, montoAdiccionesParameter, primaAntesImpuParameter, impuestosParameter, primaFinalParameter, idSeguroParameter, idUsuarioParameter, idCoberturaParameter);
        }
    
        public virtual ObjectResult<sp_retornaRegistroPoliza_Result> sp_retornaRegistroPoliza(string montoAsegurado, string porcentaje)
        {
            var montoAseguradoParameter = montoAsegurado != null ?
                new ObjectParameter("montoAsegurado", montoAsegurado) :
                new ObjectParameter("montoAsegurado", typeof(string));
    
            var porcentajeParameter = porcentaje != null ?
                new ObjectParameter("porcentaje", porcentaje) :
                new ObjectParameter("porcentaje", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_retornaRegistroPoliza_Result>("sp_retornaRegistroPoliza", montoAseguradoParameter, porcentajeParameter);
        }
    
        public virtual ObjectResult<sp_RetornaRegistroPolizaID_Result> sp_RetornaRegistroPolizaID(Nullable<int> idRegistro)
        {
            var idRegistroParameter = idRegistro.HasValue ?
                new ObjectParameter("idRegistro", idRegistro) :
                new ObjectParameter("idRegistro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaRegistroPolizaID_Result>("sp_RetornaRegistroPolizaID", idRegistroParameter);
        }
    
        public virtual ObjectResult<sp_Retorna_AdiccionesCliente_ID_Result> sp_Retorna_AdiccionesCliente_ID(string idUsuario)
        {
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Retorna_AdiccionesCliente_ID_Result>("sp_Retorna_AdiccionesCliente_ID", idUsuarioParameter);
        }
    
        public virtual ObjectResult<sp_Retorna_AdiccionesClientes_Result> sp_Retorna_AdiccionesClientes(string nombre, string primerApellido, string nombreAdiccion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("primerApellido", primerApellido) :
                new ObjectParameter("primerApellido", typeof(string));
    
            var nombreAdiccionParameter = nombreAdiccion != null ?
                new ObjectParameter("nombreAdiccion", nombreAdiccion) :
                new ObjectParameter("nombreAdiccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Retorna_AdiccionesClientes_Result>("sp_Retorna_AdiccionesClientes", nombreParameter, primerApellidoParameter, nombreAdiccionParameter);
        }
    
        public virtual ObjectResult<sp_Retorna_PolizasClientes_Result> sp_Retorna_PolizasClientes(string nombreUsuario, string primerApellido, string nombrePoliza, string porcentajeCobertura)
        {
            var nombreUsuarioParameter = nombreUsuario != null ?
                new ObjectParameter("nombreUsuario", nombreUsuario) :
                new ObjectParameter("nombreUsuario", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("primerApellido", primerApellido) :
                new ObjectParameter("primerApellido", typeof(string));
    
            var nombrePolizaParameter = nombrePoliza != null ?
                new ObjectParameter("nombrePoliza", nombrePoliza) :
                new ObjectParameter("nombrePoliza", typeof(string));
    
            var porcentajeCoberturaParameter = porcentajeCobertura != null ?
                new ObjectParameter("PorcentajeCobertura", porcentajeCobertura) :
                new ObjectParameter("PorcentajeCobertura", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Retorna_PolizasClientes_Result>("sp_Retorna_PolizasClientes", nombreUsuarioParameter, primerApellidoParameter, nombrePolizaParameter, porcentajeCoberturaParameter);
        }
    
        public virtual ObjectResult<sp_Retorna_PolizasClientes_ID_Result> sp_Retorna_PolizasClientes_ID(string idUsuario)
        {
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Retorna_PolizasClientes_ID_Result>("sp_Retorna_PolizasClientes_ID", idUsuarioParameter);
        }
    }
}
