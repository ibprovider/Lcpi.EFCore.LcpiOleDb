﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 15.11.2018.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//class Method_Code__DateTime__AddHours

static class Method_Code__DateTime__AddHours
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Method_Code__DateTime__AddHours)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static DateTime Exec(DateTime obj,
                              Double   amountValue)
 {
  return MasterCode.Method_MasterCode__DateTime__AddHours.Exec
          (obj,
           amountValue);
 }//Exec
};//class Method_Code__DateTime__AddHours

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Methods.Code
