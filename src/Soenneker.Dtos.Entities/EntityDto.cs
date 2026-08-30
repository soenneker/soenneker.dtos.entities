using Soenneker.Attributes.PublicOpenApiObject;
using System;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Entities;

/// <summary>
/// Provides the stable identifier and creation or modification timestamps shared by entity data-transfer objects.
/// </summary>
[PublicOpenApiObject]
public class EntityDto
{
    /// <summary>
    /// Stable unique identifier of the resource.
    /// </summary>
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    /// <summary>
    /// Timestamp when the resource was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public virtual DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Timestamp when the resource was last modified, or <see langword="null"/> when it has not been updated.
    /// </summary>
    [JsonPropertyName("modifiedAt")]
    public virtual DateTimeOffset? ModifiedAt { get; set; }
}
