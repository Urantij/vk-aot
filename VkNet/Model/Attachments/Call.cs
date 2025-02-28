using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Вложение "Звонок".
/// </summary>
[Serializable]
[DebuggerDisplay("[{InitiatorId} - {ReceiverId}: {State}]")]
public class Call : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "call";

	/// <summary>
	/// Идентификатор инициатора звонка.
	/// </summary>
	[JsonPropertyName("initiator_id")]
	public long InitiatorId { get; set; }

	/// <summary>
	/// Идентификатор получателя звонка.
	/// <remarks>
	/// Для чатов - если инициатором звонка является не тот же самый аккаунт, с которого делается запрос,
	/// это поле содержит Id чата, локальном для инициатора, а не для текущего аккаунта.
	/// Это означает, что получатель звонка может отличаться от Id чата, в который было отправлено сообщение, содержащее звонок.
	/// </remarks>
	/// </summary>
	[JsonPropertyName("receiver_id")]
	public long ReceiverId { get; set; }

	/// <summary>
	/// Состояние вызова.
	/// <remarks>
	/// Известно только про состояние <b>reached</b>
	/// </remarks>
	/// </summary>
	[JsonPropertyName("state")]
	public string State { get; set; }

	/// <summary>
	/// Длительность вызова в секундах
	/// </summary>
	[JsonPropertyName("duration")]
	public long? Duration { get; set; }

	/// <summary>
	/// Время начала звонка.
	/// <remarks>
	/// Обычно совпадает с временем создания соответствующего сообщения.
	/// </remarks>
	/// </summary>
	[JsonPropertyName("time")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Time { get; set; }

	/// <summary>
	/// Было ли использовано видео в звонке
	/// </summary>
	[JsonPropertyName("video")]
	public bool? Video { get; set; }
}