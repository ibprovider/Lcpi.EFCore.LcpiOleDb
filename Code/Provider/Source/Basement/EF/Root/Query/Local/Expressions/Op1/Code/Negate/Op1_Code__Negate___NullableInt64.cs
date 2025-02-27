﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 12.10.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op1.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.Int64>;

using T_RESULT
 =System.Nullable<System.Int64>;

////////////////////////////////////////////////////////////////////////////////
//class Op1_Code__Negate___NullableInt64

static class Op1_Code__Negate___NullableInt64
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo_V
   =typeof(Op1_Code__Negate___NullableInt64)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V(T_ARG1 v)
 {
  if(!v.HasValue)
   return null;

  Debug.Assert(v.HasValue);

  return MasterCode.Op1_MasterCode__Negate___Int64___checked.Exec
          (v.Value);
 }//Exec_V
};//class Op1_Code__Negate___NullableInt64

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op1.Code
