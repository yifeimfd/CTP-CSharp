//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorPositionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorPositionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorPositionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorPositionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcInvestorPositionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionDate {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionDate_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionDate_get(swigCPtr);
      return ret;
    } 
  }

  public int YdPosition {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_YdPosition_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_YdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int Position {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_Position_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_Position_get(swigCPtr);
      return ret;
    } 
  }

  public int LongFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_LongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_LongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int ShortFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double LongFrozenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_LongFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_LongFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortFrozenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ShortFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ShortFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_OpenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_OpenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCost {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UseMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_UseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_UseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCost {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_OpenCost_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_OpenCost_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public int CombPosition {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CombPosition_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CombPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int CombLongFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CombLongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CombLongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int CombShortFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CombShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CombShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public int TodayPosition {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_TodayPosition_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_TodayPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int StrikeFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeFrozenAmount {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int AbandonFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_AbandonFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_AbandonFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int YdStrikeFrozen {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_YdStrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_YdStrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCostOffset {
    set {
      thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionCostOffset_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcInvestorPositionField_PositionCostOffset_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorPositionField() : this(thostmdapiPINVOKE.new_CThostFtdcInvestorPositionField(), true) {
  }

}
