﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 03.05.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.Int64>;

using T_ARG2
 =System.SByte;

using T_RESULT
 =System.Nullable<System.Boolean>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__GreaterThanOrEqual___NullableInt64__SByte

static class Op2_Code__GreaterThanOrEqual___NullableInt64__SByte
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__GreaterThanOrEqual___NullableInt64__SByte)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!a.HasValue)
   return null;

  return MasterCode.Op2_MasterCode__GreaterThanOrEqual___Int64_Int64.Exec
          (a.Value,
           b);
 }//Exec_V_V
};//class Op2_Code__GreaterThanOrEqual___NullableInt64__SByte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
