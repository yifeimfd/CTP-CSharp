//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcManualSyncBrokerUserOTPField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcManualSyncBrokerUserOTPField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcManualSyncBrokerUserOTPField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcManualSyncBrokerUserOTPField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcManualSyncBrokerUserOTPField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OTPType {
    set {
      thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_OTPType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_OTPType_get(swigCPtr);
      return ret;
    } 
  }

  public string FirstOTP {
    set {
      thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_FirstOTP_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_FirstOTP_get(swigCPtr);
      return ret;
    } 
  }

  public string SecondOTP {
    set {
      thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_SecondOTP_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_SecondOTP_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcManualSyncBrokerUserOTPField() : this(thosttradeapiPINVOKE.new_CThostFtdcManualSyncBrokerUserOTPField(), true) {
  }

}
