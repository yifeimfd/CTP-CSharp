//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryParkedOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryParkedOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryParkedOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryParkedOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcQryParkedOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQryParkedOrderActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryParkedOrderActionField() : this(thostmdapiPINVOKE.new_CThostFtdcQryParkedOrderActionField(), true) {
  }

}
