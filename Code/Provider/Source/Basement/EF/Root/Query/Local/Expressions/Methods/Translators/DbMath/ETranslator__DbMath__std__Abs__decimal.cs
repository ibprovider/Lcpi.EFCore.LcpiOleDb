﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 26.04.2019.
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
//class ETranslator__DbMath__std__Abs__Decimal

sealed class ETranslator__DbMath__std__Abs__Decimal
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__DbMath__std__Abs__Decimal();

 //-----------------------------------------------------------------------
 private ETranslator__DbMath__std__Abs__Decimal()
  :base(Structure_MethodIdCache.MethodIdOf__DbMath__std__Abs__Decimal)
 {
 }//ETranslator__DbMath__std__Abs__Decimal

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodInfoCache.MethodInfoOf__DbMath__std__Abs__Decimal);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==1);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_Decimal);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg0.Type,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_Decimal);

  //----------------------------------------
  var r
   =Code.Method_Code__Math__Abs__Decimal.CreateCallExpression
     (node_Arg0);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__DbMath__std__Abs__Decimal

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
