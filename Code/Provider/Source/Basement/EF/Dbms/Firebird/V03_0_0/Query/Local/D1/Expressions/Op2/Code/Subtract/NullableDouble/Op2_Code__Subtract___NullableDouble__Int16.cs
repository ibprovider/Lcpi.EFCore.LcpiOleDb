﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 20.04.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D1.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.Double>;

using T_ARG2
 =System.Int16;

using T_RESULT
 =System.Nullable<System.Double>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__Subtract___NullableDouble__Int16

static class Op2_Code__Subtract___NullableDouble__Int16
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__Subtract___NullableDouble__Int16)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!a.HasValue)
   return null;

  Debug.Assert(a.HasValue);

  return D0.Expressions.Op2.MasterCode.Op2_MasterCode__Subtract___Double__Double.Exec
          (a.Value,
           b);
 }//Exec_V_V
};//class Op2_Code__Subtract___NullableDouble__Int16

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D1.Expressions.Op2.Code
