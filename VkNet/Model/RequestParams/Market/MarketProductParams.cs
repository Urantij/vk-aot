using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Abstractions;

namespace VkNet.Model;

/// <summary>
/// Параметр для добавления / редактирования товара
/// </summary>
[Serializable]
public class MarketProductParams
{
	/// <summary>
	/// Идентификатор владельца товара. Обратите внимание, идентификатор сообщества в
	/// параметре owner_id необходимо
	/// указывать со знаком "-" — например, owner_id=-1 соответствует идентификатору
	/// сообщества ВКонтакте API (club1)
	/// целое число, обязательный параметр (целое число, обязательный параметр).
	/// </summary>
	[JsonPropertyName("photo_ids")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Идентификатор товара.
	/// </summary>
	/// <remarks>
	/// Только для метода <see cref="IMarketsCategory.Edit"/>
	/// </remarks>
	[JsonPropertyName("item_id")]
	public long? ItemId { get; set; }

	/// <summary>
	/// Название товара. строка, минимальная длина 4, максимальная длина 100,
	/// обязательный параметр (строка, минимальная
	/// длина 4, максимальная длина 100, обязательный параметр).
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Описание товара. строка, минимальная длина 10, обязательный параметр (строка,
	/// минимальная длина 10, обязательный
	/// параметр).
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Идентификатор категории товара. положительное число, обязательный параметр
	/// (положительное число, обязательный
	/// параметр).
	/// </summary>
	[JsonPropertyName("category_id")]
	public long CategoryId { get; set; }

	/// <summary>
	/// Цена товара. дробное число, обязательный параметр, минимальное значение 0.01
	/// (дробное число, обязательный параметр,
	/// минимальное значение 0.01).
	/// </summary>
	[JsonPropertyName("price")]
	public decimal Price { get; set; }

	/// <summary>
	/// Цена товара. дробное число, обязательный параметр, минимальное значение 0.01
	/// (дробное число, обязательный параметр,
	/// минимальное значение 0.01).
	/// </summary>
	[JsonPropertyName("old_price")]
	public decimal OldPrice { get; set; }

	/// <summary>
	/// Статус товара (1 — товар удален, 0 — товар не удален). флаг, может принимать
	/// значения 1 или 0 (флаг, может
	/// принимать значения 1 или 0).
	/// </summary>
	[JsonPropertyName("deleted")]
	public bool Deleted { get; set; }

	/// <summary>
	/// Идентификатор фотографии обложки товара. положительное число, обязательный
	/// параметр (положительное число,
	/// обязательный параметр).
	/// </summary>
	[JsonPropertyName("main_photo_id")]
	public long MainPhotoId { get; set; }

	/// <summary>
	/// Идентификаторы дополнительных фотографий товара. список положительных чисел,
	/// разделенных запятыми, количество
	/// элементов должно составлять не более 4 (список положительных чисел, разделенных
	/// запятыми, количество элементов
	/// должно составлять не более 4).
	/// </summary>
	[JsonPropertyName("photo_ids")]
	public IEnumerable<long> PhotoIds { get; set; }

	/// <summary>
	///  Идентификаторы видео товара.
	///  Видео должно быть загружено в сообщество и быть доступным для просмотра, в UI отображается только один элемент.
	///  <see xlink="https://dev.vk.com/ru/api/upload/photo-in-market#%D0%9E%D1%82%D0%B2%D0%B5%D1%82"/>
	/// </summary>
	[JsonPropertyName("video_ids")]
	public IEnumerable<long> VideoIds { get; set; }

	/// <summary>
	/// Ссылка на сайт товара.
	/// </summary>
	/// <remarks>
	/// Строка, минимальная длина 0, максимальная длина 320
	/// </remarks>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Список id вариантов свойств товаров.
	/// Не более 2 значений разных свойств.
	/// Если товар уже в группе, порядок свойств всех товаров группы должен совпадать,
	/// а набор свойств должен быть уникален для каждого товара.
	/// </summary>
	[JsonPropertyName("variant_ids")]
	public IEnumerable<long> VariantIds { get; set; }

	/// <summary>
	/// Признак, является ли товар главным в своей группе.
	/// </summary>
	[JsonPropertyName("is_main_variant")]
	public bool IsMainVariant { get; set; }

	/// <summary>
	/// Ширина в миллиметрах.
	/// </summary>
	[JsonPropertyName("dimension_width")]
	public int DimensionWidth { get; set; }

	/// <summary>
	/// Высота в миллиметрах.
	/// </summary>
	[JsonPropertyName("dimension_height")]
	public int DimensionHeight { get; set; }

	/// <summary>
	/// Глубина в миллиметрах.
	/// </summary>
	[JsonPropertyName("dimension_length")]
	public int DimensionLength { get; set; }

	/// <summary>
	/// Вес в граммах.
	/// </summary>
	[JsonPropertyName("weight")]
	public int Weight { get; set; }

	/// <summary>
	/// Артикул товара, произвольная строка
	/// </summary>
	[JsonPropertyName("sku")]
	public string Sku { get; set; }
}