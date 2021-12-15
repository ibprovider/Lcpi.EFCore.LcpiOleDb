﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 02.06.2021.
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
//class ETranslator__TimeSpan__std__Minutes

sealed class ETranslator__TimeSpan__std__Minutes
 :LcpiOleDb__LocalEval_MemberTranslator
{
 public static readonly LcpiOleDb__LocalEval_MemberTranslator
  Instance
   =new ETranslator__TimeSpan__std__Minutes();

 //-----------------------------------------------------------------------
 private ETranslator__TimeSpan__std__Minutes()
  :base(Structure_MemberIdCache.MemberIdOf__TimeSpan__std__Minutes)
 {
 }//ETranslator__TimeSpan__std__Minutes

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MemberId,null));
  Debug.Assert(!Object.ReferenceEquals(opData.Expression,null));
  Debug.Assert(!Object.ReferenceEquals(opData.Expression.Type,null));

  Debug.Assert(opData.MemberId.MemberName==nameof(TimeSpan.Minutes));
  Debug.Assert(opData.Expression.Type==Structure_TypeCache.TypeOf__System_TimeSpan);

#if DEBUG
  Debug.Assert(opData.MemberId==Structure_MemberIdCache.MemberIdOf__TimeSpan__std__Minutes);
#endif

  //----------------------------------------
  var node_Object
   =opData.Expression;

  Debug.Assert(!Object.ReferenceEquals(node_Object,null));
  Debug.Assert(node_Object.Type==Structure_TypeCache.TypeOf__System_TimeSpan);

  //----------------------------------------
  var result
   =Expression.Call
     (Code.Method_Code__TimeSpan__Minutes.MethodInfo,
      node_Object);

  Debug.Assert(!Object.ReferenceEquals(result,null));

  return result;
 }//Translate
};//class ETranslator__TimeSpan__std__Minutes

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
