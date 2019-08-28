//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcBrokerDepositField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerDepositField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerDepositField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerDepositField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcBrokerDepositField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrMargin {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_CurrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_CurrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Withdraw {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Withdraw_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Available_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double Reserve {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Reserve_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_Reserve_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcBrokerDepositField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerDepositField() : this(thosttradeapiPINVOKE.new_CThostFtdcBrokerDepositField(), true) {
  }

}