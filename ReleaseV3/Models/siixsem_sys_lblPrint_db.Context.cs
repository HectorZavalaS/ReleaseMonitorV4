﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReleaseMonitorV4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class siixsem_sys_lblPrint_dbEntities : DbContext
    {
        public siixsem_sys_lblPrint_dbEntities()
            : base("name=siixsem_sys_lblPrint_dbEntities")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 380;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<existDJGroupOr_Result> existDJGroupOr(string djGroup, string pNum)
        {
            var djGroupParameter = djGroup != null ?
                new ObjectParameter("djGroup", djGroup) :
                new ObjectParameter("djGroup", typeof(string));
    
            var pNumParameter = pNum != null ?
                new ObjectParameter("pNum", pNum) :
                new ObjectParameter("pNum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<existDJGroupOr_Result>("existDJGroupOr", djGroupParameter, pNumParameter);
        }
    
        public virtual ObjectResult<insertSpec3_Result> insertSpec3(Nullable<int> idModel, Nullable<int> idFlx, Nullable<int> idColor, Nullable<int> idVolt, Nullable<int> idUser, Nullable<int> cantTot, Nullable<int> iniFolio, Nullable<int> finFolio, Nullable<int> currFolio, string djNo, string aName, Nullable<System.DateTime> datePlan, Nullable<int> is_rem, string djGroup)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idFlxParameter = idFlx.HasValue ?
                new ObjectParameter("idFlx", idFlx) :
                new ObjectParameter("idFlx", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            var idVoltParameter = idVolt.HasValue ?
                new ObjectParameter("idVolt", idVolt) :
                new ObjectParameter("idVolt", typeof(int));
    
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            var cantTotParameter = cantTot.HasValue ?
                new ObjectParameter("cantTot", cantTot) :
                new ObjectParameter("cantTot", typeof(int));
    
            var iniFolioParameter = iniFolio.HasValue ?
                new ObjectParameter("iniFolio", iniFolio) :
                new ObjectParameter("iniFolio", typeof(int));
    
            var finFolioParameter = finFolio.HasValue ?
                new ObjectParameter("finFolio", finFolio) :
                new ObjectParameter("finFolio", typeof(int));
    
            var currFolioParameter = currFolio.HasValue ?
                new ObjectParameter("currFolio", currFolio) :
                new ObjectParameter("currFolio", typeof(int));
    
            var djNoParameter = djNo != null ?
                new ObjectParameter("djNo", djNo) :
                new ObjectParameter("djNo", typeof(string));
    
            var aNameParameter = aName != null ?
                new ObjectParameter("aName", aName) :
                new ObjectParameter("aName", typeof(string));
    
            var datePlanParameter = datePlan.HasValue ?
                new ObjectParameter("datePlan", datePlan) :
                new ObjectParameter("datePlan", typeof(System.DateTime));
    
            var is_remParameter = is_rem.HasValue ?
                new ObjectParameter("is_rem", is_rem) :
                new ObjectParameter("is_rem", typeof(int));
    
            var djGroupParameter = djGroup != null ?
                new ObjectParameter("djGroup", djGroup) :
                new ObjectParameter("djGroup", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insertSpec3_Result>("insertSpec3", idModelParameter, idFlxParameter, idColorParameter, idVoltParameter, idUserParameter, cantTotParameter, iniFolioParameter, finFolioParameter, currFolioParameter, djNoParameter, aNameParameter, datePlanParameter, is_remParameter, djGroupParameter);
        }
    
        public virtual ObjectResult<existDjGroup_Result> existDjGroup(string nd)
        {
            var ndParameter = nd != null ?
                new ObjectParameter("nd", nd) :
                new ObjectParameter("nd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<existDjGroup_Result>("existDjGroup", ndParameter);
        }
    
        public virtual ObjectResult<getLaserDjs_Result> getLaserDjs(string fechaIni, string fechaFin)
        {
            var fechaIniParameter = fechaIni != null ?
                new ObjectParameter("fechaIni", fechaIni) :
                new ObjectParameter("fechaIni", typeof(string));
    
            var fechaFinParameter = fechaFin != null ?
                new ObjectParameter("fechaFin", fechaFin) :
                new ObjectParameter("fechaFin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLaserDjs_Result>("getLaserDjs", fechaIniParameter, fechaFinParameter);
        }
    
        public virtual ObjectResult<getIdmodelByDJGroup_Result> getIdmodelByDJGroup(string djGroup)
        {
            var djGroupParameter = djGroup != null ?
                new ObjectParameter("djGroup", djGroup) :
                new ObjectParameter("djGroup", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getIdmodelByDJGroup_Result>("getIdmodelByDJGroup", djGroupParameter);
        }
    
        public virtual int getQtyDjGrp(Nullable<int> djGrp, Nullable<int> djNo, Nullable<int> idModel)
        {
            var djGrpParameter = djGrp.HasValue ?
                new ObjectParameter("DjGrp", djGrp) :
                new ObjectParameter("DjGrp", typeof(int));
    
            var djNoParameter = djNo.HasValue ?
                new ObjectParameter("DjNo", djNo) :
                new ObjectParameter("DjNo", typeof(int));
    
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("IdModel", idModel) :
                new ObjectParameter("IdModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getQtyDjGrp", djGrpParameter, djNoParameter, idModelParameter);
        }
    
        public virtual ObjectResult<getQtyByDjGr_Result> getQtyByDjGr(string djGr)
        {
            var djGrParameter = djGr != null ?
                new ObjectParameter("djGr", djGr) :
                new ObjectParameter("djGr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getQtyByDjGr_Result>("getQtyByDjGr", djGrParameter);
        }
    
        public virtual ObjectResult<getQtyMitByDJGroup_Result> getQtyMitByDJGroup(string dj_group)
        {
            var dj_groupParameter = dj_group != null ?
                new ObjectParameter("dj_group", dj_group) :
                new ObjectParameter("dj_group", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getQtyMitByDJGroup_Result>("getQtyMitByDJGroup", dj_groupParameter);
        }
    }
}
