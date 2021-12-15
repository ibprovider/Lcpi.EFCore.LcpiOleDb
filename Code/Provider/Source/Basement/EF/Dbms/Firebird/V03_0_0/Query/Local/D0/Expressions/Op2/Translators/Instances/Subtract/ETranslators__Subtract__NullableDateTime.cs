﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 23.03.2021.

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Op2.Translators.Instances{
////////////////////////////////////////////////////////////////////////////////

using LOCAL_EVAL__Op2__ETranslator__Std__Simple
 =Root.Query.Local.Expressions.Op2.Translators.Std.ETranslator__Std__Simple;

using LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
 =Root.Query.Local.LcpiOleDb__LocalEval_Op2__Descr<Root.Query.Local.Expressions.Op2.Translators.Std.ETranslator__Std__Simple>;

////////////////////////////////////////////////////////////////////////////////
//class ETranslators__Subtract__NullableDateTime

static class ETranslators__Subtract__NullableDateTime
{
 public static readonly LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
  sm_Instance__DateTime
   =new LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
     (new LOCAL_EVAL__Op2__ETranslator__Std__Simple(Code.Op2_Code__Subtract___NullableDateTime__DateTime.MethodInfo_V_V));

 public static readonly LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
  sm_Instance__TimeSpan
   =new LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
     (new LOCAL_EVAL__Op2__ETranslator__Std__Simple(Code.Op2_Code__Subtract___NullableDateTime__TimeSpan.MethodInfo_V_V));

 //----------------------------------------- NULLABLE
 public static readonly LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
  sm_Instance__NullableDateTime
   =new LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
     (new LOCAL_EVAL__Op2__ETranslator__Std__Simple(Code.Op2_Code__Subtract___NullableDateTime__NullableDateTime.MethodInfo_V_V));

 public static readonly LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
  sm_Instance__NullableTimeSpan
   =new LOCAL_EVAL__Op2__ETranslator__Std__Simple__Descr
     (new LOCAL_EVAL__Op2__ETranslator__Std__Simple(Code.Op2_Code__Subtract___NullableDateTime__NullableTimeSpan.MethodInfo_V_V));
};//class ETranslators__Subtract__NullableDateTime

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Op2.Translators.Instances
