﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB. Core.
//                                      IBProvider and Contributors. 07.10.2021.
using System;
using System.Diagnostics;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Core.Values.Converters{
////////////////////////////////////////////////////////////////////////////////
//using

using Structure_TypeCache
 =Structure.Structure_TypeCache;

////////////////////////////////////////////////////////////////////////////////
//class Core_ValueCvt__Guid__Array1_Byte

sealed class Core_ValueCvt__Guid__Array1_Byte
 :Core_ValueCvt<object,object>
{
 public static readonly Core_ValueCvt__Guid__Array1_Byte
  Instance
   =new Core_ValueCvt__Guid__Array1_Byte();

 //Core_ValueCvt interface -----------------------------------------------
 public void Exec(Core_ValueCvtCtx context,
                  object           sourceValue,
                  out object       targetValue)
 {
  Debug.Assert(!Object.ReferenceEquals(context,null));
  Debug.Assert(!Object.ReferenceEquals(sourceValue,null));
  Debug.Assert(sourceValue.GetType()==Structure_TypeCache.TypeOf__System_Guid);

  System.Guid typedSourceValue=(System.Guid)sourceValue;

  targetValue=typedSourceValue.ToByteArray();

  Debug.Assert(!Object.ReferenceEquals(targetValue,null));
  Debug.Assert(targetValue.GetType()==Structure_TypeCache.TypeOf__System_Array_Byte);
 }//Exec
};//class Core_ValueCvt__Guid__Array1_Byte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Core.Values.Converters
