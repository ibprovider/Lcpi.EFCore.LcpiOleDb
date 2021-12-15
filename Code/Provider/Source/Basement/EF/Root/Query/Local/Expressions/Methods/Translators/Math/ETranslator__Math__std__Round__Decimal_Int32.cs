﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 02.04.2019.
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
//class ETranslator__Math__std__Round__Decimal_Int32

sealed class ETranslator__Math__std__Round__Decimal_Int32
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__Math__std__Round__Decimal_Int32();

 //-----------------------------------------------------------------------
 private ETranslator__Math__std__Round__Decimal_Int32()
  :base(Structure_MethodIdCache.MethodIdOf__Math__std__Round__Decimal_Int32)
 {
 }//ETranslator__Math__std__Round__Decimal_Int32

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodInfoCache.MethodInfoOf__Math__std__Round__Decimal_Int32);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==2);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[1],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_Decimal);
  Debug.Assert(opData.Arguments[1].Type==Structure_TypeCache.TypeOf__System_Int32);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg0.Type,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_Decimal);

  //----------------------------------------
  var node_Arg1
   =opData.Arguments[1];

  Debug.Assert(!Object.ReferenceEquals(node_Arg1,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg1.Type,null));
  Debug.Assert(node_Arg1.Type==Structure_TypeCache.TypeOf__System_Int32);

  //----------------------------------------
  var r
   =Expression.Call
     (Code.Method_Code__Math__Round__Decimal_Int32.MethodInfo,
      node_Arg0,
      node_Arg1);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__Math__std__Round__Decimal_Int32

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
