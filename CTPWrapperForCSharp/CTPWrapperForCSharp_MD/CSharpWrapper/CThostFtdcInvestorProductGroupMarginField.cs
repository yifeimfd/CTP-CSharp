//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorProductGroupMarginField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorProductGroupMarginField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorProductGroupMarginField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorProductGroupMarginField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcInvestorProductGroupMarginField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ProductGroupID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ProductGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ProductGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double LongFrozenMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortFrozenMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UseMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_UseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_UseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double LongUseMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongUseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongUseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortUseMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortUseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortUseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double LongExchMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortExchMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OffsetAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_OffsetAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_OffsetAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double LongOffsetAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongOffsetAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongOffsetAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortOffsetAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortOffsetAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortOffsetAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchOffsetAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ExchOffsetAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ExchOffsetAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double LongExchOffsetAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongExchOffsetAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_LongExchOffsetAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortExchOffsetAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortExchOffsetAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ShortExchOffsetAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorProductGroupMarginField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorProductGroupMarginField() : this(thostmdapiPINVOKE.new_CThostFtdcInvestorProductGroupMarginField(), true) {
  }

}
