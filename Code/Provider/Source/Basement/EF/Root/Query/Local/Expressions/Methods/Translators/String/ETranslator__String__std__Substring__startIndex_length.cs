﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 04.10.2018.
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
//class ETranslator__String__std__Substring__startIndex_length

sealed class ETranslator__String__std__Substring__startIndex_length
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__String__std__Substring__startIndex_length();

 //-----------------------------------------------------------------------
 private ETranslator__String__std__Substring__startIndex_length()
  :base(Structure_MethodIdCache.MethodIdOf__String__std__Substring__from_for)
 {
 }//ETranslator__String__std__Substring__startIndex_length

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodInfoCache.MethodInfoOf__String__std__Substring__from_for);

  //----------------------------------------
  Debug.Assert(!Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==2);

  //----------------------------------------
  var node_Source
   =opData.CallObject;

  Debug.Assert(!Object.ReferenceEquals(node_Source,null));
  Debug.Assert(!Object.ReferenceEquals(node_Source.Type,null));

  Debug.Assert(node_Source.Type==Structure_TypeCache.TypeOf__System_String);

  //----------------------------------------
  var node_From
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_From,null));
  Debug.Assert(!Object.ReferenceEquals(node_From.Type,null));

  Debug.Assert(node_From.Type==Structure_TypeCache.TypeOf__System_Int32);

  //----------------------------------------
  var node_For
   =opData.Arguments[1];

  Debug.Assert(!Object.ReferenceEquals(node_For,null));
  Debug.Assert(!Object.ReferenceEquals(node_For.Type,null));

  Debug.Assert(node_For.Type==Structure_TypeCache.TypeOf__System_Int32);

  //----------------------------------------
  var r
   =Expression.Call
     (Code.Method_Code__String__Substring___startIndex__length.MethodInfo,
      node_Source,
      node_From,
      node_For);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__String__std__Substring__startIndex_length

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
