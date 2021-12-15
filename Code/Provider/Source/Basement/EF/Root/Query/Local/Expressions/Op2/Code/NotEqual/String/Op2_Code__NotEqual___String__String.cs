﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 26.09.2018.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.String;

using T_ARG2
 =System.String;

using T_RESULT
 =System.Boolean;

////////////////////////////////////////////////////////////////////////////////
//class Op2_Code__NotEqual___String__String

sealed class Op2_Code__NotEqual___String__String
 :Core.Core_Op2<object,object,T_RESULT>
{
 public static readonly Op2_Code__NotEqual___String__String
  Instance
   =new Op2_Code__NotEqual___String__String();

 //-----------------------------------------------------------------------
 public static readonly System.Reflection.MethodInfo
  MethodInfo_V_V
   =typeof(Op2_Code__NotEqual___String__String)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec_V_V));

 //-----------------------------------------------------------------------
 private Op2_Code__NotEqual___String__String()
 {
 }//Op2_Code__NotEqual___String__String

 //Interface -------------------------------------------------------------
 public void Exec(Core.Core_OperationCtx opCtx,
                  object                 a,
                  object                 b,
                  out T_RESULT           result)
 {
  Debug.Assert(!Object.ReferenceEquals(opCtx,null));

#if DEBUG
  if(!Object.ReferenceEquals(a,null))
   Debug.Assert(System.Type.GetTypeCode(a.GetType())==System.Type.GetTypeCode(typeof(T_ARG1)));

  if(!Object.ReferenceEquals(b,null))
   Debug.Assert(System.Type.GetTypeCode(b.GetType())==System.Type.GetTypeCode(typeof(T_ARG2)));
#endif

  var a_t=(T_ARG1) a;
  var b_t=(T_ARG2) b;

  result=Exec_V_V(a_t,b_t);

  return;
 }//Exec - object, object

 //-----------------------------------------------------------------------
 private static T_RESULT Exec_V_V(T_ARG1 a,T_ARG2 b)
 {
  if(Object.ReferenceEquals(a,null))
  {
   if(Object.ReferenceEquals(b,null))
    return Op2_MasterResults__NotEqual.NULL__NULL;

   return Op2_MasterResults__NotEqual.NULL__VALUE;
  }//if

  Debug.Assert(!Object.ReferenceEquals(a,null));

  if(Object.ReferenceEquals(b,null))
  {
   return Op2_MasterResults__NotEqual.VALUE__NULL;
  }//if

  Debug.Assert(!Object.ReferenceEquals(b,null));

  //----------------------------------------
  return MasterCode.Op2_MasterCode__NotEqual___String__String.Exec
          (a,
           b);
 }//Exec_V_V
};//class Op2_Code__NotEqual___String__String

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.Code
