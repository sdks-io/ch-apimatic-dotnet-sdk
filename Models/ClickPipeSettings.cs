using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeSettings
{
    /// <summary>
    /// Streaming max insert wait time. Configures the max wait period before inserting data into the ClickHouse.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streaming_max_insert_wait_ms")]
    [Minimum(500)]
    [Maximum(60000)]
    public int? StreamingMaxInsertWaitMs { get; init; }

    /// <summary>
    /// Object storage concurrency. Number of concurrent file processing threads
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_storage_concurrency")]
    [Minimum(1)]
    [Maximum(35)]
    public int? ObjectStorageConcurrency { get; init; }

    /// <summary>
    /// Object storage polling interval. Configures the refresh interval for querying continuous ingest for new object storage data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_storage_polling_interval_ms")]
    [Minimum(100)]
    [Maximum(3600000)]
    public int? ObjectStoragePollingIntervalMs { get; init; }

    /// <summary>
    /// Max insert bytes. Number of bytes to process in a single insert batch
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_storage_max_insert_bytes")]
    [Minimum(524288000)]
    [Maximum(10737418240)]
    public long? ObjectStorageMaxInsertBytes { get; init; }

    /// <summary>
    /// Max file count. Maximum number of files to process in a single insert batch
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_storage_max_file_count")]
    [Minimum(1)]
    [Maximum(10000)]
    public int? ObjectStorageMaxFileCount { get; init; }

    /// <summary>
    /// Max threads. Maximum number of concurrent threads for file processing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_max_threads")]
    [Minimum(0)]
    [Maximum(64)]
    public int? ClickhouseMaxThreads { get; init; }

    /// <summary>
    /// Max insert threads. Maximum number of concurrent insert threads
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_max_insert_threads")]
    [Minimum(0)]
    [Maximum(16)]
    public int? ClickhouseMaxInsertThreads { get; init; }

    /// <summary>
    /// Min insert block size bytes. Minimum size of data block for insert (in bytes)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_min_insert_block_size_bytes")]
    [Minimum(0)]
    [Maximum(2147483647)]
    public int? ClickhouseMinInsertBlockSizeBytes { get; init; }

    /// <summary>
    /// Max download threads. Maximum number of concurrent download threads
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_max_download_threads")]
    [Minimum(0)]
    [Maximum(32)]
    public int? ClickhouseMaxDownloadThreads { get; init; }

    /// <summary>
    /// Parallel distributed insert select. Parallel distributed insert select setting
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_parallel_distributed_insert_select")]
    [Minimum(0)]
    [Maximum(2)]
    public int? ClickhouseParallelDistributedInsertSelect { get; init; }

    /// <summary>
    /// Kafka Read Committed. Whether Kafka consumers read only committed messages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kafka_read_committed")]
    public bool? KafkaReadCommitted { get; init; }

    /// <summary>
    /// use cluster function. Whether to use ClickHouse cluster function for distributed processing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_storage_use_cluster_function")]
    public bool? ObjectStorageUseClusterFunction { get; init; }

    /// <summary>
    /// parallel view processing. Whether to enable pushing to attached views concurrently instead of sequentially
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_parallel_view_processing")]
    public bool? ClickhouseParallelViewProcessing { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
