//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSettlementInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSettlementInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSettlementInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSettlementInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcSettlementInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string Content {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_Content_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_Content_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSettlementInfoField() : this(thosttradeapiPINVOKE.new_CThostFtdcSettlementInfoField(), true) {
  }

}
