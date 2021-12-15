////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 12.12.2020.
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Nodes{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

////////////////////////////////////////////////////////////////////////////////
//class FB_Common__Sql_ENode_Function__SQL__TRUNC

sealed class FB_Common__Sql_ENode_Function__SQL__TRUNC
 :FB_Common__Sql_ENode_Function
 ,Tags.FB_Common__Sql_ETag__ReturnsIntegerNumber
{
 private const ErrSourceID
  c_ErrSrcID
   =ErrSourceID.FB_Common__Sql_ENode_Function__SQL__TRUNC;

 //-----------------------------------------------------------------------
 private const int c_ArgCount=1;

 private const int c_ArgIdx__value=0;

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ENode_Function__SQL__TRUNC
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
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::FB_Common__Sql_ENode_Function__SQL__TRUNC(...) - clone");
#endif

  //----------------------------------------
#if DEBUG
  this.DEBUG__CheckState();
#endif
 }//FB_Common__Sql_ENode_Function__SQL__TRUNC

 //-----------------------------------------------------------------------
 private FB_Common__Sql_ENode_Function__SQL__TRUNC
                                           (SqlExpression         valueExpression,
                                            RelationalTypeMapping resultTypeMapping)
  :this("TRUNC",
        new[]{valueExpression},
        resultTypeMapping.ClrType,
        resultTypeMapping)
 {
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));
  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping,null));
  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping.ClrType,null));

  Debug.Assert(!Object.ReferenceEquals(this.TypeMapping,null));

  //----------------------------------------
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::FB_Common__Sql_ENode_Function__SQL__TRUNC\n"
   +" (valueExpression  : {0},\n"
   +"  resultType       : {1})",
    valueExpression,
    resultTypeMapping.ClrType);
#endif

  //----------------------------------------
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));

#if DEBUG
  this.DEBUG__CheckState();
#endif

  Debug.Assert(Object.ReferenceEquals(this.Arguments[c_ArgIdx__value],valueExpression));
 }//FB_Common__Sql_ENode_Function__SQL__TRUNC

//-----------------------------------------------------------------------
 public static SqlExpression Create(SqlExpression valueExpression)
 {
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));

  if(valueExpression is FB_Common__Sql_ENode_Function__SQL__TRUNC e)
  {
   Debug.Assert(!Object.ReferenceEquals(e.Type,null));

#if DEBUG
   e.DEBUG__CheckState();
#endif

   //if(e.Type.Equals(resultType))
   // return e;

   valueExpression=e.Arguments[c_ArgIdx__value];
  }//if

  //------------------------------------------------------------
  var resultTypeMapping
   =Helper__BuildResultTypeMapping
     (valueExpression); //throw

  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping,null));
  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping.ClrType,null));

  return new FB_Common__Sql_ENode_Function__SQL__TRUNC
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
    ("FB_Common__Sql_ENode_Function__SQL__TRUNC::get_CanReduce - false");
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
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::Accept"
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
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::Accept"
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
   ="FB_Common__Sql_ENode_Function__SQL__TRUNC::VisitChildren";

  //----------------------------------------
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::VisitChildren\n"
   +" ({0})",
    visitor);
