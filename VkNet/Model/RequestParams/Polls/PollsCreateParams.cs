using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Список параметров для метода polls.create
/// </summary>
[Serializable]
public class PollsCreateParams
{
	/// <summary>
	/// Текст опроса.
	/// </summary>
	[JsonPropertyName("question")]
	public string Question { get; set; }

	/// <summary>
	/// Идентификатор владельца опроса.
	/// True – анонимный опрос, список проголосовавших недоступен;
	/// False – опрос публичный, список проголосовавших доступен;
	/// По умолчанию – False.
	/// </summary>
	[JsonPropertyName("is_anonymous")]
	public bool? IsAnonymous { get; set; }

	/// <summary>
	/// <c>true</c> — для создания опроса с мультивыбором. флаг, может принимать значения <c>true</c> или <c>false</c>
	/// </summary>
	[JsonPropertyName("is_multiple")]
	public bool? IsMultiple { get; set; }

	/// <summary>
	/// Дата завершения опроса в Unixtime. положительное число, минимальное значение 1536692688
	/// </summary>
	[JsonPropertyName("end_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Если опрос будет добавлен в группу, необходимо передать отрицательный идентификатор группы.
	/// По умолчанию текущий пользователь.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Список вариантов ответов.
	/// </summary>
	[JsonPropertyName("add_answers")]
	public IEnumerable<string> AddAnswers { get; set; }

	/// <summary>
	/// Идентификатор фотографии для использования в качестве фона сниппета. положительное число
	/// </summary>
	[JsonPropertyName("photo_id")]
	public ulong? PhotoId { get; set; }

	/// <summary>
	/// Идентификатор стандартного фона для сниппета.
	/// </summary>
	[JsonPropertyName("background_id")]
	public long? BackgroundId { get; set; }
}