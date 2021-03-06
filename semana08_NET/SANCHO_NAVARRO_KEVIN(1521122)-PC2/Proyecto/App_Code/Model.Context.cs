﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;

public partial class bdArtefactoEntities : DbContext
{
    public bdArtefactoEntities()
        : base("name=bdArtefactoEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<Artefacto> Artefacto { get; set; }
    public DbSet<Calendario> Calendario { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Linea> Linea { get; set; }
    public DbSet<proforma> proforma { get; set; }

    public virtual int sp_Adi_Cli(string nOM, Nullable<decimal> tEL, Nullable<decimal> rUC, string dIREC)
    {
        var nOMParameter = nOM != null ?
            new ObjectParameter("NOM", nOM) :
            new ObjectParameter("NOM", typeof(string));

        var tELParameter = tEL.HasValue ?
            new ObjectParameter("TEL", tEL) :
            new ObjectParameter("TEL", typeof(decimal));

        var rUCParameter = rUC.HasValue ?
            new ObjectParameter("RUC", rUC) :
            new ObjectParameter("RUC", typeof(decimal));

        var dIRECParameter = dIREC != null ?
            new ObjectParameter("DIREC", dIREC) :
            new ObjectParameter("DIREC", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Adi_Cli", nOMParameter, tELParameter, rUCParameter, dIRECParameter);
    }

    public virtual int sp_Adi_Prof(string cODCLI, string cODART, Nullable<decimal> pREC, string tIPVEN)
    {
        var cODCLIParameter = cODCLI != null ?
            new ObjectParameter("CODCLI", cODCLI) :
            new ObjectParameter("CODCLI", typeof(string));

        var cODARTParameter = cODART != null ?
            new ObjectParameter("CODART", cODART) :
            new ObjectParameter("CODART", typeof(string));

        var pRECParameter = pREC.HasValue ?
            new ObjectParameter("PREC", pREC) :
            new ObjectParameter("PREC", typeof(decimal));

        var tIPVENParameter = tIPVEN != null ?
            new ObjectParameter("TIPVEN", tIPVEN) :
            new ObjectParameter("TIPVEN", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Adi_Prof", cODCLIParameter, cODARTParameter, pRECParameter, tIPVENParameter);
    }

    public virtual ObjectResult<sp_ArtefactosxLinea_Result> sp_ArtefactosxLinea(string cODLIN)
    {
        var cODLINParameter = cODLIN != null ?
            new ObjectParameter("CODLIN", cODLIN) :
            new ObjectParameter("CODLIN", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ArtefactosxLinea_Result>("sp_ArtefactosxLinea", cODLINParameter);
    }

    public virtual int sp_Elim_Cli(string cOD)
    {
        var cODParameter = cOD != null ?
            new ObjectParameter("COD", cOD) :
            new ObjectParameter("COD", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Elim_Cli", cODParameter);
    }

    public virtual ObjectResult<sp_ListarProfConFormato_Result> sp_ListarProfConFormato(Nullable<int> vAR)
    {
        var vARParameter = vAR.HasValue ?
            new ObjectParameter("VAR", vAR) :
            new ObjectParameter("VAR", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarProfConFormato_Result>("sp_ListarProfConFormato", vARParameter);
    }

    public virtual ObjectResult<sp_ListarProfConFormato2_Result> sp_ListarProfConFormato2(string cODCLI)
    {
        var cODCLIParameter = cODCLI != null ?
            new ObjectParameter("CODCLI", cODCLI) :
            new ObjectParameter("CODCLI", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarProfConFormato2_Result>("sp_ListarProfConFormato2", cODCLIParameter);
    }

    public virtual int sp_Modi_Cli(string cOD, string nOM, Nullable<decimal> tEL, Nullable<decimal> rUC, string dIREC)
    {
        var cODParameter = cOD != null ?
            new ObjectParameter("COD", cOD) :
            new ObjectParameter("COD", typeof(string));

        var nOMParameter = nOM != null ?
            new ObjectParameter("NOM", nOM) :
            new ObjectParameter("NOM", typeof(string));

        var tELParameter = tEL.HasValue ?
            new ObjectParameter("TEL", tEL) :
            new ObjectParameter("TEL", typeof(decimal));

        var rUCParameter = rUC.HasValue ?
            new ObjectParameter("RUC", rUC) :
            new ObjectParameter("RUC", typeof(decimal));

        var dIRECParameter = dIREC != null ?
            new ObjectParameter("DIREC", dIREC) :
            new ObjectParameter("DIREC", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Modi_Cli", cODParameter, nOMParameter, tELParameter, rUCParameter, dIRECParameter);
    }
}
