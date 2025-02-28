using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using VkNet.Exception;

namespace VkNet.Infrastructure;

/// <summary>
/// Конфигурация JSON
/// </summary>
internal static class JsonConfigure
{
	/// <returns></returns>
	internal static readonly JsonSerializerOptions JsonSerializerSettings = new()
	{
		MaxDepth = int.MaxValue,
		ReferenceHandler =ReferenceHandler.IgnoreCycles,
		TypeInfoResolver = GlobalJsonSerializerContext.Default
		// ReferenceLoopHandling = ReferenceLoopHandling.Ignore
	};

	/// <returns>
	/// Преобразование в JSON
	/// </returns>
	internal static JsonObject ToJObject(this string answer)
	{
		try
		{
			return JsonNode.Parse(answer).AsObject();
		}
		catch (System.Exception ex)
		{
			throw new VkApiException("Wrong json data.", ex);
		}

		// try
		// {
		// 	using var stringReader = new StringReader(answer);
		//
		// 	using JsonReader jsonReader = new JsonTextReader(stringReader);
		//
		// 	jsonReader.MaxDepth = null;
		//
		// 	return JObject.Load(jsonReader);
		// }
		// catch (JsonReaderException ex)
		// {
		// 	throw new VkApiException("Wrong json data.", ex);
		// }
	}
}