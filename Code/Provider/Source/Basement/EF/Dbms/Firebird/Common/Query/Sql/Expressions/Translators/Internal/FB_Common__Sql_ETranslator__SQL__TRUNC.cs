﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 12.12.2020.
using System;
using System.Diagnostics;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Internal{
////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ETranslator__SQL__TRUNC

sealed class FB_Common__Sql_ETranslator__SQL__TRUNC
 :FB_Common__Sql_ETranslator_MethodCall
{
 public static readonly FB_Common__Sql_ETranslator_MethodCall
  Instance
   =new FB_Common__Sql_ETranslator__SQL__TRUNC();

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ETranslator__SQL__TRUNC()
 {
 }//FB_Common__Sql_ETranslator__SQL__TRUNC

 //FB_Common__Sql_ETranslator_MethodCall interface -----------------------
 public override SqlExpression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlExpressionFactory,null));

  //----------------------------------------
  Debug.Assert(Object.ReferenceEquals(opData.Instance,null));

  //----------------------------------------
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==1);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0].Type,null));

  //----------------------------------------
  var exprArg0
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Arguments[0]);

  Debug.Assert(!Object.ReferenceEquals(exprArg0,null));
  Debug.Assert(!Object.ReferenceEquals(exprArg0.Type,null));
  Debug.Assert(!Object.ReferenceEquals(exprArg0.TypeMapping,null));

  //----------------------------------------
  return Nodes.FB_Common__Sql_ENode_Function__SQL__TRUNC.Create
          (exprArg0);
 }//Translate
};//class FB_Common__Sql_ETranslator__SQL__TRUNC

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Internal
