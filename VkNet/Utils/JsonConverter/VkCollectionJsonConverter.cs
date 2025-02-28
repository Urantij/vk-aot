using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using JetBrains.Annotations;

namespace VkNet.Utils.JsonConverter;

/// <summary>
/// Vk Collection Json Converter
/// </summary>
public class VkCollectionJsonConverter<T> : System.Text.Json.Serialization.JsonConverter<VkCollection<T>>
{
	private const string ResponsePropertyKey = "response";

	/// <summary>
	/// Инициализация
	/// </summary>
	/// <param name="collectionField"> Collection Field </param>
	public VkCollectionJsonConverter(string collectionField) => CollectionField = string.IsNullOrWhiteSpace(collectionField)
		? "items"
		: collectionField;

	/// <inheritdoc />
	public VkCollectionJsonConverter() : this("items")
	{
	}

	/// <summary>
	/// Количество
	/// </summary>
	private static string CountPropertyKey => "count";

	/// <summary>
	/// Поле с коллекцией данных
	/// </summary>
	private string CollectionField { get; }

	/// <inheritdoc />
	public override void Write(Utf8JsonWriter writer, VkCollection<T> value, JsonSerializerOptions options)
	{
		List<T> items = value.ToList();
		string serializedItems = JsonSerializer.Serialize(items, options);

		writer.WriteStartObject();

		writer.WritePropertyName("TotalCount");
		writer.WriteNumberValue(value.TotalCount);

		writer.WritePropertyName("Items");

		writer.WriteRawValue(serializedItems);

		writer.WriteEndObject();
	}

	/// <inheritdoc />
	// public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	[ItemCanBeNull]
	[CanBeNull]
	public override VkCollection<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		JsonObject? rootObj = JsonNode.Parse(ref reader, new JsonNodeOptions()
		{
			PropertyNameCaseInsensitive = options.PropertyNameCaseInsensitive
		})?.AsObject();

		if (rootObj == null)
			return null;

		JsonObject? responseObj = rootObj[ResponsePropertyKey]?.AsObject() ?? rootObj;

		ulong totalCount = rootObj[CountPropertyKey]
			.GetValue<ulong>();

		var list = responseObj[CollectionField]
			.AsObject()
			.Select(item => JsonSerializer.Deserialize<T>(item.Value, options))
			.ToList();

		return new VkCollection<T>(totalCount, list);
	}

	// /// <summary>
	// /// Может преобразовать
	// /// </summary>
	// /// <param name="objectType"> Тип объекта </param>
	// /// <returns> <c> true </c> если можно преобразовать </returns>
	// public override bool CanConvert(Type objectType) => typeof(VkCollection<>).IsAssignableFrom(objectType);
}