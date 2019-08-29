//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcOpenAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOpenAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOpenAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOpenAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcOpenAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public char CashExchangeCode {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_CashExchangeCode_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_CashExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      thostmdapiPINVOKE.CThostFtdcOpenAccountField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOpenAccountField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOpenAccountField() : this(thostmdapiPINVOKE.new_CThostFtdcOpenAccountField(), true) {
  }

}