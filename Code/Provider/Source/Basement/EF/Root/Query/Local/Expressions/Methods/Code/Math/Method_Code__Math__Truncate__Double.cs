﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 29.03.2019.
using System;
using System.Diagnostics;
using System.Reflection;
using System.Linq.Expressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//class Method_Code__Math__Truncate__Double

static class Method_Code__Math__Truncate__Double
{
 private static readonly System.Reflection.MethodInfo sm_MethodInfo
  =typeof(Method_Code__Math__Truncate__Double)
    .GetTypeInfo()
    .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static Double Exec(Double value)
 {
  return Math.Truncate(value);
 }//Exec

 //-----------------------------------------------------------------------
 public static MethodCallExpression CreateCallExpression(Expression e)
 {
  Debug.Assert(!Object.ReferenceEquals(e,null));
  Debug.Assert(!Object.ReferenceEquals(e.Type,null));
  Debug.Assert(e.Type==Structure.Structure_TypeCache.TypeOf__System_Double);

  Debug.Assert(!Object.ReferenceEquals(sm_MethodInfo,null));

  if(e is MethodCallExpression x)
  {
   Debug.Assert(!Object.ReferenceEquals(x.Method,null));

   if(Object.ReferenceEquals(x.Method,sm_MethodInfo))
    return x;
  }//if

  return Expression.Call(sm_MethodInfo,e);
 }//CreateCallExpression
};//class Method_Code__Math__Truncate__Double

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code
