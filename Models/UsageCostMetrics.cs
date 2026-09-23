using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UsageCostMetrics
{
    /// <summary>
    /// Cost of storage in ClickHouse Credits (CHCs). Applies to dataWarehouse entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storageCHC")]
    public double? StorageChc { get; init; }

    /// <summary>
    /// Cost of backup in ClickHouse Credits (CHCs). Applies to dataWarehouse entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupCHC")]
    public double? BackupChc { get; init; }

    /// <summary>
    /// Cost of compute in ClickHouse Credits (CHCs). Applies to service and clickpipe entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("computeCHC")]
    public double? ComputeChc { get; init; }

    /// <summary>
    /// Cost of data transfer in ClickHouse Credits (CHCs). Applies to clickpipe entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataTransferCHC")]
    public double? DataTransferChc { get; init; }

    /// <summary>
    /// Cost of initial load and resyncs in ClickHouse Credits (CHCs). Applies to clickpipe entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initialLoadCHC")]
    public double? InitialLoadChc { get; init; }

    /// <summary>
    /// Cost of data transfer in ClickHouse Credits (CHCs). Applies to service entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicDataTransferCHC")]
    public double? PublicDataTransferChc { get; init; }

    /// <summary>
    /// Cost of tier1 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interRegionTier1DataTransferCHC")]
    public double? InterRegionTier1DataTransferChc { get; init; }

    /// <summary>
    /// Cost of tier2 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interRegionTier2DataTransferCHC")]
    public double? InterRegionTier2DataTransferChc { get; init; }

    /// <summary>
    /// Cost of tier3 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interRegionTier3DataTransferCHC")]
    public double? InterRegionTier3DataTransferChc { get; init; }

    /// <summary>
    /// Cost of tier4 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interRegionTier4DataTransferCHC")]
    public double? InterRegionTier4DataTransferChc { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
