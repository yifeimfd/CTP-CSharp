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
          thosttradeapiPINVOKE.delete_CThostFtdcMMInstrumentCommissionRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByMoney {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_OpenRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByMoney {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByMoney {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMMInstrumentCommissionRateField_CloseTodayRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMMInstrumentCommissionRateField() : this(thosttradeapiPINVOKE.new_CThostFtdcMMInstrumentCommissionRateField(), true) {
  }

}
