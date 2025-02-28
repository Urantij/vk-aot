using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса SendRequest для приложений.
/// </summary>
[Serializable]
public class AppSendRequestParams
{
	/// <summary>
	/// Идентификатор пользователя, которому следует отправить запрос.
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }

	/// <summary>
	/// Текст запроса.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Тип запроса, может принимать значения:.
	/// </summary>
	[JsonPropertyName("type")]
	public AppRequestType? Type { get; set; }

	/// <summary>
	/// Уникальное в рамках приложения имя для каждого вида отправляемого запроса.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Строка, которая будет возвращена назад при переходе пользователя по запросу в
	/// приложение. Может использоваться для
	/// подсчета конверсии.
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Запрет на группировку запроса с другими, имеющими тот же name. По умолчанию
	/// отключен.
	/// </summary>
	[JsonPropertyName("separate")]
	public bool Separate { get; set; }
}