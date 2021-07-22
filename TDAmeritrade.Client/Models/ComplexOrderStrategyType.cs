// ReSharper disable InconsistentNaming

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TDAmeritrade.Client.Models
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ComplexOrderStrategyType
    {
        None,
        Covered,
        Vertical,

        [EnumMember(Value = "BACK_RATIO")]
        BackRatio,
        Calendar,
        Diagonal,
        Straddle,
        Strangle,

        [EnumMember(Value = "COLLAR_SYNTHETIC")]
        CollarSynthetic,
        Butterfly,
        Condor,

        [EnumMember(Value = "IRON_CONDOR")]
        IronCondor,

        [EnumMember(Value = "VERTICAL_ROLL")]
        VerticalRoll,

        [EnumMember(Value = "COLLAR_WITH_STOCK")]
        CollarWithStock,

        [EnumMember(Value = "DOUBLE_DIAGONAL")]
        DoubleDiagonal,

        [EnumMember(Value = "UNBALANCED_BUTTERFLY")]
        UnbalancedButterfly,

        [EnumMember(Value = "UNBALANCED_CONDOR")]
        UnbalancedCondor,

        [EnumMember(Value = "UNBALANCED_IRON_CONDOR")]
        UnbalancedIronCondor,

        [EnumMember(Value = "UNBALANCED_VERTICAL_ROLL")]
        UnbalancedVerticalRoll,

        Custom
    }
}
