//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcForQuoteRspField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcForQuoteRspField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcForQuoteRspField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcForQuoteRspField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcForQuoteRspField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ForQuoteTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ForQuoteTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ActionDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ActionDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcForQuoteRspField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcForQuoteRspField() : this(thosttradeapiPINVOKE.new_CThostFtdcForQuoteRspField(), true) {
  }

}
