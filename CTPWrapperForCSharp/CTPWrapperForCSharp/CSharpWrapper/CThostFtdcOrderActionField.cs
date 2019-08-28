//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int OrderActionRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderActionRef_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeChange {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_VolumeChange_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_VolumeChange_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderActionStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_OrderActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcOrderActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcOrderActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOrderActionField() : this(thosttradeapiPINVOKE.new_CThostFtdcOrderActionField(), true) {
  }

}
