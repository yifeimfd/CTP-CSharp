//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqChangeAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqChangeAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqChangeAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqChangeAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcReqChangeAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string NewBankAccount {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_NewBankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_NewBankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string NewBankPassWord {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_NewBankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_NewBankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqChangeAccountField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqChangeAccountField() : this(thosttradeapiPINVOKE.new_CThostFtdcReqChangeAccountField(), true) {
  }

}
