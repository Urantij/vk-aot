using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Высшее учебное заведение, в котором учился пользователь.
/// См. описание http://vk.com/dev/fields
/// </summary>
[Serializable]
public class University
{
	/// <summary>
	/// Идентификатор университета.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Идентификатор страны, в которой расположен университет.
	/// </summary>
	[JsonPropertyName("country")]
	public long? Country { get; set; }

	/// <summary>
	/// Идентификатор города, в котором расположен университет.
	/// </summary>
	[JsonPropertyName("city")]
	public long? City { get; set; }

	/// <summary>
	/// Наименование университета.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Идентификатор факультета.
	/// </summary>
	[JsonPropertyName("faculty")]
	public long? Faculty { get; set; }

	/// <summary>
	/// Название факультета.
	/// </summary>
	[JsonPropertyName("faculty_name")]
	public string FacultyName { get; set; }

	/// <summary>
	/// Идентификатор кафедры.
	/// </summary>
	[JsonPropertyName("chair")]
	public int? Chair { get; set; }

	/// <summary>
	/// Наименование кафедры.
	/// </summary>
	[JsonPropertyName("chair_name")]
	public string ChairName { get; set; }

	/// <summary>
	/// Год окончания обучения.
	/// </summary>
	[JsonPropertyName("graduation")]
	public int? Graduation { get; set; }

	[JsonPropertyName("title")]
	private string Title
	{
		get => Name;
		set => Name = value;
	}

	#region Поля, установленные экспериментально

	/// <summary>
	/// Форма обучения.
	/// </summary>
	[JsonPropertyName("education_form")]
	public string EducationForm { get; set; }

	/// <summary>
	/// Статус пользователя в университете.
	/// </summary>
	[JsonPropertyName("education_status")]
	public string EducationStatus { get; set; }

	#endregion
}