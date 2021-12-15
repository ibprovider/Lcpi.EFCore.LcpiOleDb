﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 02.10.2021.
using System;
using System.Diagnostics;
using System.Linq;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code{
////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ETranslator_Op1__Not

sealed partial class FB_Common__Sql_ETranslator_Op1__Not
 :FB_Common__Sql_ETranslator_Op1
{
 public static readonly FB_Common__Sql_ETranslator_Op1
  Instance
   =new FB_Common__Sql_ETranslator_Op1__Not();

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ETranslator_Op1__Not()
 {
 }//FB_Common__Sql_ETranslator_Op1__Not

 //interface FB_Common__Sql_ETranslator_Unary ----------------------------
 public override SqlExpression Translate(in tagOpData opData)
 {
  Debug.Assert(!Object.ReferenceEquals(opData.SqlOperand,null));

  Debug.Assert(opData.OperatorType==LcpiOleDb__ExpressionType.Not);

  //-------------------------------------------------------
  var exprOperand
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping
     (opData.SqlOperand);

  Debug.Assert(!Object.ReferenceEquals(exprOperand,null));

  //-------------------------------------------------------
  var r
   =Nodes.FB_Common__Sql_ENode_Unary__SQL__NOT.Create
     (exprOperand); //throw

  Debug.Assert(!Object.ReferenceEquals(r,null));

  return r;
 }//Translate
};//class FB_Common__Sql_ETranslator_Op1__Not

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code
