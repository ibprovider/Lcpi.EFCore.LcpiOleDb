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
//class ETranslator__String__std__TrimEnd

sealed class ETranslator__String__std__TrimEnd
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__String__std__TrimEnd();

 //-----------------------------------------------------------------------
 private ETranslator__String__std__TrimEnd()
  :base(Structure_MethodIdCache.MethodIdOf__String__std__TrimEnd)
 {
 }//ETranslator__String__std__TrimEnd

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodInfoCache.MethodInfoOf__String__std__TrimEnd);

  //----------------------------------------
  Debug.Assert(!Object.ReferenceEquals(opData.CallObject,null));
  Debug.Assert(opData.CallObject.Type==Structure_TypeCache.TypeOf__System_String);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==0);

  //----------------------------------------
  var node_Object
   =opData.CallObject;

  Debug.Assert(!Object.ReferenceEquals(node_Object,null));
  Debug.Assert(node_Object.Type==Structure_TypeCache.TypeOf__System_String);

  //----------------------------------------
  var r
   =Expression.Call
     (Code.Method_Code__String__TrimEnd.MethodInfo,
      node_Object);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__String__std__TrimEnd

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
