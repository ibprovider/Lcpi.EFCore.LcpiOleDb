﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 24.04.2019.
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

////////////////////////////////////////////////////////////////////////////////
//class ETranslator__Math__vrt__Ceiling__NullableDecimal

sealed class ETranslator__Math__vrt__Ceiling__NullableDecimal
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__Math__vrt__Ceiling__NullableDecimal();

 //-----------------------------------------------------------------------
 private ETranslator__Math__vrt__Ceiling__NullableDecimal()
  :base(Structure_MethodIdCache.MethodIdOf__Math__vrt__Ceiling__NullableDecimal)
 {
 }//ETranslator__Math__vrt__Ceiling__NullableDecimal

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodIdCache.MethodIdOf__Math__vrt__Ceiling__NullableDecimal);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==1);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_NullableDecimal);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg0.Type,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_NullableDecimal);

  //----------------------------------------
  var r
   =Code.Method_Code__Math__Ceiling__NullableDecimal.CreateCallExpression
     (node_Arg0);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__Math__vrt__Ceiling__NullableDecimal

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
