//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcInputQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteRef {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_QuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_QuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderRef {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_AskOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderRef {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_BidOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputQuoteField() : this(thostmdapiPINVOKE.new_CThostFtdcInputQuoteField(), true) {
  }

}
