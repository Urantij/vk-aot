using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Новая запись на стене (<c>WallPost</c>, <c>WallRepost</c>)
/// (<c>Post</c> с дополнительными полями)
/// </summary>
[Serializable]
public class WallPost : Post, IGroupUpdate
{
	/// <summary>
	/// <c>Id</c> отложенной записи
	/// </summary>
	[JsonPropertyName("postponed_id")]
	public long? PostponedId { get; set; }
}