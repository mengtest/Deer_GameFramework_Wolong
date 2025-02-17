// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExternalMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb.Message {

  /// <summary>Holder for reflection information generated from ExternalMessage.proto</summary>
  public static partial class ExternalMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for ExternalMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExternalMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFeHRlcm5hbE1lc3NhZ2UucHJvdG8SCnBiLm1lc3NhZ2UihAEKD0V4dGVy",
            "bmFsTWVzc2FnZRIPCgdjbWRDb2RlGAEgASgFEhYKDnByb3RvY29sU3dpdGNo",
            "GAIgASgFEhAKCGNtZE1lcmdlGAMgASgFEhYKDnJlc3BvbnNlU3RhdHVzGAQg",
            "ASgREhAKCHZhbGlkTXNnGAUgASgJEgwKBGRhdGEYBiABKAwiGQoFSW50UGIS",
            "EAoIaW50VmFsdWUYASABKBEiHgoJSW50TGlzdFBiEhEKCWludFZhbHVlcxgB",
            "IAMoESIbCgZMb25nUGISEQoJbG9uZ1ZhbHVlGAEgASgSIiAKCkxvbmdMaXN0",
            "UGISEgoKbG9uZ1ZhbHVlcxgBIAMoEmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Message.ExternalMessage), global::Pb.Message.ExternalMessage.Parser, new[]{ "CmdCode", "ProtocolSwitch", "CmdMerge", "ResponseStatus", "ValidMsg", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Message.IntPb), global::Pb.Message.IntPb.Parser, new[]{ "IntValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Message.IntListPb), global::Pb.Message.IntListPb.Parser, new[]{ "IntValues" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Message.LongPb), global::Pb.Message.LongPb.Parser, new[]{ "LongValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Message.LongListPb), global::Pb.Message.LongListPb.Parser, new[]{ "LongValues" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 对外服数据协议
  /// </summary>
  public sealed partial class ExternalMessage : pb::IMessage<ExternalMessage> {
    private static readonly pb::MessageParser<ExternalMessage> _parser = new pb::MessageParser<ExternalMessage>(() => new ExternalMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExternalMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.Message.ExternalMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExternalMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExternalMessage(ExternalMessage other) : this() {
      cmdCode_ = other.cmdCode_;
      protocolSwitch_ = other.protocolSwitch_;
      cmdMerge_ = other.cmdMerge_;
      responseStatus_ = other.responseStatus_;
      validMsg_ = other.validMsg_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExternalMessage Clone() {
      return new ExternalMessage(this);
    }

    /// <summary>Field number for the "cmdCode" field.</summary>
    public const int CmdCodeFieldNumber = 1;
    private int cmdCode_;
    /// <summary>
    /// 请求命令类型: 0 心跳，1 业务
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CmdCode {
      get { return cmdCode_; }
      set {
        cmdCode_ = value;
      }
    }

    /// <summary>Field number for the "protocolSwitch" field.</summary>
    public const int ProtocolSwitchFieldNumber = 2;
    private int protocolSwitch_;
    /// <summary>
    /// 协议开关，用于一些协议级别的开关控制，比如 安全加密校验等。 : 0 不校验
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ProtocolSwitch {
      get { return protocolSwitch_; }
      set {
        protocolSwitch_ = value;
      }
    }

    /// <summary>Field number for the "cmdMerge" field.</summary>
    public const int CmdMergeFieldNumber = 3;
    private int cmdMerge_;
    /// <summary>
    /// 业务路由（高16为主, 低16为子）
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CmdMerge {
      get { return cmdMerge_; }
      set {
        cmdMerge_ = value;
      }
    }

    /// <summary>Field number for the "responseStatus" field.</summary>
    public const int ResponseStatusFieldNumber = 4;
    private int responseStatus_;
    /// <summary>
    /// 响应码: 0:成功, 其他为有错误
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ResponseStatus {
      get { return responseStatus_; }
      set {
        responseStatus_ = value;
      }
    }

    /// <summary>Field number for the "validMsg" field.</summary>
    public const int ValidMsgFieldNumber = 5;
    private string validMsg_ = "";
    /// <summary>
    /// 验证信息: 当 responseStatus == -1001 时， 会有值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValidMsg {
      get { return validMsg_; }
      set {
        validMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 6;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// 业务请求数据
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExternalMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExternalMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CmdCode != other.CmdCode) return false;
      if (ProtocolSwitch != other.ProtocolSwitch) return false;
      if (CmdMerge != other.CmdMerge) return false;
      if (ResponseStatus != other.ResponseStatus) return false;
      if (ValidMsg != other.ValidMsg) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CmdCode != 0) hash ^= CmdCode.GetHashCode();
      if (ProtocolSwitch != 0) hash ^= ProtocolSwitch.GetHashCode();
      if (CmdMerge != 0) hash ^= CmdMerge.GetHashCode();
      if (ResponseStatus != 0) hash ^= ResponseStatus.GetHashCode();
      if (ValidMsg.Length != 0) hash ^= ValidMsg.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CmdCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CmdCode);
      }
      if (ProtocolSwitch != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ProtocolSwitch);
      }
      if (CmdMerge != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CmdMerge);
      }
      if (ResponseStatus != 0) {
        output.WriteRawTag(32);
        output.WriteSInt32(ResponseStatus);
      }
      if (ValidMsg.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ValidMsg);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CmdCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CmdCode);
      }
      if (ProtocolSwitch != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProtocolSwitch);
      }
      if (CmdMerge != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CmdMerge);
      }
      if (ResponseStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(ResponseStatus);
      }
      if (ValidMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValidMsg);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExternalMessage other) {
      if (other == null) {
        return;
      }
      if (other.CmdCode != 0) {
        CmdCode = other.CmdCode;
      }
      if (other.ProtocolSwitch != 0) {
        ProtocolSwitch = other.ProtocolSwitch;
      }
      if (other.CmdMerge != 0) {
        CmdMerge = other.CmdMerge;
      }
      if (other.ResponseStatus != 0) {
        ResponseStatus = other.ResponseStatus;
      }
      if (other.ValidMsg.Length != 0) {
        ValidMsg = other.ValidMsg;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CmdCode = input.ReadInt32();
            break;
          }
          case 16: {
            ProtocolSwitch = input.ReadInt32();
            break;
          }
          case 24: {
            CmdMerge = input.ReadInt32();
            break;
          }
          case 32: {
            ResponseStatus = input.ReadSInt32();
            break;
          }
          case 42: {
            ValidMsg = input.ReadString();
            break;
          }
          case 50: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// int 包装类
  /// </summary>
  public sealed partial class IntPb : pb::IMessage<IntPb> {
    private static readonly pb::MessageParser<IntPb> _parser = new pb::MessageParser<IntPb>(() => new IntPb());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IntPb> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.Message.ExternalMessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntPb() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntPb(IntPb other) : this() {
      intValue_ = other.intValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntPb Clone() {
      return new IntPb(this);
    }

    /// <summary>Field number for the "intValue" field.</summary>
    public const int IntValueFieldNumber = 1;
    private int intValue_;
    /// <summary>
    /// int 值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IntValue {
      get { return intValue_; }
      set {
        intValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IntPb);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IntPb other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntValue != other.IntValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IntValue != 0) hash ^= IntValue.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(IntValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IntValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(IntValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IntPb other) {
      if (other == null) {
        return;
      }
      if (other.IntValue != 0) {
        IntValue = other.IntValue;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IntValue = input.ReadSInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// int list 包装类
  /// </summary>
  public sealed partial class IntListPb : pb::IMessage<IntListPb> {
    private static readonly pb::MessageParser<IntListPb> _parser = new pb::MessageParser<IntListPb>(() => new IntListPb());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IntListPb> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.Message.ExternalMessageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntListPb() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntListPb(IntListPb other) : this() {
      intValues_ = other.intValues_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntListPb Clone() {
      return new IntListPb(this);
    }

    /// <summary>Field number for the "intValues" field.</summary>
    public const int IntValuesFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_intValues_codec
        = pb::FieldCodec.ForSInt32(10);
    private readonly pbc::RepeatedField<int> intValues_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// intList
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> IntValues {
      get { return intValues_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IntListPb);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IntListPb other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!intValues_.Equals(other.intValues_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= intValues_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      intValues_.WriteTo(output, _repeated_intValues_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += intValues_.CalculateSize(_repeated_intValues_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IntListPb other) {
      if (other == null) {
        return;
      }
      intValues_.Add(other.intValues_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            intValues_.AddEntriesFrom(input, _repeated_intValues_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// long 包装类
  /// </summary>
  public sealed partial class LongPb : pb::IMessage<LongPb> {
    private static readonly pb::MessageParser<LongPb> _parser = new pb::MessageParser<LongPb>(() => new LongPb());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LongPb> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.Message.ExternalMessageReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LongPb() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LongPb(LongPb other) : this() {
      longValue_ = other.longValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LongPb Clone() {
      return new LongPb(this);
    }

    /// <summary>Field number for the "longValue" field.</summary>
    public const int LongValueFieldNumber = 1;
    private long longValue_;
    /// <summary>
    /// long 值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LongValue {
      get { return longValue_; }
      set {
        longValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LongPb);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LongPb other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LongValue != other.LongValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LongValue != 0L) hash ^= LongValue.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (LongValue != 0L) {
        output.WriteRawTag(8);
        output.WriteSInt64(LongValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LongValue != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(LongValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LongPb other) {
      if (other == null) {
        return;
      }
      if (other.LongValue != 0L) {
        LongValue = other.LongValue;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            LongValue = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// long list 包装类
  /// </summary>
  public sealed partial class LongListPb : pb::IMessage<LongListPb> {
    private static readonly pb::MessageParser<LongListPb> _parser = new pb::MessageParser<LongListPb>(() => new LongListPb());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LongListPb> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.Message.ExternalMessageReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LongListPb() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LongListPb(LongListPb other) : this() {
      longValues_ = other.longValues_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LongListPb Clone() {
      return new LongListPb(this);
    }

    /// <summary>Field number for the "longValues" field.</summary>
    public const int LongValuesFieldNumber = 1;
    private static readonly pb::FieldCodec<long> _repeated_longValues_codec
        = pb::FieldCodec.ForSInt64(10);
    private readonly pbc::RepeatedField<long> longValues_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// longList
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> LongValues {
      get { return longValues_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LongListPb);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LongListPb other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!longValues_.Equals(other.longValues_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= longValues_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      longValues_.WriteTo(output, _repeated_longValues_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += longValues_.CalculateSize(_repeated_longValues_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LongListPb other) {
      if (other == null) {
        return;
      }
      longValues_.Add(other.longValues_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            longValues_.AddEntriesFrom(input, _repeated_longValues_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
