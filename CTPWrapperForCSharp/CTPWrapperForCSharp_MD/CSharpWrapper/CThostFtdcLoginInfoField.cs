//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcLoginInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLoginInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLoginInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcLoginInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcLoginInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int FrontID {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginDate {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_LoginDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_LoginDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginTime {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_LoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_LoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string InterfaceProductInfo {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_InterfaceProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_InterfaceProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ProtocolInfo {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_ProtocolInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_ProtocolInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemName {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_SystemName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_SystemName_get(swigCPtr);
      return ret;
    } 
  }

  public string PasswordDeprecated {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_PasswordDeprecated_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_PasswordDeprecated_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxOrderRef {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_MaxOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_MaxOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string SHFETime {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_SHFETime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_SHFETime_get(swigCPtr);
      return ret;
    } 
  }

  public string DCETime {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_DCETime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_DCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string CZCETime {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_CZCETime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_CZCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string FFEXTime {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_FFEXTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_FFEXTime_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string OneTimePassword {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_OneTimePassword_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_OneTimePassword_get(swigCPtr);
      return ret;
    } 
  }

  public string INETime {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_INETime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_INETime_get(swigCPtr);
      return ret;
    } 
  }

  public int IsQryControl {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_IsQryControl_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_IsQryControl_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginRemark {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_LoginRemark_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_LoginRemark_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thostmdapiPINVOKE.CThostFtdcLoginInfoField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcLoginInfoField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLoginInfoField() : this(thostmdapiPINVOKE.new_CThostFtdcLoginInfoField(), true) {
  }

}
