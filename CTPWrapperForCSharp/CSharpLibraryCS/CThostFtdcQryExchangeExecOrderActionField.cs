//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryExchangeExecOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryExchangeExecOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryExchangeExecOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryExchangeExecOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcQryExchangeExecOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryExchangeExecOrderActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryExchangeExecOrderActionField() : this(thosttradeapiPINVOKE.new_CThostFtdcQryExchangeExecOrderActionField(), true) {
  }

}
