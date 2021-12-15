﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 09.12.2021.
using System;
using System.Diagnostics;

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

using Structure_MethodIdCache
 =Structure.Structure_MethodIdCache;

using Structure_MethodInfoCache
 =Structure.Structure_MethodInfoCache;

using Root.Query.Sql.Extensions.LcpiOleDb__ISqlTreeNodeBuilder__Extensions;

////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ETranslator__String__std__Concat__str4

sealed class FB_Common__Sql_ETranslator__String__std__Concat__str4
 :FB_Common__Sql_ETranslator_MethodCall
{
 public static readonly FB_Common__Sql_ETranslator_MethodCall.tagDescr
  Instance
   =new FB_Common__Sql_ETranslator_MethodCall.tagDescr
     (Structure_MethodIdCache.MethodIdOf__String__std__Concat__str4,
      new FB_Common__Sql_ETranslator__String__std__Concat__str4());

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ETranslator__String__std__Concat__str4()
 {
 }//FB_Common__Sql_ETranslator__String__std__Concat__str4

 //FB_Common__Sql_ETranslator_MethodCall interface -----------------------
 public override SqlExpression Translate(in tagOpData opData)
 {
  Debug.Assert(Object.ReferenceEquals(opData.Instance,null));

  Debug.Assert(!Object.ReferenceEquals(opData.MethodId,null));
  Debug.Assert(opData.MethodId.Equals(Structure_MethodInfoCache.MethodInfoOf__String__std__Concat__str4));

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments,null));
  Debug.Assert(opData.Arguments.Count==4);

  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[0],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[1],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[2],null));
  Debug.Assert(!Object.ReferenceEquals(opData.Arguments[3],null));

  Debug.Assert(!Object.ReferenceEquals(opData.SqlExpressionFactory,null));
  Debug.Assert(!Object.ReferenceEquals(opData.SqlTreeNodeBuilder,null));

  //----------------------------------------
  var exprArg0
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Arguments[0]);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprArg0,
    Structure_TypeCache.TypeOf__System_String);
#endif

  //----------------------------------------
  var exprArg1
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Arguments[1]);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprArg1,
    Structure_TypeCache.TypeOf__System_String);
#endif

  //----------------------------------------
  var exprArg2
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Arguments[2]);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprArg2,
    Structure_TypeCache.TypeOf__System_String);
#endif

  //----------------------------------------
  var exprArg3
   =opData.SqlExpressionFactory.ApplyDefaultTypeMapping(opData.Arguments[3]);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprArg3,
    Structure_TypeCache.TypeOf__System_String);
#endif

  //----------------------------------------
  var exprR1
   =opData.SqlTreeNodeBuilder.Extension__MakeBinary__Concat__Throw
     (exprArg0,
      exprArg1);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprR1,
    Structure_TypeCache.TypeOf__System_String);
#endif

  //----------------------------------------
  var exprR2
   =opData.SqlTreeNodeBuilder.Extension__MakeBinary__Concat__Throw
     (exprR1,
      exprArg2);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprR2,
    Structure_TypeCache.TypeOf__System_String);
#endif

  //----------------------------------------
  var exprR3
   =opData.SqlTreeNodeBuilder.Extension__MakeBinary__Concat__Throw
     (exprR2,
      exprArg3);

#if DEBUG
  Core.SQL.Core_SQL__ExpressionUtils.DEBUG__CheckSqlType__Is_Expected_Or_NULL
   (exprR3,
    Structure_TypeCache.TypeOf__System_String);
#endif

  return exprR3;
 }//Translate
};//class FB_Common__Sql_ETranslator__String__std__Concat__str4

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Translators.Code
