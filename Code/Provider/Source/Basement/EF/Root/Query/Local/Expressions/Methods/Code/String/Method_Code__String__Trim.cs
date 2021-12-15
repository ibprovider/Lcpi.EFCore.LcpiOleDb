﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 27.09.2018.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//class Method_Code__String__Trim

static class Method_Code__String__Trim
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Method_Code__String__Trim)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static String Exec(String obj)
 {
  if(Object.ReferenceEquals(obj,null))
   return null;

  return obj.Trim();
 }//Exec
};//class Method_Code__String__Trim

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code
