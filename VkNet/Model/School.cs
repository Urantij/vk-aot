using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Школа, в которой учился пользователь.
/// См. описание http://vk.com/dev/fields
/// </summary>
[Serializable]
public class School
{
	/// <summary>
	/// Идентификатор школы.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Идентификатор страны, в которой расположена школа.
	/// </summary>
	[JsonPropertyName("country")]
	public long? Country { get; set; }

	/// <summary>
	/// Идентификатор города, в котором расположена школа.
	/// </summary>
	[JsonPropertyName("city")]
	public long? City { get; set; }

	/// <summary>
	/// Наименование школы.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Год начала обучения.
	/// </summary>
	[JsonPropertyName("year_from")]
	public int? YearFrom { get; set; }

	/// <summary>
	/// Год окончания обучения.
	/// </summary>
	[JsonPropertyName("year_to")]
	public int? YearTo { get; set; }

	/// <summary>
	/// Год выпуска.
	/// </summary>
	[JsonPropertyName("year_graduated")]
	public int? YearGraduated { get; set; }

	/// <summary>
	/// Буква класса.
	/// </summary>
	[JsonPropertyName("class")]
	public string Class { get; set; }

	/// <summary>
	/// Специализация класса.
	/// </summary>
	[JsonPropertyName("speciality")]
	public string Speciality { get; set; }

	/// <summary>
	/// Идентификатор типа школы.
	/// </summary>
	[JsonPropertyName("type")]
	public long? Type { get; set; }

	/// <summary>
	/// Название типа школы.
	/// </summary>
	[JsonPropertyName("type_str")]
	public string TypeStr { get; set; }

	[JsonPropertyName("title")]
	private string Title
	{
		get => Name;
		set => Name = value;
	}
}