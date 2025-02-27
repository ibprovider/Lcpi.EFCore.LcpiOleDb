﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 08.06.2021.
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
//class ETranslator__Int64__vrt__HasFlag__Int64

sealed class ETranslator__Int64__vrt__HasFlag__Int64
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__Int64__vrt__HasFlag__Int64();

 //-----------------------------------------------------------------------
 private ETranslator__Int64__vrt__HasFlag__Int64()
  :base(Structure_MethodIdCache.MethodIdOf__Int64__vrt__HasFlag__Int64)
 {
 }//ETranslator__Int64__vrt__HasFlag__Int64

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodIdCache.MethodIdOf__Int64__vrt__HasFlag__Int64);

  //----------------------------------------
  Debug.Assert(!Object.ReferenceEquals(opData.CallObject,null));
  Debug.Assert(!Object.ReferenceEquals(opData.CallObject.Type,null));

  Debug.Assert(opData.CallObject.Type==Structure_TypeCache.TypeOf__System_Int64);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==1);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0].Type,null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_Int64);

  //----------------------------------------
  var node_Object
   =opData.CallObject;

  Debug.Assert(!Object.ReferenceEquals(node_Object,null));
  Debug.Assert(!Object.ReferenceEquals(node_Object.Type,null));
  Debug.Assert(node_Object.Type==Structure_TypeCache.TypeOf__System_Int64);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg0.Type,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_Int64);

  //----------------------------------------
  var result
   =Expression.Call
     (Code.Method_Code__Int64__HasFlag__Int64.MethodInfo,
      node_Object,
      node_Arg0);

  Debug.Assert(!Object.ReferenceEquals(result,null));

  return result;
 }//Translate
};//class ETranslator__Int64__vrt__HasFlag__Int64

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
