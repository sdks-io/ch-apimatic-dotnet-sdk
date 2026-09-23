using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackOnClickConverter))]
public record ClickStackOnClick
{
    private readonly Optional<ClickStackOnClickSearch> _clickStackOnClickSearchValue;

    private readonly Optional<ClickStackOnClickDashboard> _clickStackOnClickDashboardValue;

    private readonly Optional<ClickStackOnClickExternal> _clickStackOnClickExternalValue;

    private ClickStackOnClick(Optional<ClickStackOnClickSearch> clickStackOnClickSearchValue,
        Optional<ClickStackOnClickDashboard> clickStackOnClickDashboardValue,
        Optional<ClickStackOnClickExternal> clickStackOnClickExternalValue)
    {
        _clickStackOnClickSearchValue = clickStackOnClickSearchValue;
        _clickStackOnClickDashboardValue = clickStackOnClickDashboardValue;
        _clickStackOnClickExternalValue = clickStackOnClickExternalValue;
    }

    public static ClickStackOnClick ClickStackOnClickSearch(ClickStackOnClickSearch value) =>
        new(Optional<ClickStackOnClickSearch>.Some(value), default, default);

    public static ClickStackOnClick ClickStackOnClickDashboard(ClickStackOnClickDashboard value) =>
        new(default, Optional<ClickStackOnClickDashboard>.Some(value), default);

    public static ClickStackOnClick ClickStackOnClickExternal(ClickStackOnClickExternal value) =>
        new(default, default, Optional<ClickStackOnClickExternal>.Some(value));

    public bool TryGetClickStackOnClickSearch(out ClickStackOnClickSearch value) =>
        _clickStackOnClickSearchValue.TryGetValue(out value);

    public bool TryGetClickStackOnClickDashboard(out ClickStackOnClickDashboard value) =>
        _clickStackOnClickDashboardValue.TryGetValue(out value);

    public bool TryGetClickStackOnClickExternal(out ClickStackOnClickExternal value) =>
        _clickStackOnClickExternalValue.TryGetValue(out value);

    public static implicit operator ClickStackOnClick(ClickStackOnClickSearch value) =>
        ClickStackOnClickSearch(value);

    public static implicit operator ClickStackOnClick(ClickStackOnClickDashboard value) =>
        ClickStackOnClickDashboard(value);

    public static implicit operator ClickStackOnClick(ClickStackOnClickExternal value) =>
        ClickStackOnClickExternal(value);
}

file sealed class ClickStackOnClickConverter : JsonConverter<ClickStackOnClick>
{
    public override ClickStackOnClick Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackOnClickSearch>(root,
            options,
            out var clickStackOnClickSearchValue))
        {
            return ClickStackOnClick.ClickStackOnClickSearch(clickStackOnClickSearchValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackOnClickDashboard>(root,
            options,
            out var clickStackOnClickDashboardValue))
        {
            return ClickStackOnClick.ClickStackOnClickDashboard(clickStackOnClickDashboardValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackOnClickExternal>(root,
            options,
            out var clickStackOnClickExternalValue))
        {
            return ClickStackOnClick.ClickStackOnClickExternal(clickStackOnClickExternalValue);
        }
        throw new JsonException($"JSON does not match ClickStackOnClickSearch or ClickStackOnClickDashboard or ClickStackOnClickExternal schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackOnClick value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackOnClickSearch(out var clickStackOnClickSearchValue))
        {
            JsonSerializer.Serialize(writer, clickStackOnClickSearchValue, options);
        }
        else if (value.TryGetClickStackOnClickDashboard(out var clickStackOnClickDashboardValue))
        {
            JsonSerializer.Serialize(writer, clickStackOnClickDashboardValue, options);
        }
        else if (value.TryGetClickStackOnClickExternal(out var clickStackOnClickExternalValue))
        {
            JsonSerializer.Serialize(writer, clickStackOnClickExternalValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackOnClick)} contains no valid value to serialize.");
        }
    }
}
