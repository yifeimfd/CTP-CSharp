//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcLogoutAllField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLogoutAllField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLogoutAllField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcLogoutAllField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcLogoutAllField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int FrontID {
    set {
      thostmdapiPINVOKE.CThostFtdcLogoutAllField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcLogoutAllField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcLogoutAllField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcLogoutAllField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemName {
    set {
      thostmdapiPINVOKE.CThostFtdcLogoutAllField_SystemName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLogoutAllField_SystemName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLogoutAllField() : this(thostmdapiPINVOKE.new_CThostFtdcLogoutAllField(), true) {
  }

}