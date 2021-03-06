//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcExchangeQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double AskPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_QuoteLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_QuoteLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char QuoteStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_QuoteStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_QuoteStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_AskOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BidOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeQuoteField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeQuoteField() : this(thosttradeapiPINVOKE.new_CThostFtdcExchangeQuoteField(), true) {
  }

}
