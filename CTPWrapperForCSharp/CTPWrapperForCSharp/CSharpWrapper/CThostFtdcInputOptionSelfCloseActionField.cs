//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputOptionSelfCloseActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputOptionSelfCloseActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputOptionSelfCloseActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputOptionSelfCloseActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcInputOptionSelfCloseActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int OptionSelfCloseActionRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_OptionSelfCloseActionRef_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_OptionSelfCloseActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_OptionSelfCloseRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_OptionSelfCloseRef_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_OptionSelfCloseSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_OptionSelfCloseSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputOptionSelfCloseActionField() : this(thosttradeapiPINVOKE.new_CThostFtdcInputOptionSelfCloseActionField(), true) {
  }

}
