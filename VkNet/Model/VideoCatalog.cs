using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Данные для отображения блока видеокаталога
/// </summary>
[Serializable]
public class VideoCatalog
{
	/// <summary>
	/// Список элементов блока видеокаталога
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<VideoCatalogItem> Items { get; set; }

	/// <summary>
	/// Идентификатор блока. Возвращается строка для предопределенных блоков. Для
	/// других возвращается число.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Заголовок блока.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Параметр для получения следующей страницы результатов. Необходимо передать его
	/// значение в from в следующем вызове,
	/// чтобы получить содержимое каталога, следующее за полученным в текущем вызове.
	/// </summary>
	[JsonPropertyName("next")]
	public string Next { get; set; }

	/// <summary>
	/// предпочтительный способ отображения контента
	/// </summary>
	[JsonPropertyName("view")]
	public VideoView? View { get; set; }

	/// <summary>
	/// Наличие возможности скрыть блок.
	/// </summary>
	[JsonPropertyName("can_hide")]
	public bool? CanHide { get; set; }

	/// <summary>
	/// Тип блока.
	/// </summary>
	[JsonPropertyName("type")]
	public VideoCatalogType? Type { get; set; }
}