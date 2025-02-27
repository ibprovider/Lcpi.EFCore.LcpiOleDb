﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 26.11.2020.
using System;
using System.Diagnostics;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ETranslator_Op2__AndAlso

sealed class FB_Common__Sql_ETranslator_Op2__AndAlso
 :FB_Common__Sql_ETranslator_Op2
{
 public static readonly FB_Common__Sql_ETranslator_Op2
  Instance
   =new FB_Common__Sql_ETranslator_Op2__AndAlso();

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ETranslator_Op2__AndAlso()
 {
 }//FB_Common__Sql_ETranslator_Op2__AndAlso

 //FB_Common__Sql_ETranslator_Op2 interface ------------------------------
 public override SqlExpression Translate(in tagOpData opData)
 {
#if DEBUG
  if(opData.OperationType==LcpiOleDb__ExpressionType.AndAlso)
  {
   //OK
  }
  else
  if(opData.OperationType==LcpiOleDb__ExpressionType.And)
  {
   //OK. Types we check later.
  }
  else
  {
   Debug.Assert(false);
  }//else
#endif //DEBUG

  Debug.Assert(!Object.ReferenceEquals(opData.SqlLeft,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlRight,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlResultTypeMapping,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlExpressionFactory,null));

  Debug.Assert(!Object.ReferenceEquals(opData.SqlLeft.Type,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlRight.Type,null));

  //------------------------------------------------------------

  //
  // [2021-01-03] No idea how to send here the arguments without TypeMapping.
  //

  //------------------------------------------------------------
#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlTypeMapping__IsExpected
   (opData.SqlLeft,
    Structure_TypeCache.TypeOf__System_Boolean);

  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlTypeMapping__IsExpected
   (opData.SqlRight,
    Structure_TypeCache.TypeOf__System_Boolean);
#endif

  //------------------------------------------------------------
  var r
   =Nodes.FB_Common__Sql_ENode_Binary__AndAlso.Create
     (opData.SqlLeft,
      opData.SqlRight,
      opData.SqlResultTypeMapping);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlTypeMapping__IsExpected
   (r,
    opData.SqlResultTypeMapping);
#endif

  return r;
 }//Translate
};//class FB_Common__Sql_ETranslator_Op2__AndAlso

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code
