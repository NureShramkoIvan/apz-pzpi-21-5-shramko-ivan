// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/training-results.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DroneTrainer.Training.Service {

  /// <summary>Holder for reflection information generated from Protos/training-results.proto</summary>
  public static partial class TrainingResultsReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/training-results.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainingResultsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qcm90b3MvdHJhaW5pbmctcmVzdWx0cy5wcm90bxoeZ29vZ2xlL3Byb3Rv",
            "YnVmL2R1cmF0aW9uLnByb3RvIkAKGVVzZXJUcmFpbmluZ1Jlc3VsdFJlcXVl",
            "c3QSDwoHdXNlcl9pZBgBIAEoBRISCgpzZXNzaW9uX2lkGAIgASgFIsIBChpV",
            "c2VyVHJhaW5pbmdSZXN1bHRSZXNwb25zZRIhChlzdWNjZXNzZnVsbF9nYXRl",
            "c19wZXJjZW50GAEgASgBEiMKG3Vuc3VjY2Vzc2Z1bGxfZ2F0ZXNfcGVyY2Vu",
            "dBgCIAEoARI6ChdzZXNzaW9uX2NvbXBsZXRpb25fdGltZRgDIAEoCzIZLmdv",
            "b2dsZS5wcm90b2J1Zi5EdXJhdGlvbhIgChh1c2VyX3N1Y2Nlc3NfY29lZmZp",
            "Y2llbnQYBCABKAEyYgoOVHJhaW5pbmdSZXN1bHQSUAoVR2V0VXNlclRyYWlu",
            "aW5nUmVzdWx0EhouVXNlclRyYWluaW5nUmVzdWx0UmVxdWVzdBobLlVzZXJU",
            "cmFpbmluZ1Jlc3VsdFJlc3BvbnNlQiCqAh1Ecm9uZVRyYWluZXIuVHJhaW5p",
            "bmcuU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DroneTrainer.Training.Service.UserTrainingResultRequest), global::DroneTrainer.Training.Service.UserTrainingResultRequest.Parser, new[]{ "UserId", "SessionId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DroneTrainer.Training.Service.UserTrainingResultResponse), global::DroneTrainer.Training.Service.UserTrainingResultResponse.Parser, new[]{ "SuccessfullGatesPercent", "UnsuccessfullGatesPercent", "SessionCompletionTime", "UserSuccessCoefficient" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserTrainingResultRequest : pb::IMessage<UserTrainingResultRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserTrainingResultRequest> _parser = new pb::MessageParser<UserTrainingResultRequest>(() => new UserTrainingResultRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserTrainingResultRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DroneTrainer.Training.Service.TrainingResultsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserTrainingResultRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserTrainingResultRequest(UserTrainingResultRequest other) : this() {
      userId_ = other.userId_;
      sessionId_ = other.sessionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserTrainingResultRequest Clone() {
      return new UserTrainingResultRequest(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "session_id" field.</summary>
    public const int SessionIdFieldNumber = 2;
    private int sessionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SessionId {
      get { return sessionId_; }
      set {
        sessionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserTrainingResultRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserTrainingResultRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (SessionId != other.SessionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (SessionId != 0) hash ^= SessionId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      if (SessionId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SessionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      if (SessionId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SessionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (SessionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SessionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserTrainingResultRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.SessionId != 0) {
        SessionId = other.SessionId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
          case 16: {
            SessionId = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
          case 16: {
            SessionId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserTrainingResultResponse : pb::IMessage<UserTrainingResultResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserTrainingResultResponse> _parser = new pb::MessageParser<UserTrainingResultResponse>(() => new UserTrainingResultResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserTrainingResultResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DroneTrainer.Training.Service.TrainingResultsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserTrainingResultResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserTrainingResultResponse(UserTrainingResultResponse other) : this() {
      successfullGatesPercent_ = other.successfullGatesPercent_;
      unsuccessfullGatesPercent_ = other.unsuccessfullGatesPercent_;
      sessionCompletionTime_ = other.sessionCompletionTime_ != null ? other.sessionCompletionTime_.Clone() : null;
      userSuccessCoefficient_ = other.userSuccessCoefficient_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserTrainingResultResponse Clone() {
      return new UserTrainingResultResponse(this);
    }

    /// <summary>Field number for the "successfull_gates_percent" field.</summary>
    public const int SuccessfullGatesPercentFieldNumber = 1;
    private double successfullGatesPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double SuccessfullGatesPercent {
      get { return successfullGatesPercent_; }
      set {
        successfullGatesPercent_ = value;
      }
    }

    /// <summary>Field number for the "unsuccessfull_gates_percent" field.</summary>
    public const int UnsuccessfullGatesPercentFieldNumber = 2;
    private double unsuccessfullGatesPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double UnsuccessfullGatesPercent {
      get { return unsuccessfullGatesPercent_; }
      set {
        unsuccessfullGatesPercent_ = value;
      }
    }

    /// <summary>Field number for the "session_completion_time" field.</summary>
    public const int SessionCompletionTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration sessionCompletionTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration SessionCompletionTime {
      get { return sessionCompletionTime_; }
      set {
        sessionCompletionTime_ = value;
      }
    }

    /// <summary>Field number for the "user_success_coefficient" field.</summary>
    public const int UserSuccessCoefficientFieldNumber = 4;
    private double userSuccessCoefficient_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double UserSuccessCoefficient {
      get { return userSuccessCoefficient_; }
      set {
        userSuccessCoefficient_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserTrainingResultResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserTrainingResultResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SuccessfullGatesPercent, other.SuccessfullGatesPercent)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UnsuccessfullGatesPercent, other.UnsuccessfullGatesPercent)) return false;
      if (!object.Equals(SessionCompletionTime, other.SessionCompletionTime)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UserSuccessCoefficient, other.UserSuccessCoefficient)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SuccessfullGatesPercent != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SuccessfullGatesPercent);
      if (UnsuccessfullGatesPercent != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UnsuccessfullGatesPercent);
      if (sessionCompletionTime_ != null) hash ^= SessionCompletionTime.GetHashCode();
      if (UserSuccessCoefficient != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UserSuccessCoefficient);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (SuccessfullGatesPercent != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(SuccessfullGatesPercent);
      }
      if (UnsuccessfullGatesPercent != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(UnsuccessfullGatesPercent);
      }
      if (sessionCompletionTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SessionCompletionTime);
      }
      if (UserSuccessCoefficient != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(UserSuccessCoefficient);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SuccessfullGatesPercent != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(SuccessfullGatesPercent);
      }
      if (UnsuccessfullGatesPercent != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(UnsuccessfullGatesPercent);
      }
      if (sessionCompletionTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SessionCompletionTime);
      }
      if (UserSuccessCoefficient != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(UserSuccessCoefficient);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (SuccessfullGatesPercent != 0D) {
        size += 1 + 8;
      }
      if (UnsuccessfullGatesPercent != 0D) {
        size += 1 + 8;
      }
      if (sessionCompletionTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SessionCompletionTime);
      }
      if (UserSuccessCoefficient != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserTrainingResultResponse other) {
      if (other == null) {
        return;
      }
      if (other.SuccessfullGatesPercent != 0D) {
        SuccessfullGatesPercent = other.SuccessfullGatesPercent;
      }
      if (other.UnsuccessfullGatesPercent != 0D) {
        UnsuccessfullGatesPercent = other.UnsuccessfullGatesPercent;
      }
      if (other.sessionCompletionTime_ != null) {
        if (sessionCompletionTime_ == null) {
          SessionCompletionTime = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        SessionCompletionTime.MergeFrom(other.SessionCompletionTime);
      }
      if (other.UserSuccessCoefficient != 0D) {
        UserSuccessCoefficient = other.UserSuccessCoefficient;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            SuccessfullGatesPercent = input.ReadDouble();
            break;
          }
          case 17: {
            UnsuccessfullGatesPercent = input.ReadDouble();
            break;
          }
          case 26: {
            if (sessionCompletionTime_ == null) {
              SessionCompletionTime = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(SessionCompletionTime);
            break;
          }
          case 33: {
            UserSuccessCoefficient = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 9: {
            SuccessfullGatesPercent = input.ReadDouble();
            break;
          }
          case 17: {
            UnsuccessfullGatesPercent = input.ReadDouble();
            break;
          }
          case 26: {
            if (sessionCompletionTime_ == null) {
              SessionCompletionTime = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(SessionCompletionTime);
            break;
          }
          case 33: {
            UserSuccessCoefficient = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
