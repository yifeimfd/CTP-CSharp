//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcExchangeOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char OrderPriceType {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string CombOffsetFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_CombOffsetFlag_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_CombOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CombHedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_CombHedgeFlag_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_CombHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotalOriginal {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeTotalOriginal_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeTotalOriginal_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string GTDDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_GTDDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_GTDDate_get(swigCPtr);
      return ret;
    } 
  }

  public char VolumeCondition {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public int MinVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char ContingentCondition {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ContingentCondition_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ContingentCondition_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ForceCloseReason {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAutoSuspend {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_IsAutoSuspend_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_IsAutoSuspend_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTraded {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeTraded_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeTraded_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotal {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeTotal_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_VolumeTotal_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ActiveTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ActiveTime_get(swigCPtr);
      return ret;
    } 
  }

  public string SuspendTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_SuspendTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_SuspendTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpdateTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveTraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ActiveTraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ActiveTraderID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcExchangeOrderField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeOrderField() : this(thosttradeapiPINVOKE.new_CThostFtdcExchangeOrderField(), true) {
  }

}
