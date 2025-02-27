﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 03.05.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Int16;

using T_ARG2
 =System.Int64;

using T_RESULT
 =System.Boolean;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__LessThanOrEqual___Int16__Int64

static class Op2_Code__LessThanOrEqual___Int16__Int64
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__LessThanOrEqual___Int16__Int64)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  return MasterCode.Op2_MasterCode__LessThanOrEqual___Int64_Int64.Exec
          (a,
           b);
 }//Exec_V_V
};//class Op2_Code__LessThanOrEqual___Int16__Int64

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
