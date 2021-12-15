////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 26.05.2021.
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Nodes{
////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ENode_Function__SQL__ASCII_VAL

sealed class FB_Common__Sql_ENode_Function__SQL__ASCII_VAL
 :FB_Common__Sql_ENode_Function
{
 private const ErrSourceID
  c_ErrSrcID
   =ErrSourceID.FB_Common__Sql_ENode_Function__SQL__ASCII_VAL;

 //-----------------------------------------------------------------------
 private const int c_ArgCount=1;

 private const int c_ArgIdx__value=0;

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ENode_Function__SQL__ASCII_VAL
           (System.String              functionName,
            IEnumerable<SqlExpression> arguments,
            System.Type                resultType,
            RelationalTypeMapping      resultTypeMapping)
  :base(functionName,
        arguments,
        Core.SQL.Core_SQL__TestNullable.TestNullable_ANY(arguments),
        sm_argumentsPropagateNullability,
        resultType,
        resultTypeMapping)
 {
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::FB_Common__Sql_ENode_Function__SQL__ASCII_VAL(...) - clone");
#endif

  //----------------------------------------
#if DEBUG
  this.DEBUG__CheckState();
#endif
 }//FB_Common__Sql_ENode_Function__SQL__ASCII_VAL

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ENode_Function__SQL__ASCII_VAL
                                           (SqlExpression         valueExpression,
                                            RelationalTypeMapping resultTypeMapping)
  :this("ASCII_VAL",
        new[]{valueExpression},
        resultTypeMapping.ClrType,
        resultTypeMapping)
 {
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::FB_Common__Sql_ENode_Function__SQL__ASCII_VAL\n"
   +" (valueExpression: {0})",
    valueExpression);
#endif

  //----------------------------------------
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));

#if DEBUG
  this.DEBUG__CheckState();
#endif

  Debug.Assert(Object.ReferenceEquals(this.Arguments[c_ArgIdx__value],valueExpression));
 }//FB_Common__Sql_ENode_Function__SQL__ASCII_VAL

 //-----------------------------------------------------------------------
 public static SqlExpression Create(SqlExpression valueExpression)
 {
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));

  var resultTypeMapping
   =FB_Common__TypeMappingCache.TypeMapping__INT16;

  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping,null));

  return new FB_Common__Sql_ENode_Function__SQL__ASCII_VAL
          (valueExpression,
           resultTypeMapping);
 }//Create

 //Expression interface --------------------------------------------------
 public override bool CanReduce
 {
  get
  {
#if TRACE
   Core.Core_Trace.Method
    ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::get_CanReduce - false");
#endif

   //----------------------------------------
#if DEBUG
   this.DEBUG__CheckState();
#endif

   //----------------------------------------
   return false;
  }//get
 }//CanReduce

 //-----------------------------------------------------------------------
 protected override Expression Accept(ExpressionVisitor visitor)
 {
  Debug.Assert(!Object.ReferenceEquals(visitor,null));

#if TRACE
  Core.Core_Trace.Method_Enter
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::Accept"
   +" (visitorType: {0})",
    visitor.GetType());
#endif

  Expression r;

  if(visitor is Sql.FB_Common__QuerySqlGenerator x)
  {
   r=this.Helper__Accept__GenerateSql(x);
  }
  else
  {
   r=base.Accept(visitor);
  }//else

#if TRACE
  Core.Core_Trace.Method_Exit
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::Accept"
   +" (visitorType: {0}) - {1}",
    visitor.GetType(),
    r?.GetType());
#endif

  return r;
 }//Accept

 //-----------------------------------------------------------------------
 protected override Expression VisitChildren(ExpressionVisitor visitor)
 {
  Debug.Assert(!Object.ReferenceEquals(visitor,null));

  //----------------------------------------
  const string c_bugcheck_src
   ="FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::VisitChildren";

  //----------------------------------------
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::VisitChildren\n"
   +" ({0})",
    visitor);
#endif

  //----------------------------------------
#if DEBUG
  this.DEBUG__CheckState();
