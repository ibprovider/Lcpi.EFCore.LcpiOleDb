﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 20.01.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Int32;

using T_TARGET
 =System.Int32;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__Int32__Int32

static class Convert_Code__Int32__Int32
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__Int32__Int32)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  return MasterCode.Convert_MasterCode__Int32__Int32.Exec
          (v);
 }//Exec
};//class Convert_Code__Int32__Int32

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
