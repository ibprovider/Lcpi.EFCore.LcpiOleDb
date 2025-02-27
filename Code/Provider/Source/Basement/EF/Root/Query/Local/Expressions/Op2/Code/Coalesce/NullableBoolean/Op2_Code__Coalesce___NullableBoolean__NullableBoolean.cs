﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 10.09.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.Boolean>;

using T_ARG2
 =System.Nullable<System.Boolean>;

using T_RESULT
 =System.Nullable<System.Boolean>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__Coalesce___NullableBoolean__NullableBoolean

static class Op2_Code__Coalesce___NullableBoolean__NullableBoolean
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo_V_V
   =typeof(Op2_Code__Coalesce___NullableBoolean__NullableBoolean)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(a.HasValue)
   return a;

  return b;
 }//Exec_V_V
};//class Op2_Code__Coalesce___NullableBoolean__NullableBoolean

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
