﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 15.11.2018.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//class Method_Code__NullableDateTime__AddHours

static class Method_Code__NullableDateTime__AddHours
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Method_Code__NullableDateTime__AddHours)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static Nullable<DateTime> Exec(Nullable<DateTime> obj,
                                        Nullable<Double>   amountValue)
 {
  if(!obj.HasValue)
   return null;

  Debug.Assert(obj.HasValue);

  if(!amountValue.HasValue)
   return null;

  Debug.Assert(amountValue.HasValue);

  return MasterCode.Method_MasterCode__DateTime__AddHours.Exec
          (obj.Value,
           amountValue.Value);
 }//Exec
};//class Method_Code__NullableDateTime__AddHours

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D0.Expressions.Methods.Code
