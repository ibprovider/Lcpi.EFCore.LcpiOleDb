﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 11.05.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Nullable<System.DateTime>;

using T_ARG2
 =System.DateTime;

using T_RESULT
 =System.Boolean;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__Equal___NullableDateTime__DateTime

sealed class Op2_Code__Equal___NullableDateTime__DateTime
 :Core.Core_Op2<T_ARG1,T_ARG2,T_RESULT>
{
 public static readonly Op2_Code__Equal___NullableDateTime__DateTime
  Instance
   =new Op2_Code__Equal___NullableDateTime__DateTime();

 //-----------------------------------------------------------------------
 public static readonly System.Reflection.MethodInfo
  MethodInfo_V_V
   =typeof(Op2_Code__Equal___NullableDateTime__DateTime)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private Op2_Code__Equal___NullableDateTime__DateTime()
 {
 }//Op2_Code__Equal___NullableDateTime__DateTime

 //Interface -------------------------------------------------------------
 public void Exec(Core.Core_OperationCtx opCtx,
                  T_ARG1                 a,
                  T_ARG2                 b,
                  out T_RESULT           result)
 {
  Debug.Assert(!Object.ReferenceEquals(opCtx,null));

  result=Exec_V_V(a,b);

  return;
 }//Exec - T_ARG1, T_ARG2

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(!a.HasValue)
   return Op2_MasterResults__Equal.NULL__VALUE;

  Debug.Assert(a.HasValue);

  return MasterCode.Op2_MasterCode__Equal___DateTime__DateTime.Exec
          (a.Value,
           b);
 }//Exec_V_V
};//class Op2_Code__Equal___NullableDateTime__DateTime

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Op2.Code
