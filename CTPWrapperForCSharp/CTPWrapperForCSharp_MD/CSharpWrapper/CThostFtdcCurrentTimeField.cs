//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcCurrentTimeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcCurrentTimeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcCurrentTimeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcCurrentTimeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcCurrentTimeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string CurrDate {
    set {
      thostmdapiPINVOKE.CThostFtdcCurrentTimeField_CurrDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcCurrentTimeField_CurrDate_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrTime {
    set {
      thostmdapiPINVOKE.CThostFtdcCurrentTimeField_CurrTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcCurrentTimeField_CurrTime_get(swigCPtr);
      return ret;
    } 
  }

  public int CurrMillisec {
    set {
      thostmdapiPINVOKE.CThostFtdcCurrentTimeField_CurrMillisec_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcCurrentTimeField_CurrMillisec_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDay {
    set {
      thostmdapiPINVOKE.CThostFtdcCurrentTimeField_ActionDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcCurrentTimeField_ActionDay_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCurrentTimeField() : this(thostmdapiPINVOKE.new_CThostFtdcCurrentTimeField(), true) {
  }

}