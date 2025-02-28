using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using VkNet.Model;

namespace VkNet.Utils.JsonConverter;

/// <summary>
/// Attachment JsonConverter
/// </summary>
/// <seealso cref="JsonConverter" />
public class AttachmentJsonConverter : System.Text.Json.Serialization.JsonConverter<Attachment>
{
	/// <inheritdoc />
	/// <exception cref="T:System.NotImplementedException"> </exception>
	public override void Write(Utf8JsonWriter writer, Attachment value, JsonSerializerOptions options)
	{
		var type = value.Type.Name.ToLower();

		var jObj = new JsonObject()
		{
			{
				"type", type
			},
			{
				type, JsonSerializer.SerializeToNode(value.Instance, options)
			}
		};

		jObj.WriteTo(writer, options);
	}

	/// <inheritdoc />
	/// <exception cref="T:System.TypeAccessException"> </exception>
	public override Attachment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		JsonNode item = JsonNode.Parse(ref reader, new JsonNodeOptions()
		{
			PropertyNameCaseInsensitive = options.PropertyNameCaseInsensitive
		});

		return AttachmentConverterService.Instance.FromJson(item);
	}


	// /// <inheritdoc />
	// public override bool CanConvert(Type objectType) => typeof(ReadOnlyCollection<>).IsAssignableFrom(c: objectType);
}