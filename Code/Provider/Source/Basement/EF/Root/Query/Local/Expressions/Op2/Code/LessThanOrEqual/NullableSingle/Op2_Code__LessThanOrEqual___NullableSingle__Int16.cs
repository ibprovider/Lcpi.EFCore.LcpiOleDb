﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 03.05.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.Single>;

using T_ARG2
 =System.Int16;

using T_RESULT
 =System.Nullable<System.Boolean>;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__LessThanOrEqual___NullableSingle__Int16

static class Op2_Code__LessThanOrEqual___NullableSingle__Int16
{
 public static readonly System.Reflection.MethodInfo MethodInfo_V_V
  =typeof(Op2_Code__LessThanOrEqual___NullableSingle__Int16)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!a.HasValue)
   return null;

  return MasterCode.Op2_MasterCode__LessThanOrEqual___Double__Double.Exec
          (a.Value,
           b);
 }//Exec_V_V
};//class Op2_Code__LessThanOrEqual___NullableSingle__Int16

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
