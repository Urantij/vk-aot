using System.Text.Json;
using System.Text.Json.Nodes;
using VkNet.Model;

namespace VkNet.Utils;

/// <summary>
/// Сервис для обработки вложений
/// </summary>
public class AttachmentConverterService
{
	/// <summary>
	/// Инстанция сервиса.
	/// Может быть переопределена кастомной реализацией
	/// </summary>
	public static AttachmentConverterService Instance { get; set; } = new();

	/// <summary>
	/// Десериализация из json
	/// </summary>
	/// <param name="item">JSON элемент</param>
	/// <returns>
	/// Вложение
	/// </returns>
	public virtual Attachment FromJson(JsonNode item)
	{
		var type = item["type"]
			.ToString();

		var typeToken = item[type];

		var attachment = type switch
		{
			"link" => CreateTyped(typeToken
				.Deserialize<Link>(GlobalJsonSerializerOptions.Options)),
			"photo" or "posted_photo" => CreateTyped(typeToken
				.Deserialize<Photo>(GlobalJsonSerializerOptions.Options)),
			"audio" => CreateTyped(typeToken
				.Deserialize<Audio>(GlobalJsonSerializerOptions.Options)),
			"video" => CreateTyped(typeToken
				.Deserialize<Video>(GlobalJsonSerializerOptions.Options)),
			"doc" => CreateTyped(typeToken
				.Deserialize<Document>(GlobalJsonSerializerOptions.Options)),
			"podcast" => CreateTyped(typeToken
				.Deserialize<Podcast>(GlobalJsonSerializerOptions.Options)),
			"article" => CreateTyped(typeToken
				.Deserialize<Article>(GlobalJsonSerializerOptions.Options)),
			"event" => CreateTyped(typeToken
				.Deserialize<Event>(GlobalJsonSerializerOptions.Options)),
			"graffiti" => CreateTyped(typeToken
				.Deserialize<Graffiti>(GlobalJsonSerializerOptions.Options)),
			"money_transfer" => CreateTyped(typeToken
				.Deserialize<MoneyTransfer>(GlobalJsonSerializerOptions.Options)),
			"money_request" => CreateTyped(typeToken
				.Deserialize<MoneyRequest>(GlobalJsonSerializerOptions.Options)),
			"note" => CreateTyped(typeToken
				.Deserialize<Note>(GlobalJsonSerializerOptions.Options)),
			"poll" => CreateTyped(typeToken
				.Deserialize<Poll>(GlobalJsonSerializerOptions.Options)),
			"page" => CreateTyped(typeToken
				.Deserialize<Page>(GlobalJsonSerializerOptions.Options)),
			"album" => CreateTyped(typeToken
				.Deserialize<Album>(GlobalJsonSerializerOptions.Options)),
			"photos_list" => CreateTyped(typeToken
				.Deserialize<PhotosList>(GlobalJsonSerializerOptions.Options)),
			"wall" => CreateTyped(typeToken
				.Deserialize<Wall>(GlobalJsonSerializerOptions.Options)),
			"sticker" => CreateTyped(typeToken
				.Deserialize<Sticker>(GlobalJsonSerializerOptions.Options)),
			"wall_reply" => CreateTyped(typeToken
				.Deserialize<WallReply>(GlobalJsonSerializerOptions.Options)),
			"market_album" => CreateTyped(typeToken
				.Deserialize<MarketAlbum>(GlobalJsonSerializerOptions.Options)),
			"market" => CreateTyped(typeToken
				.Deserialize<Market>(GlobalJsonSerializerOptions.Options)),
			"pretty_cards" => CreateTyped(typeToken
				.Deserialize<PrettyCards>(GlobalJsonSerializerOptions.Options)),
			"audio_message" => CreateTyped(typeToken
				.Deserialize<AudioMessage>(GlobalJsonSerializerOptions.Options)),
			"call" => CreateTyped(typeToken
				.Deserialize<Call>(GlobalJsonSerializerOptions.Options)),
			"story" => CreateTyped(typeToken
				.Deserialize<Story>(GlobalJsonSerializerOptions.Options)),
			"audio_playlist" => CreateTyped(typeToken
				.Deserialize<AudioPlaylist>(GlobalJsonSerializerOptions.Options)),
			var _ => CreateTyped(typeToken
				.Deserialize<UnknownAttachment>(GlobalJsonSerializerOptions.Options))
		};

		return attachment;
	}

	/// <summary>
	/// Создает экземпляр Attachment
	/// </summary>
	/// <param name="instance">Вложение</param>
	/// <returns>
	/// Вложение
	/// </returns>
	protected virtual Attachment CreateTyped<TAttachment>(TAttachment instance)
		where TAttachment : MediaAttachment
	{
		var attachment = new Attachment
		{
			Type = typeof(TAttachment),
			Instance = instance
		};

		return attachment;
	}
}