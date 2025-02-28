using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о высшем учебном заведении пользователя.
/// См. описание http://vk.com/dev/fields
/// </summary>
[Serializable]
[JsonConverter(typeof(EducationJsonConverter))]
public class Education
{
	/// <summary>
	/// Идентификатор университета.
	/// </summary>
	[JsonPropertyName("university")]
	public long? UniversityId { get; set; }

	/// <summary>
	/// Название ВУЗа.
	/// </summary>
	[JsonPropertyName("university_name")]
	public string UniversityName { get; set; }

	/// <summary>
	/// Идентификатор факультета.
	/// </summary>
	[JsonPropertyName("faculty")]
	public long? FacultyId { get; set; }

	/// <summary>
	/// Название факультета.
	/// </summary>
	[JsonPropertyName("faculty_name")]
	public string FacultyName { get; set; }

	/// <summary>
	/// Год окончания.
	/// </summary>
	[JsonPropertyName("graduation")]
	public int? Graduation { get; set; }

	#region Поля, установленные экспериментально

	/// <summary>
	/// Форма обучения.
	/// </summary>
	[JsonPropertyName("education_form")]
	public string EducationForm { get; set; }

	/// <summary>
	/// Текущий статус пользователя в высшем учебном заведении.
	/// </summary>
	[JsonPropertyName("education_status")]
	public string EducationStatus { get; set; }

	#endregion
}