//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTransferBankField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferBankField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferBankField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferBankField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcTransferBankField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcTransferBankField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTransferBankField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBrchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcTransferBankField_BankBrchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTransferBankField_BankBrchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankName {
    set {
      thosttradeapiPINVOKE.CThostFtdcTransferBankField_BankName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTransferBankField_BankName_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      thosttradeapiPINVOKE.CThostFtdcTransferBankField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcTransferBankField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferBankField() : this(thosttradeapiPINVOKE.new_CThostFtdcTransferBankField(), true) {
  }

}
