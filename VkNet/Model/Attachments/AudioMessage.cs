using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Аудио сообщение
/// </summary>
[Serializable]
public class AudioMessage : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "audio_message";

	/// <summary>
	/// Продолжительность
	/// </summary>
	[JsonPropertyName("duration")]
	public ulong Duration { get; set; }

	/// <summary>
	/// Форма волны
	/// </summary>
	[JsonPropertyName("waveform")]
	public ReadOnlyCollection<int> Waveform { get; set; }

	/// <summary>
	/// Ссылка на файл в ogg
	/// </summary>
	[JsonPropertyName("link_ogg")]
	public Uri LinkOgg { get; set; }

	/// <summary>
	/// Ссылка на файл в mp3
	/// </summary>
	[JsonPropertyName("link_mp3")]
	public Uri LinkMp3 { get; set; }

	/// <summary>
	/// Текст транскрипции
	/// </summary>
	[JsonPropertyName("transcript")]
	public string Transcript { get; set; }

	/// <summary>
	/// Статус транскрипции
	/// </summary>
	[JsonPropertyName("transcript_state")]
	public TranscriptStates? TranscriptState { get; set; }
}