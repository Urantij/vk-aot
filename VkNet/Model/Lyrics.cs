using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Текст аудиозаписи.
/// См. описание http://vk.com/dev/audio.getLyrics
/// </summary>
[Serializable]
public class Lyrics
{
	/// <summary>
	/// Идентификатор текста аудиозаписи.
	/// </summary>
	[JsonPropertyName("lyrics_id")]
	public long Id { get; set; }

	/// <summary>
	/// Тест аудиозаписи. В качестве переводов строк в тексте используется '\n'.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }
}