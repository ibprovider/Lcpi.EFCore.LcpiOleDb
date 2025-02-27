﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 27.04.2019.
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
//class ETranslator__Math__vrt__Abs__NullableSByte

sealed class ETranslator__Math__vrt__Abs__NullableSByte
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__Math__vrt__Abs__NullableSByte();

 //-----------------------------------------------------------------------
 private ETranslator__Math__vrt__Abs__NullableSByte()
  :base(Structure_MethodIdCache.MethodIdOf__Math__vrt__Abs__NullableSByte)
 {
 }//ETranslator__Math__vrt__Abs__NullableSByte

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodIdCache.MethodIdOf__Math__vrt__Abs__NullableSByte);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==1);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_NullableSByte);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg0.Type,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_NullableSByte);

  //----------------------------------------
  var r
   =Code.Method_Code__Math__Abs__NullableSByte.CreateCallExpression
     (node_Arg0);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__Math__vrt__Abs__NullableSByte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
