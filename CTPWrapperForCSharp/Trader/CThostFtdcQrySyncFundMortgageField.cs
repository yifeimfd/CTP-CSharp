//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQrySyncFundMortgageField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQrySyncFundMortgageField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQrySyncFundMortgageField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQrySyncFundMortgageField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcQrySyncFundMortgageField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQrySyncFundMortgageField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQrySyncFundMortgageField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string MortgageSeqNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcQrySyncFundMortgageField_MortgageSeqNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQrySyncFundMortgageField_MortgageSeqNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQrySyncFundMortgageField() : this(thosttradeapiPINVOKE.new_CThostFtdcQrySyncFundMortgageField(), true) {
  }

}
