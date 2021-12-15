﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 15.07.2021.
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
//class ETranslator__NullableDateOnly__vrt__Year

sealed class ETranslator__NullableDateOnly__vrt__Year
 :LcpiOleDb__LocalEval_MemberTranslator
{
 public static readonly LcpiOleDb__LocalEval_MemberTranslator
  Instance
   =new ETranslator__NullableDateOnly__vrt__Year();

 //-----------------------------------------------------------------------
 private ETranslator__NullableDateOnly__vrt__Year()
  :base(Structure_MemberIdCache.MemberIdOf__NullableDateOnly__vrt__Year)
 {
 }//ETranslator__NullableDateOnly__vrt__Year

 //interface -------------------------------------------------------------
 public override Expression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MemberId,null));
  Debug.Assert(!Object.ReferenceEquals(opData.Expression,null));
  Debug.Assert(!Object.ReferenceEquals(opData.Expression.Type,null));

  Debug.Assert(opData.MemberId.MemberName==nameof(DateOnly.Year));
  Debug.Assert(opData.Expression.Type==Structure_TypeCache.TypeOf__System_NullableDateOnly);

#if DEBUG
  Debug.Assert(opData.MemberId==Structure_MemberIdCache.MemberIdOf__NullableDateOnly__vrt__Year);
#endif

  //----------------------------------------
  var node_Object
   =opData.Expression;

  Debug.Assert(!Object.ReferenceEquals(node_Object,null));
  Debug.Assert(node_Object.Type==Structure_TypeCache.TypeOf__System_NullableDateOnly);

  //----------------------------------------
  var result
   =Expression.Call
     (Code.Method_Code__NullableDateOnly__Year.MethodInfo,
      node_Object);

  Debug.Assert(!Object.ReferenceEquals(result,null));

  return result;
 }//Translate
};//class ETranslator__NullableDateOnly__vrt__Year

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Translators
