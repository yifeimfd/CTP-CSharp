//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncingTradingCodeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingTradingCodeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingTradingCodeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingTradingCodeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcSyncingTradingCodeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public char ClientIDType {
    set {
      thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_ClientIDType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcSyncingTradingCodeField_ClientIDType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingTradingCodeField() : this(thosttradeapiPINVOKE.new_CThostFtdcSyncingTradingCodeField(), true) {
  }

}
