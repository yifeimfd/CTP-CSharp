//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRspQueryTradeResultBySerialField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspQueryTradeResultBySerialField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspQueryTradeResultBySerialField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRspQueryTradeResultBySerialField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcRspQueryTradeResultBySerialField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public int Reference {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_Reference_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_Reference_get(swigCPtr);
      return ret;
    } 
  }

  public char RefrenceIssureType {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_RefrenceIssureType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_RefrenceIssureType_get(swigCPtr);
      return ret;
    } 
  }

  public string RefrenceIssure {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_RefrenceIssure_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_RefrenceIssure_get(swigCPtr);
      return ret;
    } 
  }

  public string OriginReturnCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_OriginReturnCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_OriginReturnCode_get(swigCPtr);
      return ret;
    } 
  }

  public string OriginDescrInfoForReturnCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_OriginDescrInfoForReturnCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_OriginDescrInfoForReturnCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmount {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_TradeAmount_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRspQueryTradeResultBySerialField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspQueryTradeResultBySerialField() : this(thosttradeapiPINVOKE.new_CThostFtdcRspQueryTradeResultBySerialField(), true) {
  }

}
