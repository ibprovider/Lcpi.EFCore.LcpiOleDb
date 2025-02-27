﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 15.07.2021.
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

using Structure_MethodIdCache
 =Structure.Structure_MethodIdCache;

using Structure_MethodInfoCache
 =Structure.Structure_MethodInfoCache;

////////////////////////////////////////////////////////////////////////////////
//class ETranslator__NullableDateOnly__ext__AddMonths

sealed class ETranslator__NullableDateOnly__ext__AddMonths
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__NullableDateOnly__ext__AddMonths();

 //-----------------------------------------------------------------------
 private ETranslator__NullableDateOnly__ext__AddMonths()
  :base(Structure_MethodIdCache.MethodIdOf__NullableDateOnly__ext__AddMonths)
 {
 }//ETranslator__NullableDateOnly__ext__AddMonths

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodInfoCache.MethodInfoOf__NullableDateOnly__ext__AddMonths);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==2);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[1],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_NullableDateOnly);
  Debug.Assert(opData.Arguments[1].Type==Structure_TypeCache.TypeOf__System_NullableInt32);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_NullableDateOnly);

  //----------------------------------------
  var node_Arg1
   =opData.Arguments[1];

  Debug.Assert(!Object.ReferenceEquals(node_Arg1,null));
  Debug.Assert(node_Arg1.Type==Structure_TypeCache.TypeOf__System_NullableInt32);

  //----------------------------------------
  var r=Expression.Call
         (Code.Method_Code__NullableDateOnly__AddMonths.MethodInfo,
          node_Arg0,
          node_Arg1);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__NullableDateOnly__ext__AddMonths

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
