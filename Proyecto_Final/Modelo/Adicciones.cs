//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Adicciones
    {
        public Adicciones()
        {
            this.AdiccionesXUsu = new HashSet<AdiccionesXUsu>();
        }
    
        public int IdAdicciones { get; set; }
        public string NombreAdiccion { get; set; }
        public string Codigo { get; set; }
    
        public virtual ICollection<AdiccionesXUsu> AdiccionesXUsu { get; set; }
    }
}
