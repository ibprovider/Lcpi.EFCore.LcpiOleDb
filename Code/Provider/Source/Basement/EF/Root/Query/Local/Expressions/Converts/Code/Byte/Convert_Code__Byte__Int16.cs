﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 04.06.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Byte;

using T_TARGET
 =System.Int16;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__Byte__Int16

static class Convert_Code__Byte__Int16
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__Byte__Int16)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  return MasterCode.Convert_MasterCode__Byte__Int16.Exec
          (v);
 }//Exec
};//class Convert_Code__Byte__Int16

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
