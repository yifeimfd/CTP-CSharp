//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeOrderActionErrorField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeOrderActionErrorField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeOrderActionErrorField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeOrderActionErrorField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcExchangeOrderActionErrorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderActionErrorField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeOrderActionErrorField() : this(thosttradeapiPINVOKE.new_CThostFtdcExchangeOrderActionErrorField(), true) {
  }

}
