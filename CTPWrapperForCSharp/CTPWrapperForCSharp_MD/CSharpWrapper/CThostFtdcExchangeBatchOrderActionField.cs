//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeBatchOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeBatchOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeBatchOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeBatchOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcExchangeBatchOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDate {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ActionDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ActionDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionTime {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ActionTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ActionTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderActionStatus {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_OrderActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_OrderActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeBatchOrderActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeBatchOrderActionField() : this(thostmdapiPINVOKE.new_CThostFtdcExchangeBatchOrderActionField(), true) {
  }

}