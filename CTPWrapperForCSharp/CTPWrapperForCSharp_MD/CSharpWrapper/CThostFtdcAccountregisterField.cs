//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcAccountregisterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcAccountregisterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcAccountregisterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcAccountregisterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcAccountregisterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeDay {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_TradeDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_TradeDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenOrDestroy {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_OpenOrDestroy_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_OpenOrDestroy_get(swigCPtr);
      return ret;
    } 
  }

  public string RegDate {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_RegDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_RegDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OutDate {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_OutDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_OutDate_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      thostmdapiPINVOKE.CThostFtdcAccountregisterField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcAccountregisterField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcAccountregisterField() : this(thostmdapiPINVOKE.new_CThostFtdcAccountregisterField(), true) {
  }

}
