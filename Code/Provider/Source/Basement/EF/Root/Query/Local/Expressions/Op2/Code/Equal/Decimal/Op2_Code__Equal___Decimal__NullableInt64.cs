﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 07.05.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Decimal;

using T_ARG2
 =System.Nullable<System.Int64>;

using T_RESULT
 =System.Boolean;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__Equal___Decimal__NullableInt64

static class Op2_Code__Equal___Decimal__NullableInt64
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo_V_V
   =typeof(Op2_Code__Equal___Decimal__NullableInt64)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!b.HasValue)
   return Op2_MasterResults__Equal.VALUE__NULL;

  Debug.Assert(b.HasValue);

  return MasterCode.Op2_MasterCode__Equal___Decimal__Decimal.Exec
          (a,
           b.Value);
 }//Exec_V_V
};//class Op2_Code__Equal___Decimal__NullableInt64

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
