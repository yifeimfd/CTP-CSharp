//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcOptionInstrMarginAdjustField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOptionInstrMarginAdjustField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOptionInstrMarginAdjustField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOptionInstrMarginAdjustField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcOptionInstrMarginAdjustField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double SShortMarginRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_SShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_SShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double SShortMarginRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_SShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_SShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double HShortMarginRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_HShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_HShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double HShortMarginRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_HShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_HShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double AShortMarginRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_AShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_AShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double AShortMarginRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_AShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_AShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsRelative {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_IsRelative_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_IsRelative_get(swigCPtr);
      return ret;
    } 
  }

  public double MShortMarginRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_MShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_MShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MShortMarginRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_MShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrMarginAdjustField_MShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOptionInstrMarginAdjustField() : this(thostmdapiPINVOKE.new_CThostFtdcOptionInstrMarginAdjustField(), true) {
  }

}
