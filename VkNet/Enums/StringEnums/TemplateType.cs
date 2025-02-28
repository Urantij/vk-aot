using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Enums.StringEnums;

/// <summary>
/// Тип шаблона.
/// </summary>
[StringEnum]
[JsonConverter(typeof(TolerantStringEnumConverter))]
public enum TemplateType
{
	/// <summary>
	/// Карусель
	/// </summary>
	Carousel
}