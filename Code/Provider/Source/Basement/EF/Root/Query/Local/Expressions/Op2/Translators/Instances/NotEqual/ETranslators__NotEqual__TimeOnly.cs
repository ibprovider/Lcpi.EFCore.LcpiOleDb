﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 04.07.2021.

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Translators.Instances{
////////////////////////////////////////////////////////////////////////////////

using LOCAL_EVAL__Op2__ETranslator__Std__WithOpCtx
 =Root.Query.Local.Expressions.Op2.Translators.Std.ETranslator__Std__WithOpCtx;

using LOCAL_EVAL__Op2__ETranslator__Std__WithOpCtx__Descr
 =Root.Query.Local.LcpiOleDb__LocalEval_Op2__Descr<Root.Query.Local.Expressions.Op2.Translators.Std.ETranslator__Std__WithOpCtx>;

////////////////////////////////////////////////////////////////////////////////
//class ETranslators__NotEqual__TimeOnly

static class ETranslators__NotEqual__TimeOnly
{
 public static readonly LOCAL_EVAL__Op2__ETranslator__Std__WithOpCtx__Descr
  sm_Instance__String
   =new LOCAL_EVAL__Op2__ETranslator__Std__WithOpCtx__Descr
     (new LOCAL_EVAL__Op2__ETranslator__Std__WithOpCtx(Code.Op2_Code__NotEqual___TimeOnly__String.MethodInfo_V_V),
      Code.Op2_Code__NotEqual___TimeOnly__String.Instance);
};//class ETranslators__NotEqual__TimeOnly

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Translators.Instances
