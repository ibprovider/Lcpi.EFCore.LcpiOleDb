﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 17.09.2021.
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

using Structure_MemberIdCache
 =Structure.Structure_MemberIdCache;

////////////////////////////////////////////////////////////////////////////////
//class ETranslator__NullableDateTime__vrt__Date

sealed class ETranslator__NullableDateTime__vrt__Date
 :LcpiOleDb__LocalEval_MemberTranslator
{
 public static readonly LcpiOleDb__LocalEval_MemberTranslator
  Instance
   =new ETranslator__NullableDateTime__vrt__Date();

 //-----------------------------------------------------------------------
 private ETranslator__NullableDateTime__vrt__Date()
  :base(Structure_MemberIdCache.MemberIdOf__NullableDateTime__vrt__Date)
 {
 }//ETranslator__NullableDateTime__vrt__Date

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MemberId,null));
  Debug.Assert(!Object.ReferenceEquals(opData.Expression,null));
  Debug.Assert(!Object.ReferenceEquals(opData.Expression.Type,null));

  Debug.Assert(opData.MemberId.MemberName==nameof(DateTime.Date));
  Debug.Assert(opData.Expression.Type==Structure_TypeCache.TypeOf__System_NullableDateTime);

#if DEBUG
  Debug.Assert(opData.MemberId==Structure_MemberIdCache.MemberIdOf__NullableDateTime__vrt__Date);
#endif

  //----------------------------------------
  var node_Object
   =opData.Expression;

  Debug.Assert(!Object.ReferenceEquals(node_Object,null));
  Debug.Assert(node_Object.Type==Structure_TypeCache.TypeOf__System_NullableDateTime);

  //----------------------------------------
  var result
   =Expression.Call
     (Code.Method_Code__NullableDateTime__Date.MethodInfo,
      node_Object);

  Debug.Assert(!Object.ReferenceEquals(result,null));

  return result;
 }//Translate
};//class ETranslator__NullableDateTime__vrt__Date

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
