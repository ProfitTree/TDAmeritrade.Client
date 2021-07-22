using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OrderStatus
    {
        [EnumMember(Value = "AWAITING_PARENT_ORDER")]
        AwaitingParentOrder,

        [EnumMember(Value = "AWAITING_CONDITION")]
        AwaitingCondition,

        [EnumMember(Value = "AWAITING_MANUAL_REVIEW")]
        AwaitingManualReview,
        Accepted,

        [EnumMember(Value = "AWAITING_UR_OUT")]
        AwaitingUrOut,

        [EnumMember(Value = "PENDING_ACTIVATION")]
        PendingActivation,
        Queued,
        Working,
        Rejected,

        [EnumMember(Value = "PENDING_CANCEL")]
        PendingCancel,
        Canceled,

        [EnumMember(Value = "PENDING_REPLACE")]
        PendingReplace,
        Replaced,
        Filled,
        Expired
    }
}
