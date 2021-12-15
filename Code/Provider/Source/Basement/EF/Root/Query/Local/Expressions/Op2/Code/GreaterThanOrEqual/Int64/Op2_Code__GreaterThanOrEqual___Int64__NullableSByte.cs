﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 03.05.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Int64;

using T_ARG2
 =System.Nullable<System.SByte>;

using T_RESULT
 =System.Nullable<System.Boolean>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__GreaterThanOrEqual___Int64__NullableSByte

static class Op2_Code__GreaterThanOrEqual___Int64__NullableSByte
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__GreaterThanOrEqual___Int64__NullableSByte)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!b.HasValue)
   return null;

  return MasterCode.Op2_MasterCode__GreaterThanOrEqual___Int64_Int64.Exec
          (a,
           b.Value);
 }//Exec_V_V
};//class Op2_Code__GreaterThanOrEqual___Int64__NullableSByte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
