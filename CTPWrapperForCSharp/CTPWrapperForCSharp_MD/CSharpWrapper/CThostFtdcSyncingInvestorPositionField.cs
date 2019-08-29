//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncingInvestorPositionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingInvestorPositionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingInvestorPositionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingInvestorPositionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcSyncingInvestorPositionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionDate {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionDate_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionDate_get(swigCPtr);
      return ret;
    } 
  }

  public int YdPosition {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_YdPosition_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_YdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int Position {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_Position_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_Position_get(swigCPtr);
      return ret;
    } 
  }

  public int LongFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int ShortFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double LongFrozenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortFrozenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCost {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UseMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_UseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_UseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCost {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenCost_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenCost_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public int CombPosition {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CombPosition_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CombPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int CombLongFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CombLongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CombLongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int CombShortFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CombShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CombShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public int TodayPosition {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_TodayPosition_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_TodayPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int StrikeFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeFrozenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int AbandonFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_AbandonFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_AbandonFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int YdStrikeFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_YdStrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_YdStrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCostOffset {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionCostOffset_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionCostOffset_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingInvestorPositionField() : this(thostmdapiPINVOKE.new_CThostFtdcSyncingInvestorPositionField(), true) {
  }

}
