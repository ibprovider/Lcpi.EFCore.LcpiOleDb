﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 19.04.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Int64;

using T_ARG2
 =System.Int16;

using T_RESULT
 =System.Int64;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__Subtract___Int64__Int16

static class Op2_Code__Subtract___Int64__Int16
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__Subtract___Int64__Int16)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  return D0.Expressions.Op2.MasterCode.Op2_MasterCode__Subtract___Int64__Int64___checked.Exec
          (a,
           b);
 }//Exec_V_V
};//class Op2_Code__Subtract___Int64__Int16

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions.Op2.Code
