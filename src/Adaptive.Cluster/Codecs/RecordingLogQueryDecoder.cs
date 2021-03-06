/* Generated SBE (Simple Binary Encoding) message codec */
using System;
using System.Text;
using System.Collections.Generic;
using Adaptive.Agrona;


namespace Adaptive.Cluster.Codecs {

public class RecordingLogQueryDecoder
{
    public const ushort BLOCK_LENGTH = 32;
    public const ushort TEMPLATE_ID = 63;
    public const ushort SCHEMA_ID = 1;
    public const ushort SCHEMA_VERSION = 1;

    private RecordingLogQueryDecoder _parentMessage;
    private IDirectBuffer _buffer;
    protected int _offset;
    protected int _limit;
    protected int _actingBlockLength;
    protected int _actingVersion;

    public RecordingLogQueryDecoder()
    {
        _parentMessage = this;
    }

    public ushort SbeBlockLength()
    {
        return BLOCK_LENGTH;
    }

    public ushort SbeTemplateId()
    {
        return TEMPLATE_ID;
    }

    public ushort SbeSchemaId()
    {
        return SCHEMA_ID;
    }

    public ushort SbeSchemaVersion()
    {
        return SCHEMA_VERSION;
    }

    public string SbeSemanticType()
    {
        return "";
    }

    public IDirectBuffer Buffer()
    {
        return _buffer;
    }

    public int Offset()
    {
        return _offset;
    }

    public RecordingLogQueryDecoder Wrap(
        IDirectBuffer buffer, int offset, int actingBlockLength, int actingVersion)
    {
        this._buffer = buffer;
        this._offset = offset;
        this._actingBlockLength = actingBlockLength;
        this._actingVersion = actingVersion;
        Limit(offset + actingBlockLength);

        return this;
    }

    public int EncodedLength()
    {
        return _limit - _offset;
    }

    public int Limit()
    {
        return _limit;
    }

    public void Limit(int limit)
    {
        this._limit = limit;
    }

    public static int CorrelationIdId()
    {
        return 1;
    }

    public static int CorrelationIdSinceVersion()
    {
        return 0;
    }

    public static int CorrelationIdEncodingOffset()
    {
        return 0;
    }

    public static int CorrelationIdEncodingLength()
    {
        return 8;
    }

    public static string CorrelationIdMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public static long CorrelationIdNullValue()
    {
        return -9223372036854775808L;
    }

    public static long CorrelationIdMinValue()
    {
        return -9223372036854775807L;
    }

    public static long CorrelationIdMaxValue()
    {
        return 9223372036854775807L;
    }

    public long CorrelationId()
    {
        return _buffer.GetLong(_offset + 0, ByteOrder.LittleEndian);
    }


    public static int RequestMemberIdId()
    {
        return 2;
    }

    public static int RequestMemberIdSinceVersion()
    {
        return 0;
    }

    public static int RequestMemberIdEncodingOffset()
    {
        return 8;
    }

    public static int RequestMemberIdEncodingLength()
    {
        return 4;
    }

    public static string RequestMemberIdMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public static int RequestMemberIdNullValue()
    {
        return -2147483648;
    }

    public static int RequestMemberIdMinValue()
    {
        return -2147483647;
    }

    public static int RequestMemberIdMaxValue()
    {
        return 2147483647;
    }

    public int RequestMemberId()
    {
        return _buffer.GetInt(_offset + 8, ByteOrder.LittleEndian);
    }


    public static int LeaderMemberIdId()
    {
        return 3;
    }

    public static int LeaderMemberIdSinceVersion()
    {
        return 0;
    }

    public static int LeaderMemberIdEncodingOffset()
    {
        return 12;
    }

    public static int LeaderMemberIdEncodingLength()
    {
        return 4;
    }

    public static string LeaderMemberIdMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public static int LeaderMemberIdNullValue()
    {
        return -2147483648;
    }

    public static int LeaderMemberIdMinValue()
    {
        return -2147483647;
    }

    public static int LeaderMemberIdMaxValue()
    {
        return 2147483647;
    }

    public int LeaderMemberId()
    {
        return _buffer.GetInt(_offset + 12, ByteOrder.LittleEndian);
    }


    public static int FromLeadershipTermIdId()
    {
        return 4;
    }

    public static int FromLeadershipTermIdSinceVersion()
    {
        return 0;
    }

    public static int FromLeadershipTermIdEncodingOffset()
    {
        return 16;
    }

    public static int FromLeadershipTermIdEncodingLength()
    {
        return 8;
    }

    public static string FromLeadershipTermIdMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public static long FromLeadershipTermIdNullValue()
    {
        return -9223372036854775808L;
    }

    public static long FromLeadershipTermIdMinValue()
    {
        return -9223372036854775807L;
    }

    public static long FromLeadershipTermIdMaxValue()
    {
        return 9223372036854775807L;
    }

    public long FromLeadershipTermId()
    {
        return _buffer.GetLong(_offset + 16, ByteOrder.LittleEndian);
    }


    public static int CountId()
    {
        return 5;
    }

    public static int CountSinceVersion()
    {
        return 0;
    }

    public static int CountEncodingOffset()
    {
        return 24;
    }

    public static int CountEncodingLength()
    {
        return 4;
    }

    public static string CountMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public static int CountNullValue()
    {
        return -2147483648;
    }

    public static int CountMinValue()
    {
        return -2147483647;
    }

    public static int CountMaxValue()
    {
        return 2147483647;
    }

    public int Count()
    {
        return _buffer.GetInt(_offset + 24, ByteOrder.LittleEndian);
    }


