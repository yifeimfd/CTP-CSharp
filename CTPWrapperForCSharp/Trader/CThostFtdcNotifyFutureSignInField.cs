//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcNotifyFutureSignInField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcNotifyFutureSignInField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcNotifyFutureSignInField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcNotifyFutureSignInField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcNotifyFutureSignInField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string PinKey {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_PinKey_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_PinKey_get(swigCPtr);
      return ret;
    } 
  }

  public string MacKey {
    set {
      thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_MacKey_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcNotifyFutureSignInField_MacKey_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcNotifyFutureSignInField() : this(thosttradeapiPINVOKE.new_CThostFtdcNotifyFutureSignInField(), true) {
  }

}
