//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQueryMaxOrderVolumeWithPriceField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQueryMaxOrderVolumeWithPriceField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQueryMaxOrderVolumeWithPriceField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQueryMaxOrderVolumeWithPriceField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcQueryMaxOrderVolumeWithPriceField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int MaxVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_MaxVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_MaxVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double Price {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Price_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Price_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQueryMaxOrderVolumeWithPriceField() : this(thostmdapiPINVOKE.new_CThostFtdcQueryMaxOrderVolumeWithPriceField(), true) {
  }

}
