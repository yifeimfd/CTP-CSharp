//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryMDTraderOfferField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryMDTraderOfferField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryMDTraderOfferField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryMDTraderOfferField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcQryMDTraderOfferField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryMDTraderOfferField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryMDTraderOfferField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryMDTraderOfferField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryMDTraderOfferField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQryMDTraderOfferField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQryMDTraderOfferField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryMDTraderOfferField() : this(thosttradeapiPINVOKE.new_CThostFtdcQryMDTraderOfferField(), true) {
  }

}
