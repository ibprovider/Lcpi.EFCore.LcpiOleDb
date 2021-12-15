﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 27.03.2019.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//class Method_Code__NullableDateTime__Minute

static class Method_Code__NullableDateTime__Minute
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Method_Code__NullableDateTime__Minute)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static Nullable<Int32> Exec(Nullable<DateTime> obj)
 {
  if(!obj.HasValue)
   return null;

  return obj.Value.Minute;
 }//Exec
};//class Method_Code__NullableDateTime__Minute

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code
