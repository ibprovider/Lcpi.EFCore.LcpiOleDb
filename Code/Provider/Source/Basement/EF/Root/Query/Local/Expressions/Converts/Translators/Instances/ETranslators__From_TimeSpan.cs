﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 14.05.2021.

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Translators.Instances{
////////////////////////////////////////////////////////////////////////////////

using LOCAL_EVAL__Convert__Descr
 =Root.Query.Local.LcpiOleDb__LocalEval_Convert__Descr;

using LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE
 =Root.Query.Local.Expressions.Converts.Translators.Std.ETranslator__Std__Simple;

////////////////////////////////////////////////////////////////////////////////
//class ETranslators__From_TimeSpan

static class ETranslators__From_TimeSpan
{
 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__Object
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__TimeSpan__Object.MethodInfo),
      null);

 //-------------------------------------------------------- NULLABLE
 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableTimeSpan
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__TimeSpan__NullableTimeSpan.MethodInfo),
      null);
};//class ETranslators__From_TimeSpan

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Translators.Instances
