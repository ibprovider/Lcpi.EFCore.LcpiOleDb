////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 18.07.2021.
using System;
using System.Diagnostics;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_MemberIdCache
 =Structure.Structure_MemberIdCache;

////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ETranslator__TimeOnly__std__Hour

sealed class FB_Common__Sql_ETranslator__TimeOnly__std__Hour
 :FB_Common__Sql_ETranslator_Member
{
 public static readonly FB_Common__Sql_ETranslator_Member.tagDescr
  Instance
   =new FB_Common__Sql_ETranslator_Member.tagDescr
     (Structure_MemberIdCache.MemberIdOf__TimeOnly__std__Hour,
      new FB_Common__Sql_ETranslator__TimeOnly__std__Hour());

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ETranslator__TimeOnly__std__Hour()
 {
 }//FB_Common__Sql_ETranslator__TimeOnly__std__Hour

 //IMemberTranslator interface -------------------------------------------
 public override SqlExpression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.Instance,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlExpressionFactory,null));

#if DEBUG
  opData.DEBUG_CheckMemberId(Structure_MemberIdCache.MemberIdOf__TimeOnly__std__Hour);
#endif

  //------------------------------------------------------------
  var Expression
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Instance);

  Debug.Assert(!Object.ReferenceEquals(Expression,null));
  Debug.Assert(!Object.ReferenceEquals(Expression.Type,null));
  Debug.Assert(!Object.ReferenceEquals(Expression.TypeMapping,null));

  //------------------------------------------------------------
  return Nodes.FB_Common__Sql_ENode_Function__SQL__EXTRACT.Create
          (Expression,
           "HOUR");
 }//Translate
};//class FB_Common__Sql_ETranslator__TimeOnly__std__Hour

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code
