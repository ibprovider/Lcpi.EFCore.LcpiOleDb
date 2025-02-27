﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 02.05.2019.
using System;
using System.Diagnostics;
using System.Reflection;
using System.Linq.Expressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//class Method_Code__Math__Sign__NullableSByte

static class Method_Code__Math__Sign__NullableSByte
{
 private static readonly System.Reflection.MethodInfo sm_MethodInfo
  =typeof(Method_Code__Math__Sign__NullableSByte)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static Nullable<Int32> Exec(Nullable<SByte> value)
 {
  if(!value.HasValue)
   return null;

  return Math.Sign(value.Value);
 }//Exec

 //-----------------------------------------------------------------------
 public static MethodCallExpression CreateCallExpression(Expression e)
 {
  Debug.Assert(!Object.ReferenceEquals(e,null));
  Debug.Assert(!Object.ReferenceEquals(e.Type,null));
  Debug.Assert(e.Type==Structure.Structure_TypeCache.TypeOf__System_NullableSByte);

  Debug.Assert(!Object.ReferenceEquals(sm_MethodInfo,null));

  return Expression.Call(sm_MethodInfo,e);
 }//CreateCallExpression

 //-----------------------------------------------------------------------
 public static System.Reflection.MethodInfo GetMethodInfo()
 {
  Debug.Assert(!Object.ReferenceEquals(sm_MethodInfo,null));

  return sm_MethodInfo;
 }//GetMethodInfo
};//class Method_Code__Math__Sign__NullableSByte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code
