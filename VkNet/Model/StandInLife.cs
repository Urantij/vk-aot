using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Жизненная позиция (Personal).
/// Данная информация не документирована в официальном API ВКонтакте и
/// восстановлена по ответам.
/// </summary>
[Serializable]
public class StandInLife
{
	/// <summary>
	/// Политические предпочтения пользователя.
	/// </summary>
	[JsonPropertyName("political")]
	public PoliticalPreferences Political { get; set; }

	/// <summary>
	/// Языки, на которых говорит пользователь.
	/// </summary>
	[JsonPropertyName("langs")]
	public ReadOnlyCollection<string> Languages { get; set; }

	/// <summary>
	/// Мировоззрение пользователя.
	/// </summary>
	[JsonPropertyName("religion")]
	public string Religion { get; set; }

	/// <summary>
	/// Источники вдохновения пользователя.
	/// </summary>
	[JsonPropertyName("inspired_by")]
	public string InspiredBy { get; set; }

	/// <summary>
	/// Главное в людях для пользователя.
	/// </summary>
	[JsonPropertyName("people_main")]
	public PeopleMain PeopleMain { get; set; }

	/// <summary>
	/// Главное в жизни для пользователя.
	/// </summary>
	[JsonPropertyName("life_main")]
	public LifeMain LifeMain { get; set; }

	/// <summary>
	/// Отношение к курению.
	/// </summary>
	[JsonPropertyName("smoking")]
	public Attitude Smoking { get; set; }

	/// <summary>
	/// Отношение к алкоголю.
	/// </summary>
	[JsonPropertyName("alcohol")]
	public Attitude Alcohol { get; set; }
}