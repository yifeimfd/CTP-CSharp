//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRspUserLogin2Field : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspUserLogin2Field(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspUserLogin2Field obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRspUserLogin2Field() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcRspUserLogin2Field(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_LoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_LoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemName {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_SystemName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_SystemName_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxOrderRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_MaxOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_MaxOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string SHFETime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_SHFETime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_SHFETime_get(swigCPtr);
      return ret;
    } 
  }

  public string DCETime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_DCETime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_DCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string CZCETime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_CZCETime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_CZCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string FFEXTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_FFEXTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_FFEXTime_get(swigCPtr);
      return ret;
    } 
  }

  public string INETime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_INETime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_INETime_get(swigCPtr);
      return ret;
    } 
  }

  public string RandomString {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_RandomString_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspUserLogin2Field_RandomString_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspUserLogin2Field() : this(thosttradeapiPINVOKE.new_CThostFtdcRspUserLogin2Field(), true) {
  }

}
