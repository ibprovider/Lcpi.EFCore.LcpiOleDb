////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 04.06.2021.
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.EnumInt32.SET002.STD.HasFlag.Int64{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1  =TestEnum001;
using T_DATA2  =System.Int64;

using T_DATA1_U=TestEnum001;
using T_DATA2_U=System.Int64;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_001__field__01__VV

public static class TestSet_001__field__01__VV
{
 private const string c_NameOf__TABLE      ="TEST_MODIFY_ROW2";

 private const string c_NameOf__COL_DATA1  ="COL_INTEGER";
 private const string c_NameOf__COL_DATA2  ="COL2_BIGINT";

 //-----------------------------------------------------------------------
 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_DATA1)]
   public T_DATA1 COL_DATA1 { get; set; }

   [Column(c_NameOf__COL_DATA2)]
   public T_DATA2 COL_DATA2 { get; set; }
  };//class TEST_RECORD

  //----------------------------------------------------------------------
  public DbSet<TEST_RECORD> testTable { get; set; }

  //----------------------------------------------------------------------
  public MyContext(xdb.OleDbTransaction tr)
   :base(tr)
  {
  }//MyContext
 };//class MyContext

 //-----------------------------------------------------------------------
 private static xdb.OleDbConnection Helper__CreateCn()
 {
  return LocalCnHelper.CreateCn();
 }//Helper__CreateCn

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0000___field__field()
 {
  using(var cn=Helper__CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1_U c_value1=TestEnum001.Flag1|TestEnum001.Flag2;
     const T_DATA2_U c_value2=0;

     Assert.IsTrue
      (c_value1.HasFlag((TestEnum001)c_value2));

     System.Int64 testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => r.TEST_ID==testID && r.COL_DATA1.HasFlag((TestEnum001)(object)r.COL_DATA2));

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(") AND (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", ").N_AS_INT("t",c_NameOf__COL_DATA2).T(") = ").N_AS_INT("t",c_NameOf__COL_DATA2).T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_0000___field__field

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_A001___field__field()
 {
  using(var cn=Helper__CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1_U c_value1=TestEnum001.Flag1|TestEnum001.Flag2;
     const T_DATA2_U c_value2=(T_DATA2_U)(TestEnum001.Flag1|TestEnum001.Flag2);

     Assert.IsTrue
      (c_value1.HasFlag((TestEnum001)c_value2));

     System.Int64 testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => r.TEST_ID==testID && r.COL_DATA1.HasFlag((TestEnum001)(object)r.COL_DATA2));

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(") AND (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", ").N_AS_INT("t",c_NameOf__COL_DATA2).T(") = ").N_AS_INT("t",c_NameOf__COL_DATA2).T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_A001___field__field

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_A002___field__const()
 {
  using(var cn=Helper__CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1_U c_value1=TestEnum001.Flag1|TestEnum001.Flag2;
     const T_DATA2_U c_value2=(T_DATA2_U)(TestEnum001.Flag1|TestEnum001.Flag2);

     Assert.IsTrue
      (c_value1.HasFlag((TestEnum001)c_value2));

     System.Int64 testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => r.TEST_ID==testID && r.COL_DATA1.HasFlag((TestEnum001)(object)c_value2));

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(") AND (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", 3) = 3)"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_A002___field__const

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_A003___field__const2()
 {
  using(var cn=Helper__CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1_U c_value1=TestEnum001.Flag1|TestEnum001.Flag2;
     const T_DATA2_U c_value2=(T_DATA2_U)(TestEnum001.Flag1|TestEnum001.Flag2);

     Assert.IsTrue
      (c_value1.HasFlag((TestEnum001)c_value2));

     System.Int64 testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => r.TEST_ID==testID && r.COL_DATA1.HasFlag((TestEnum001)(object)(T_DATA2)(TestEnum001.Flag1|TestEnum001.Flag2)));

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(") AND (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", 3) = 3)"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_A003___field__const

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_B001___field__field()
 {
  using(var cn=Helper__CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1_U c_value1=TestEnum001.Flag1|TestEnum001.Flag2;
     const T_DATA2_U c_value2=(T_DATA2_U)(TestEnum001.Flag2|TestEnum001.Flag3);

     Assert.IsTrue
      (!c_value1.HasFlag((TestEnum001)c_value2));

     System.Int64 testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => r.TEST_ID==testID && r.COL_DATA1.HasFlag((TestEnum001)(object)r.COL_DATA2));

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(") AND (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", ").N_AS_INT("t",c_NameOf__COL_DATA2).T(") = ").N_AS_INT("t",c_NameOf__COL_DATA2).T(")"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_B001___field__field

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_B002___field__const()
 {
  using(var cn=Helper__CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1_U c_value1=TestEnum001.Flag1|TestEnum001.Flag2;
     const T_DATA2_U c_value2=(T_DATA2_U)(TestEnum001.Flag2|TestEnum001.Flag3);

     Assert.IsTrue
      (!c_value1.HasFlag((TestEnum001)c_value2));

     System.Int64 testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => r.TEST_ID==testID && r.COL_DATA1.HasFlag((TestEnum001)(object)c_value2));

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(") AND (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", 6) = 6)"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_B002___field__const

 //-----------------------------------------------------------------------
 private static System.Int64 Helper__InsertRow(MyContext db,
                                               T_DATA1   valueOfColData1,
                                               T_DATA2   valueOfColData2)
 {
  var newRecord=new MyContext.TEST_RECORD();

  newRecord.COL_DATA1=valueOfColData1;
  newRecord.COL_DATA2=valueOfColData2;

  db.testTable.Add(newRecord);

  db.SaveChanges();

  db.CheckTextOfLastExecutedCommand
   (new TestSqlTemplate()
     .T("INSERT INTO ").N(c_NameOf__TABLE).T(" (").N(c_NameOf__COL_DATA1).T(", ").N(c_NameOf__COL_DATA2).T(")").EOL()
     .T("VALUES (").P("p0").T(", ").P("p1").T(")").EOL()
     .T("RETURNING ").N("TEST_ID").EOL()
     .T("INTO ").P("p2").T(";"));

  Assert.IsTrue
   (newRecord.TEST_ID.HasValue);

  Console.WriteLine("TEST_ID: {0}",newRecord.TEST_ID.Value);

  return newRecord.TEST_ID.Value;
 }//Helper__InsertRow
};//class TestSet_001__field__01__VV

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.EnumInt32.SET002.STD.HasFlag.Int64
