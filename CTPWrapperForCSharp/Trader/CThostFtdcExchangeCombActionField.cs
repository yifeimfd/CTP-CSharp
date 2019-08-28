//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeCombActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeCombActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeCombActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeCombActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcExchangeCombActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char Direction {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public char CombDirection {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_CombDirection_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_CombDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ComTradeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ComTradeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ComTradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeCombActionField() : this(thosttradeapiPINVOKE.new_CThostFtdcExchangeCombActionField(), true) {
  }

}
