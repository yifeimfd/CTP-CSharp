//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSecAgentACIDMapField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSecAgentACIDMapField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSecAgentACIDMapField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSecAgentACIDMapField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcSecAgentACIDMapField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerSecAgentID {
    set {
      thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_BrokerSecAgentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSecAgentACIDMapField_BrokerSecAgentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSecAgentACIDMapField() : this(thostmdapiPINVOKE.new_CThostFtdcSecAgentACIDMapField(), true) {
  }

}
