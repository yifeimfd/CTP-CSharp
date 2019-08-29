//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteRef {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteLocalID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQuoteField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char QuoteStatus {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcQuoteField_QuoteStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AskOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AskOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BidOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BidOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerQuoteSeq {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BrokerQuoteSeq_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BrokerQuoteSeq_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderRef {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AskOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AskOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderRef {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BidOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BidOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcQuoteField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcQuoteField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQuoteField() : this(thostmdapiPINVOKE.new_CThostFtdcQuoteField(), true) {
  }

}