#endif

  //----------------------------------------
  Expression newValueExpression_e = visitor.Visit(this.Arguments[c_ArgIdx__value]);

  //----------------------------------------
  var newValueExpression
   =Check.BugCheck_Value_NotNullAndInstanceOf<SqlExpression,Expression>
     (c_ErrSrcID,
      c_bugcheck_src,
      "#001",
      "newValueExpression_e",
      newValueExpression_e);

  Debug.Assert(!Object.ReferenceEquals(newValueExpression,null));

  //----------------------------------------
  for(;;)
  {
   if(newValueExpression!=this.Arguments[c_ArgIdx__value])
    break;

   return this;
  }//for[ever]

  //create new instance

  return new FB_Common__Sql_ENode_Function__SQL__ASCII_VAL
              (this.Name,
               new[]{newValueExpression},
               this.Type,
               this.TypeMapping);
 }//VisitChildren

 //-----------------------------------------------------------------------
 public override SqlFunctionExpression ApplyTypeMapping(RelationalTypeMapping typeMapping)
 {
  //[2020-12-03] Call of this method not expected
  Debug.Assert(false);

#if DEBUG
  this.DEBUG__CheckState();
#endif

  ThrowSysError.method_not_impl
   (c_ErrSrcID,
    nameof(ApplyTypeMapping));

  return null;
 }//ApplyTypeMapping

 //-----------------------------------------------------------------------
 public override SqlFunctionExpression Update(SqlExpression                instance,
                                              IReadOnlyList<SqlExpression> arguments)
 {
  Check.Arg_IsNull
   (c_ErrSrcID,
    nameof(Update),
    nameof(instance),
    instance);

  Check.Arg_NotNull
   (c_ErrSrcID,
    nameof(Update),
    nameof(arguments),
    arguments);

  Check.Arg_ListSize
   (c_ErrSrcID,
    nameof(Update),
    nameof(arguments),
    arguments.Count,
    c_ArgCount);

  Debug.Assert(c_ArgIdx__value==0);

  Check.Arg_NotNull
   (c_ErrSrcID,
    nameof(Update),
    nameof(arguments)+"[0]",
    arguments[c_ArgIdx__value]);

  //------------------------------------------------------------
#if DEBUG
  this.DEBUG__CheckState();
#endif

  //------------------------------------------------------------
  for(;;)
  {
   if(!Object.ReferenceEquals(this.Arguments[c_ArgIdx__value],arguments[c_ArgIdx__value]))
    break;

   return this;
  }//for[ever]

  return new FB_Common__Sql_ENode_Function__SQL__ASCII_VAL
              (this.Name,
               arguments,
               this.Type,
               this.TypeMapping);
 }//Update

 //-----------------------------------------------------------------------
 protected override void Print(ExpressionPrinter expressionPrinter)
 {
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::Print(...)");
#endif

  //------------------------------------------------------------
  Check.Arg_NotNull
   (c_ErrSrcID,
    nameof(Print),
    nameof(expressionPrinter),
    expressionPrinter);

  //------------------------------------------------------------
#if DEBUG
  this.DEBUG__CheckState();
#endif

  //------------------------------------------------------------
  expressionPrinter.Append("ASCII_VAL(");
  expressionPrinter.Visit(this.Arguments[c_ArgIdx__value]);
  expressionPrinter.Append(")");
 }//Print

 //Helper methods --------------------------------------------------------
 private Expression Helper__Accept__GenerateSql(Sql.FB_Common__QuerySqlGenerator querySqlGenerator)
 {
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__ASCII_VAL::Helper__Accept__GenerateSql(...)");
#endif

  //------------------------------------------------------------
  Debug.Assert(!Object.ReferenceEquals(querySqlGenerator,null));

#if DEBUG
  this.DEBUG__CheckState();
#endif

  //------------------------------------------------------------
  querySqlGenerator.Sql.Append("ASCII_VAL(");

  querySqlGenerator.Visit(this.Arguments[c_ArgIdx__value]);

  querySqlGenerator.Sql.Append(")");

  return this;
 }//Helper__Accept__GenerateSql

 //Debug methods ---------------------------------------------------------
#if DEBUG
 private void DEBUG__CheckState()
 {
  Debug.Assert(Object.ReferenceEquals(this.Instance,null));

  Debug.Assert(!Object.ReferenceEquals(this.Arguments,null));

  Debug.Assert(this.Arguments.Count==c_ArgCount);

  Debug.Assert(!Object.ReferenceEquals(this.Arguments[c_ArgIdx__value],null));
 }//DEBUG__CheckState
#endif

 //private data ----------------------------------------------------------
 private static readonly bool[] sm_argumentsPropagateNullability
  =new bool[c_ArgCount]{true};
};//class FB_Common__Sql_ENode_Function__SQL__ASCII_VAL

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Nodes
