//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcErrOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcErrOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcErrOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcErrOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcErrOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int OrderActionRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderActionRef_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeChange {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_VolumeChange_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_VolumeChange_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderActionStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_OrderActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcErrOrderActionField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcErrOrderActionField() : this(thosttradeapiPINVOKE.new_CThostFtdcErrOrderActionField(), true) {
  }

}
