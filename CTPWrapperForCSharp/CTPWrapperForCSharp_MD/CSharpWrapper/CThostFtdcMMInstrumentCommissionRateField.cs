//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMMInstrumentCommissionRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMMInstrumentCommissionRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMMInstrumentCommissionRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMMInstrumentCommissionRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcMMInstrumentCommissionRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMMInstrumentCommissionRateField() : this(thostmdapiPINVOKE.new_CThostFtdcMMInstrumentCommissionRateField(), true) {
  }

}
