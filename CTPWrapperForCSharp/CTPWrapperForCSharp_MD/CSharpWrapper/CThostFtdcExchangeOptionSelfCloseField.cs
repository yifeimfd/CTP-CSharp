//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeOptionSelfCloseField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeOptionSelfCloseField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeOptionSelfCloseField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeOptionSelfCloseField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcExchangeOptionSelfCloseField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int Volume {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char OptSelfCloseFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OptSelfCloseFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OptSelfCloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseLocalID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OptionSelfCloseLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OptionSelfCloseLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OptionSelfCloseSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_OptionSelfCloseSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char ExecResult {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ExecResult_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ExecResult_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcExchangeOptionSelfCloseField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeOptionSelfCloseField() : this(thostmdapiPINVOKE.new_CThostFtdcExchangeOptionSelfCloseField(), true) {
  }

}
