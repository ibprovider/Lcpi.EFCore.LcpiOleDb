﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB. Core.
//                                      IBProvider and Contributors. 05.09.2018.
using System;
using System.Diagnostics;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Core.Values.Converters{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

////////////////////////////////////////////////////////////////////////////////
//class Core_ValueCvt__DateTime__DateTime

sealed class Core_ValueCvt__DateTime__DateTime
 :Core_ValueCvt<object,object>
{
 public static readonly Core_ValueCvt__DateTime__DateTime
  Instance
   =new Core_ValueCvt__DateTime__DateTime();

 //Core_ValueCvt interface -----------------------------------------------
 public void Exec(Core_ValueCvtCtx context,
                  object           sourceValue,
                  out object       targetValue)
 {
  // [2020-10-17] Tested.

  Debug.Assert(!Object.ReferenceEquals(context,null));
  Debug.Assert(!Object.ReferenceEquals(sourceValue,null));
  Debug.Assert(sourceValue.GetType()==Structure_TypeCache.TypeOf__System_DateTime);

  targetValue=sourceValue;

  Debug.Assert(!Object.ReferenceEquals(targetValue,null));
  Debug.Assert(targetValue.GetType()==Structure_TypeCache.TypeOf__System_DateTime);
 }//Exec
};//class Core_ValueCvt__DateTime__DateTime

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Core.Values.Converters
