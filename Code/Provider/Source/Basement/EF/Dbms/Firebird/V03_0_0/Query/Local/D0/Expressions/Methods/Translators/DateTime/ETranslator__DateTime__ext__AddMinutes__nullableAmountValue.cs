﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 17.11.2018.
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Methods.Translators{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

using Structure_MethodIdCache
 =Structure.Structure_MethodIdCache;

using Structure_MethodInfoCache
 =Structure.Structure_MethodInfoCache;

////////////////////////////////////////////////////////////////////////////////
//class ETranslator__DateTime__ext__AddMinutes__nullableAmountValue

sealed class ETranslator__DateTime__ext__AddMinutes__nullableAmountValue
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__DateTime__ext__AddMinutes__nullableAmountValue();

 //-----------------------------------------------------------------------
 private ETranslator__DateTime__ext__AddMinutes__nullableAmountValue()
  :base(Structure_MethodIdCache.MethodIdOf__DateTime__ext__AddMinutes)
 {
 }//ETranslator__DateTime__ext__AddMinutes__nullableAmountValue

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodInfoCache.MethodInfoOf__DateTime__ext__AddMinutes);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==2);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[1],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_DateTime);
  Debug.Assert(opData.Arguments[1].Type==Structure_TypeCache.TypeOf__System_NullableDouble);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_DateTime);

  //----------------------------------------
  var node_Arg1
   =opData.Arguments[1];

  Debug.Assert(!Object.ReferenceEquals(node_Arg1,null));
  Debug.Assert(node_Arg1.Type==Structure_TypeCache.TypeOf__System_NullableDouble);

  //----------------------------------------
  var r=Expression.Call
         (Code.Method_Code__DateTime__AddMinutes__nullableAmountValue.MethodInfo,
          node_Arg0,
          node_Arg1);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__DateTime__ext__AddMinutes__nullableAmountValue

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Methods.Translators