#endif

  //----------------------------------------
  Check.Arg_NotNull
   (c_ErrSrcID,
    nameof(VisitChildren),
    nameof(visitor),
    visitor);

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
      nameof(newValueExpression_e),
      newValueExpression_e);

  Debug.Assert(!Object.ReferenceEquals(newValueExpression,null));

  //----------------------------------------
  for(;;)
  {
   if(newValueExpression!=this.Arguments[c_ArgIdx__value])
    break;

   Debug.Assert(this.Arguments.Count==1);

   return this;
  }//for[ever]

  //create new instance

  var resultTypeMapping
   =Helper__BuildResultTypeMapping
     (newValueExpression); //throw

  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping,null));
  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping.ClrType,null));

  return new FB_Common__Sql_ENode_Function__SQL__TRUNC
              (this.Name,
               new[]{newValueExpression},
               resultTypeMapping.ClrType,
               resultTypeMapping);
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

   Debug.Assert(this.Arguments.Count==1);

   return this;
  }//for[ever]

  //create new instance

  var resultTypeMapping
   =Helper__BuildResultTypeMapping
     (arguments[c_ArgIdx__value]); //throw

  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping,null));
  Debug.Assert(!Object.ReferenceEquals(resultTypeMapping.ClrType,null));

  return new FB_Common__Sql_ENode_Function__SQL__TRUNC
              (this.Name,
               arguments,
               resultTypeMapping.ClrType,
               resultTypeMapping);
 }//Update

 //-----------------------------------------------------------------------
 protected override void Print(ExpressionPrinter expressionPrinter)
 {
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::Print(...)");
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
  expressionPrinter.Append("TRUNC(");
  expressionPrinter.Visit(this.Arguments[c_ArgIdx__value]);
  expressionPrinter.Append(")");
 }//Print

 //Helper methods --------------------------------------------------------
 private Expression Helper__Accept__GenerateSql(Sql.FB_Common__QuerySqlGenerator querySqlGenerator)
 {
#if TRACE
  Core.Core_Trace.Method
   ("FB_Common__Sql_ENode_Function__SQL__TRUNC::Helper__Accept__GenerateSql(...)");
#endif

  //------------------------------------------------------------
  Debug.Assert(!Object.ReferenceEquals(querySqlGenerator,null));

#if DEBUG
  this.DEBUG__CheckState();
#endif

  //------------------------------------------------------------
  querySqlGenerator.Sql.Append("TRUNC(");

  querySqlGenerator.Visit(this.Arguments[c_ArgIdx__value]);

  querySqlGenerator.Sql.Append(")");

  return this;
 }//Helper__Accept__GenerateSql

 //-----------------------------------------------------------------------
 private static RelationalTypeMapping Helper__BuildResultTypeMapping
                                           (SqlExpression valueExpression)
 {
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));

  //------------------------------------------------------------
  var valueTypeMapping
   =Helper__GetUnderlyingTypeMapping
     (valueExpression);

  Debug.Assert(!Object.ReferenceEquals(valueTypeMapping,null));
  Debug.Assert(!Object.ReferenceEquals(valueTypeMapping.ClrType,null));

  var valueSqlType
   =valueTypeMapping.ClrType.Extension__UnwrapMappingClrType();

  Debug.Assert(!Object.ReferenceEquals(valueSqlType,null));

  for(;;)
  {
   if(valueSqlType==Structure_TypeCache.TypeOf__System_Int16)
    return FB_Common__TypeMappingCache.TypeMapping__INT16;

   if(valueSqlType==Structure_TypeCache.TypeOf__System_Int32)
    return FB_Common__TypeMappingCache.TypeMapping__INT32;

   if(valueSqlType==Structure_TypeCache.TypeOf__System_Int64)
    return FB_Common__TypeMappingCache.TypeMapping__INT64;

   if(valueSqlType==Structure_TypeCache.TypeOf__System_Single)
    return FB_Common__TypeMappingCache.TypeMapping__DOUBLE;

   if(valueSqlType==Structure_TypeCache.TypeOf__System_Double)
    return FB_Common__TypeMappingCache.TypeMapping__DOUBLE;

   if(valueSqlType==Structure_TypeCache.TypeOf__System_Decimal)
   {
    if(!valueTypeMapping.Precision.HasValue)
    {
     Debug.Assert(!valueTypeMapping.Scale.HasValue);

     //Abstract DECIMAL type. OK, will use it as is.

     return valueTypeMapping;
    }//if

    Debug.Assert(valueTypeMapping.Precision.HasValue);

    if(valueTypeMapping.Scale.GetValueOrDefault(0)==0)
     return valueTypeMapping;

    //rebuild with zero scale
    var resultTypeMapping
     =valueTypeMapping.Clone
       (/*precision*/valueTypeMapping.Precision.Value,
        /*scale*/0);

    Debug.Assert(!Object.ReferenceEquals(resultTypeMapping,null));

    return resultTypeMapping;
   }//if

   break;
  }//for[ever]

  ThrowBugCheck.SqlENode__UnsupportedArgTypes
   (c_ErrSrcID,
    "TRUNC",
    valueExpression);

  return null;
 }//Helper__BuildResultTypeMapping

 //-----------------------------------------------------------------------
 private static RelationalTypeMapping Helper__GetUnderlyingTypeMapping(SqlExpression valueExpression)
 {
  Debug.Assert(!Object.ReferenceEquals(valueExpression,null));
  Debug.Assert(!Object.ReferenceEquals(valueExpression.Type,null));

  //------------------------------------------------------------
  const string c_bugcheck_src
   ="FB_Common__Sql_ENode_Function__SQL__TRUNC::Helper__GetUnderlyingTypeMapping";

  //------------------------------------------------------------
  var typeMapping
   =valueExpression.TypeMapping;

  if(Object.ReferenceEquals(typeMapping,null))
  {
   ThrowBugCheck.No_TypeMapping
    (c_ErrSrcID,
     c_bugcheck_src,
     "#001");
  }//if

  for(;;)
  {
   Debug.Assert(!Object.ReferenceEquals(typeMapping,null));

   var getUnderlyingTypeMapping
    =typeMapping as Root.Storage.LcpiOleDb__IGetUnderlyingTypeMapping;

   if(Object.ReferenceEquals(getUnderlyingTypeMapping,null))
    break;

   var underlyingTypeMapping
    =getUnderlyingTypeMapping.GetUnderlyingTypeMapping();

   if(Object.ReferenceEquals(underlyingTypeMapping,null))
    break;

   /*recursion*/
   typeMapping=underlyingTypeMapping;

   continue;
  }//for[ever]

  Debug.Assert(!Object.ReferenceEquals(typeMapping,null));

  return typeMapping;
 }//Helper__GetUnderlyingTypeMapping

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
};//class FB_Common__Sql_ENode_Function__SQL__TRUNC

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.Common.Query.Sql.Expressions.Nodes
