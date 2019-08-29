//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqRepealField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqRepealField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqRepealField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqRepealField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcReqRepealField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int RepealTimeInterval {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_RepealTimeInterval_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_RepealTimeInterval_get(swigCPtr);
      return ret;
    } 
  }

  public int RepealedTimes {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_RepealedTimes_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_RepealedTimes_get(swigCPtr);
      return ret;
    } 
  }

  public char BankRepealFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankRepealFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankRepealFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BrokerRepealFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerRepealFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerRepealFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateRepealSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_PlateRepealSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_PlateRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string BankRepealSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankRepealSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureRepealSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_FutureRepealSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_FutureRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmount {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TradeAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double FutureFetchAmount {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_FutureFetchAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_FutureFetchAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char FeePayFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_FeePayFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_FeePayFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public double BrokerFee {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerFee_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerFee_get(swigCPtr);
      return ret;
    } 
  }

  public string Message {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_Message_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_Message_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public char TransferStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_TransferStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_TransferStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqRepealField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqRepealField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqRepealField() : this(thosttradeapiPINVOKE.new_CThostFtdcReqRepealField(), true) {
  }

}
