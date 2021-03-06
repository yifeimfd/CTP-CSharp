//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcAccountPropertyField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcAccountPropertyField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcAccountPropertyField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcAccountPropertyField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcAccountPropertyField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenName {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OpenName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OpenName_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenBank {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OpenBank_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OpenBank_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountSourceType {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_AccountSourceType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_AccountSourceType_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_CancelDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_CancelDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OperatorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OperatorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OperatorID_get(swigCPtr);
      return ret;
    } 
  }

  public string OperateDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OperateDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OperateDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OperateTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OperateTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_OperateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcAccountPropertyField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcAccountPropertyField() : this(thosttradeapiPINVOKE.new_CThostFtdcAccountPropertyField(), true) {
  }

}
