////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 26.03.2019.
using System;
using System.Diagnostics;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_MemberIdCache
 =Structure.Structure_MemberIdCache;

////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ETranslator__DateTime__std__DayOfWeek

sealed class FB_Common__Sql_ETranslator__DateTime__std__DayOfWeek
 :FB_Common__Sql_ETranslator_Member
{
 public static readonly FB_Common__Sql_ETranslator_Member.tagDescr
  Instance
   =new FB_Common__Sql_ETranslator_Member.tagDescr
     (Structure_MemberIdCache.MemberIdOf__DateTime__std__DayOfWeek,
      new FB_Common__Sql_ETranslator__DateTime__std__DayOfWeek());

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ETranslator__DateTime__std__DayOfWeek()
 {
 }//FB_Common__Sql_ETranslator__DateTime__std__DayOfWeek

 //IMemberTranslator interface -------------------------------------------
 public override SqlExpression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.Instance,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlExpressionFactory,null));

#if DEBUG
  opData.DEBUG_CheckMemberId(Structure_MemberIdCache.MemberIdOf__DateTime__std__DayOfWeek);
#endif

  //------------------------------------------------------------
  var Expression
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Instance);

  Debug.Assert(!Object.ReferenceEquals(Expression,null));
  Debug.Assert(!Object.ReferenceEquals(Expression.Type,null));
  Debug.Assert(!Object.ReferenceEquals(Expression.TypeMapping,null));

  //------------------------------------------------------------
  return Nodes.FB_Common__Sql_ENode_Function__SQL__EXTRACT.Create__DayOfWeek
          (Expression);
 }//Translate
};//class FB_Common__Sql_ETranslator__DateTime__std__DayOfWeek

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code