    public static int IncludeSnapshotsId()
    {
        return 6;
    }

    public static int IncludeSnapshotsSinceVersion()
    {
        return 0;
    }

    public static int IncludeSnapshotsEncodingOffset()
    {
        return 28;
    }

    public static int IncludeSnapshotsEncodingLength()
    {
        return 4;
    }

    public static string IncludeSnapshotsMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public BooleanType IncludeSnapshots()
    {
        return (BooleanType)_buffer.GetInt(_offset + 28, ByteOrder.LittleEndian);
    }



    public override string ToString()
    {
        return AppendTo(new StringBuilder(100)).ToString();
    }

    public StringBuilder AppendTo(StringBuilder builder)
    {
        int originalLimit = Limit();
        Limit(_offset + _actingBlockLength);
        builder.Append("[RecordingLogQuery](sbeTemplateId=");
        builder.Append(TEMPLATE_ID);
        builder.Append("|sbeSchemaId=");
        builder.Append(SCHEMA_ID);
        builder.Append("|sbeSchemaVersion=");
        if (_parentMessage._actingVersion != SCHEMA_VERSION)
        {
            builder.Append(_parentMessage._actingVersion);
            builder.Append('/');
        }
        builder.Append(SCHEMA_VERSION);
        builder.Append("|sbeBlockLength=");
        if (_actingBlockLength != BLOCK_LENGTH)
        {
            builder.Append(_actingBlockLength);
            builder.Append('/');
        }
        builder.Append(BLOCK_LENGTH);
        builder.Append("):");
        //Token{signal=BEGIN_FIELD, name='correlationId', referencedName='null', description='null', id=1, version=0, deprecated=0, encodedLength=0, offset=0, componentTokenCount=3, encoding=Encoding{presence=REQUIRED, primitiveType=null, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        //Token{signal=ENCODING, name='int64', referencedName='null', description='null', id=-1, version=0, deprecated=0, encodedLength=8, offset=0, componentTokenCount=1, encoding=Encoding{presence=REQUIRED, primitiveType=INT64, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        builder.Append("CorrelationId=");
        builder.Append(CorrelationId());
        builder.Append('|');
        //Token{signal=BEGIN_FIELD, name='requestMemberId', referencedName='null', description='null', id=2, version=0, deprecated=0, encodedLength=0, offset=8, componentTokenCount=3, encoding=Encoding{presence=REQUIRED, primitiveType=null, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        //Token{signal=ENCODING, name='int32', referencedName='null', description='null', id=-1, version=0, deprecated=0, encodedLength=4, offset=8, componentTokenCount=1, encoding=Encoding{presence=REQUIRED, primitiveType=INT32, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        builder.Append("RequestMemberId=");
        builder.Append(RequestMemberId());
        builder.Append('|');
        //Token{signal=BEGIN_FIELD, name='leaderMemberId', referencedName='null', description='null', id=3, version=0, deprecated=0, encodedLength=0, offset=12, componentTokenCount=3, encoding=Encoding{presence=REQUIRED, primitiveType=null, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        //Token{signal=ENCODING, name='int32', referencedName='null', description='null', id=-1, version=0, deprecated=0, encodedLength=4, offset=12, componentTokenCount=1, encoding=Encoding{presence=REQUIRED, primitiveType=INT32, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        builder.Append("LeaderMemberId=");
        builder.Append(LeaderMemberId());
        builder.Append('|');
        //Token{signal=BEGIN_FIELD, name='fromLeadershipTermId', referencedName='null', description='null', id=4, version=0, deprecated=0, encodedLength=0, offset=16, componentTokenCount=3, encoding=Encoding{presence=REQUIRED, primitiveType=null, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        //Token{signal=ENCODING, name='int64', referencedName='null', description='null', id=-1, version=0, deprecated=0, encodedLength=8, offset=16, componentTokenCount=1, encoding=Encoding{presence=REQUIRED, primitiveType=INT64, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        builder.Append("FromLeadershipTermId=");
        builder.Append(FromLeadershipTermId());
        builder.Append('|');
        //Token{signal=BEGIN_FIELD, name='count', referencedName='null', description='null', id=5, version=0, deprecated=0, encodedLength=0, offset=24, componentTokenCount=3, encoding=Encoding{presence=REQUIRED, primitiveType=null, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        //Token{signal=ENCODING, name='int32', referencedName='null', description='null', id=-1, version=0, deprecated=0, encodedLength=4, offset=24, componentTokenCount=1, encoding=Encoding{presence=REQUIRED, primitiveType=INT32, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        builder.Append("Count=");
        builder.Append(Count());
        builder.Append('|');
        //Token{signal=BEGIN_FIELD, name='includeSnapshots', referencedName='null', description='null', id=6, version=0, deprecated=0, encodedLength=0, offset=28, componentTokenCount=6, encoding=Encoding{presence=REQUIRED, primitiveType=null, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='unix', timeUnit=nanosecond, semanticType='null'}}
        //Token{signal=BEGIN_ENUM, name='BooleanType', referencedName='null', description='null', id=-1, version=0, deprecated=0, encodedLength=4, offset=28, componentTokenCount=4, encoding=Encoding{presence=REQUIRED, primitiveType=INT32, byteOrder=LITTLE_ENDIAN, minValue=null, maxValue=null, nullValue=null, constValue=null, characterEncoding='null', epoch='null', timeUnit=null, semanticType='null'}}
        builder.Append("IncludeSnapshots=");
        builder.Append(IncludeSnapshots());

        Limit(originalLimit);

        return builder;
    }
}
}
