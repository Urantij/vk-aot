using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Массив объектов UserSpecification
/// </summary>
[Serializable]
public class AdSpecification
{
	/// <summary>
	/// Идентификатор кампании.
	/// </summary>
	[JsonPropertyName("campaign_id")]
	public long CampaignId { get; set; }

	/// <summary>
	/// Формат объявления
	/// </summary>
	[JsonPropertyName("ad_format")]
	public AdFormat AdFormat { get; set; }

	/// <summary>
	/// Автоматическое управление ценой
	/// </summary>
	[JsonPropertyName("autobidding")]
	public AutoBidding AutoBidding { get; set; }

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[JsonPropertyName("cost_type")]
	public CostType CostType { get; set; }

	/// <summary>
	/// Цена за переход в копейках. (если cost_type = 0)
	/// </summary>
	[JsonPropertyName("cpc")]
	public double Cpc { get; set; }

	/// <summary>
	/// Цена за 1000 показов в копейках. (если cost_type = 1)
	/// </summary>
	[JsonPropertyName("cpm")]
	public double Cpm { get; set; }

	/// <summary>
	/// Цена указывается в рублях с копейками в дробной части. (если cost_type = 1)
	/// </summary>
	[JsonPropertyName("ocpm")]
	public double OCpm { get; set; }

	/// <summary>
	/// Тип цели.
	/// </summary>
	[JsonPropertyName("goal_type")]
	public GoalType GoalType { get; set; }

	/// <summary>
	/// (если задано) Ограничение количества показов данного объявления на одного пользователя.
	/// Может присутствовать для некоторых форматов объявлений, для которых разрешена установка точного значения.
	/// </summary>
	[JsonPropertyName("impressions_limit")]
	public long ImpressionsLimit { get; set; }

	/// <summary>
	/// (если задано) Признак того, что количество показов объявления на одного пользователя ограничено.
	/// Может присутствовать для некоторых объявлений, для которых разрешена установка ограничения, но не разрешена установка точного значения.
	/// 1 — не более 100 показов на одного пользователя.
	/// </summary>
	[JsonPropertyName("impressions_limited")]
	public long ImpressionsLimited { get; set; }

	/// <summary>
	/// Рекламные площадки, на которых будет показываться объявление. (если значение применимо к данному формату объявления)
	/// </summary>
	[JsonPropertyName("ad_platform")]
	public AdPlatform? AdPlatform { get; set; }

	/// <summary>
	/// 1 — для объявления задано ограничение «Не показывать на стенах сообществ».
	/// </summary>
	[JsonPropertyName("ad_platform_no_wall")]
	public bool AdPPlatformNoWall { get; set; }

	/// <summary>
	/// 1 — для объявления задано ограничение «Показывать в рекламной сети».
	/// </summary>
	[JsonPropertyName("ad_platform_no_ad_network")]
	public bool AdPlatformNoAdNetwork { get; set; }

	/// <summary>
	/// Общий лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("all_limit")]
	public long AllLimit { get; set; }

	/// <summary>
	/// Дневной лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("day_limit")]
	public long DayLimit { get; set; }

	/// <summary>
	/// Ограничение по возрасту
	/// </summary>
	[JsonPropertyName("age_restriction")]
	public AdAgeRestriction AgeRestriction { get; set; }

	/// <summary>
	/// Время создания объявления
	/// </summary>
	[JsonPropertyName("create_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? CreateTime { get; set; }

	/// <summary>
	/// Время последнего изменения объявления
	/// </summary>
	[JsonPropertyName("update_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? UpdateTime { get; set; }

	/// <summary>
	/// ID тематики или подраздела тематики объявления.
	/// </summary>
	[JsonPropertyName("category1_id")]
	public long Category1Id { get; set; }

	/// <summary>
	/// ID тематики или подраздела тематики объявления. Дополнительная тематика.
	/// </summary>
	[JsonPropertyName("category2_id")]
	public long Category2Id { get; set; }

	/// <summary>
	/// Cтатус объявления.
	/// </summary>
	[JsonPropertyName("status")]
	public AdStatus Status { get; set; }

	/// <summary>
	/// Название объявления.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Заголовок объявления.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Описание объявления.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Cсылка на рекламируемый объект в формате.
	/// http://yoursite.cоm, или
	/// https://vk.com/wall-22822305_383737, или
	/// http://vk.cоm/club1
	/// </summary>
	[JsonPropertyName("link_url")]
	public Uri LinkUrl { get; set; }

	/// <summary>
	/// домен рекламируемого объекта в формате
	/// yoursite.cоm
	/// </summary>
	[JsonPropertyName("link_domain")]
	public Uri LinkDomain { get; set; }

	/// <summary>
	/// Заголовок рядом с кнопкой.
	/// </summary>
	[JsonPropertyName("link_title")]
	public Uri LinkTitle { get; set; }

	/// <summary>
	/// Идентификатор кнопки объявления.
	/// </summary>
	[JsonPropertyName("link_button")]
	public Uri LinkButton { get; set; }

	/// <summary>
	/// Основное изображение.
	/// </summary>
	[JsonPropertyName("photo")]
	public UploadUrlResult Photo { get; set; }

	/// <summary>
	/// Основное видео.
	/// </summary>
	[JsonPropertyName("video")]
	public UploadUrlResult Video { get; set; }

	/// <summary>
	/// Зацикливание видео.
	/// </summary>
	[JsonPropertyName("repeat_video")]
	public RepeatVideo RepeatVideo { get; set; }

	/// <summary>
	/// Включено отображение предупреждения: «Есть противопоказания.Требуется консультация специалиста.»
	/// </summary>
	[JsonPropertyName("disclaimer_medical")]
	public long DisclaimerMedical { get; set; }

	/// <summary>
	/// Включено отображение предупреждения: «Необходима консультация специалистов.»
	/// </summary>
	[JsonPropertyName("disclaimer_specialist")]
	public long DisclaimerSpecialist { get; set; }

	/// <summary>
	/// Включено отображение предупреждения: «БАД.Не является лекарственным препаратом.»
	/// </summary>
	[JsonPropertyName("disclaimer_supplements")]
	public long DisclaimerSupplements { get; set; }
}