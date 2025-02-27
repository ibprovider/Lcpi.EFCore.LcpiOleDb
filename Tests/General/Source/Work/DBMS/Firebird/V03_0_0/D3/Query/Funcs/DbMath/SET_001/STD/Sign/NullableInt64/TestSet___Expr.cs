﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 02.05.2019.
//
// DbMath.Sign(<expr>)
//
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdbfunc=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.DbFunctions;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.DbMath.SET_001.STD.Sign.NullableInt64{
////////////////////////////////////////////////////////////////////////////////

using T_DATA=System.Nullable<System.Int64>;

////////////////////////////////////////////////////////////////////////////////
//class TestSet___Expr

public static class TestSet___Expr
{
 private const string c_NameOf__TABLE="TEST_MODIFY_ROW";

 private const string c_NameOf__COL_DATA="COL_BIGINT";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___02___ByEF()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    TestServices.UnsupportedSQL__ExpressionEvaluationNotSupported
     (tr,
      new TestSqlTemplate()
       .T("SELECT ").N("r","TEST_ID").T(", ").N("r",c_NameOf__COL_DATA).EOL()
       .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("r").EOL()
       .T("WHERE (SIGN((").N("r",c_NameOf__COL_DATA).T(" - ").P("__vv_0").T(") + (").N("r",c_NameOf__COL_DATA).T(" / ").P("__vv_0").T(")) = -5) AND (").N("r","TEST_ID").T(" = ").P("__testID_1)")
       .BuildSql(cn));

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___02___ByEF
};//class TestSet___Expr

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.DbMath.SET_001.STD.Sign.NullableInt64
