//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqUserLoginWithOTPField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqUserLoginWithOTPField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqUserLoginWithOTPField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqUserLoginWithOTPField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcReqUserLoginWithOTPField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string InterfaceProductInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_InterfaceProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_InterfaceProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ProtocolInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_ProtocolInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_ProtocolInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientIPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_ClientIPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_ClientIPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginRemark {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_LoginRemark_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_LoginRemark_get(swigCPtr);
      return ret;
    } 
  }

  public string OTPPassword {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_OTPPassword_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_OTPPassword_get(swigCPtr);
      return ret;
    } 
  }

  public int ClientIPPort {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_ClientIPPort_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithOTPField_ClientIPPort_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqUserLoginWithOTPField() : this(thosttradeapiPINVOKE.new_CThostFtdcReqUserLoginWithOTPField(), true) {
  }

}
