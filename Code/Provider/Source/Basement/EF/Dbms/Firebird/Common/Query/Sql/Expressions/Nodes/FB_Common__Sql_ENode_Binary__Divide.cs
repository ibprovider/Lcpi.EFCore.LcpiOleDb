﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 03.10.2021.
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Nodes{
////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ENode_Binary__Divide

static class FB_Common__Sql_ENode_Binary__Divide
{
 public static SqlBinaryExpression Create(SqlExpression         left,
                                          SqlExpression         right,
                                          RelationalTypeMapping resultTypeMapping)
 {
  return Helpers.SqlExpressionFactory__STD.CreateBinaryExpression
          (ExpressionType.Divide,
           left,
           right,
           resultTypeMapping); //throw
 }//Create
};//class FB_Common__Sql_ENode_Binary__Divide

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Nodes