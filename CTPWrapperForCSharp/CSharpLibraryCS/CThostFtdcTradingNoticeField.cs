//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTradingNoticeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTradingNoticeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTradingNoticeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTradingNoticeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcTradingNoticeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public short SequenceSeries {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_SequenceSeries_set(swigCPtr, value);
    } 
    get {
      short ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_SequenceSeries_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string SendTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_SendTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_SendTime_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string FieldContent {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_FieldContent_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_FieldContent_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcTradingNoticeField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTradingNoticeField() : this(thosttradeapiPINVOKE.new_CThostFtdcTradingNoticeField(), true) {
  }

}