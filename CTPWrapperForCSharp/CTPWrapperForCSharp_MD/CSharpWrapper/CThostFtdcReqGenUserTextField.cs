//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqGenUserTextField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqGenUserTextField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqGenUserTextField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqGenUserTextField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcReqGenUserTextField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcReqGenUserTextField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcReqGenUserTextField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcReqGenUserTextField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcReqGenUserTextField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcReqGenUserTextField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcReqGenUserTextField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqGenUserTextField() : this(thostmdapiPINVOKE.new_CThostFtdcReqGenUserTextField(), true) {
  }

}