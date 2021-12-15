﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 26.03.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.Int64>;

using T_ARG2
 =System.Nullable<System.Int32>;

using T_RESULT
 =System.Nullable<System.Int64>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__Add___NullableInt64__NullableInt32

static class Op2_Code__Add___NullableInt64__NullableInt32
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo_V_V
   =typeof(Op2_Code__Add___NullableInt64__NullableInt32)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!a.HasValue)
   return null;

  Debug.Assert(a.HasValue);

  if(!b.HasValue)
   return null;

  Debug.Assert(b.HasValue);

  return D0.Expressions.Op2.MasterCode.Op2_MasterCode__Add___Int64__Int64___checked.Exec
          (a.Value,
           b.Value);
 }//Exec_V_V
};//class Op2_Code__Add___NullableInt64__NullableInt32

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions.Op2.Code
