﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 05.06.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Single;

using T_TARGET
 =System.Byte;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__Single__Byte

static class Convert_Code__Single__Byte
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__Single__Byte)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  return MasterCode.Convert_MasterCode__Single__Byte.Exec
          (v);
 }//Exec
};//class Convert_Code__Single__Byte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
