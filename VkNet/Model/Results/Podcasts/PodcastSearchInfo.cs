using System;
using System.Text.Json.Serialization;

namespace VkNet.Model
{
	/// <summary>
	/// Базовая информация о подкасте выданная поисковиком
	/// </summary>
	[Serializable]
	public class PodcastSearchInfo
	{
		/// <summary>
		/// URL адрес подкаста
		/// </summary>
		[JsonPropertyName("url")]
		public string Url { get; set; }

		/// <summary>
		/// URL владельца подкаста
		/// </summary>
		[JsonPropertyName("owner_url")]
		public string OwnerUrl { get; set; }

		/// <summary>
		/// Название подкаста
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }

		/// <summary>
		/// Имя владельца подкаста
		/// </summary>
		[JsonPropertyName("owner_name")]
		public string OwnerName { get; set; }

		/// <summary>
		/// Коллекция логотипов подкаста
		/// </summary>
		[JsonPropertyName("cover")]
		public Cover Covers { get; set; }
	}
}
