﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 11.04.2019.
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
//class ETranslator__Math__vrt__Round__NullableDouble_NullableInt32

sealed class ETranslator__Math__vrt__Round__NullableDouble_NullableInt32
 :Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
{
 public static readonly Root.Query.Local.LcpiOleDb__LocalEval_MethodCallTranslator
  Instance
   =new ETranslator__Math__vrt__Round__NullableDouble_NullableInt32();

 //-----------------------------------------------------------------------
 private ETranslator__Math__vrt__Round__NullableDouble_NullableInt32()
  :base(Structure_MethodIdCache.MethodIdOf__Math__vrt__Round__NullableDouble_NullableInt32)
 {
 }//ETranslator__Math__vrt__Round__NullableDouble_NullableInt32

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));

  Debug.Assert(opData.MethodId==Structure_MethodIdCache.MethodIdOf__Math__vrt__Round__NullableDouble_NullableInt32);

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.CallObject,null));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==2);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[1],null));

  Debug.Assert(opData.Arguments[0].Type==Structure_TypeCache.TypeOf__System_NullableDouble);
  Debug.Assert(opData.Arguments[1].Type==Structure_TypeCache.TypeOf__System_NullableInt32);

  //----------------------------------------
  var node_Arg0
   =opData.Arguments[0];

  Debug.Assert(!Object.ReferenceEquals(node_Arg0,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg0.Type,null));
  Debug.Assert(node_Arg0.Type==Structure_TypeCache.TypeOf__System_NullableDouble);

  //----------------------------------------
  var node_Arg1
   =opData.Arguments[1];

  Debug.Assert(!Object.ReferenceEquals(node_Arg1,null));
  Debug.Assert(!Object.ReferenceEquals(node_Arg1.Type,null));
  Debug.Assert(node_Arg1.Type==Structure_TypeCache.TypeOf__System_NullableInt32);

  //----------------------------------------
  var r
   =Expression.Call
     (Code.Method_Code__Math__Round__NullableDouble_NullableInt32.MethodInfo,
      node_Arg0,
      node_Arg1);

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class ETranslator__Math__vrt__Round__NullableDouble_NullableInt32

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
