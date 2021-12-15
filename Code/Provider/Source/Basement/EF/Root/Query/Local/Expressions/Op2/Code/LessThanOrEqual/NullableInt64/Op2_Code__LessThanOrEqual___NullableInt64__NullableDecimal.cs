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
 =System.Nullable<System.Decimal>;

using T_RESULT
 =System.Nullable<System.Boolean>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__LessThanOrEqual___NullableInt64__NullableDecimal

static class Op2_Code__LessThanOrEqual___NullableInt64__NullableDecimal
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__LessThanOrEqual___NullableInt64__NullableDecimal)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!a.HasValue)
   return null;

  if(!b.HasValue)
   return null;

  return MasterCode.Op2_MasterCode__LessThanOrEqual___Decimal__Decimal.Exec
          (a.Value,
           b.Value);
 }//Exec_V_V
};//class Op2_Code__LessThanOrEqual___NullableInt64__NullableDecimal

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
