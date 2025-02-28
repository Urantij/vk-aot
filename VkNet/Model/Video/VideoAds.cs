using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// TODO: Undocumented structure which returns inside Video
/// <remarks>
/// This might be all the info for the end application to play ads in the video
/// </remarks>
/// </summary>
[Serializable]
public class VideoAds
{
	/// <summary>
	/// TODO: Undocumented
	/// <remarks>
	///	In my tests it contained basically random number
	/// </remarks>>
	/// </summary>
	[JsonPropertyName("slot_id")]
	public long? SlotId { get; set; }

	/// <summary>
	/// TODO: Undocumented
	/// </summary>
	[JsonPropertyName("timeout")]
	public float? Timeout { get; set; }

	/// <summary>
	/// TODO: Undocumented
	/// </summary>
	[JsonPropertyName("can_play")]
	public int? CanPlay { get; set; }

	/// <summary>
	/// TODO: Undocumented
	/// </summary>
	[JsonPropertyName("params")]
	public VideoAdsParams Params { get; set; }

	/// <summary>
	/// TODO: Undocumented
	/// <remarks>
	/// Known values are: <c> preroll </c>, <c> midroll </c>, <c> postroll </c>
	/// </remarks>
	/// </summary>
	[JsonPropertyName("sections")]
	public VideoAdsSection?[] Sections { get; set; }

	/// <summary>
	/// TODO: Undocumented
	/// <remarks>
	/// This field should be pointing to normalized video positions, where the ads
	/// should be played
	/// </remarks>
	/// </summary>
	[JsonPropertyName("midroll_percents")]
	public ReadOnlyCollection<float> MidrollPercents { get; set; }

	/// <summary>
	/// TODO: Undocumented
	/// <remarks>
	/// Должен ли преролл проигрываться автоматически ???
	/// </remarks>
	/// </summary>
	[JsonPropertyName("autoplay_preroll")]
	public int? AutoPlayPreroll { get; set; }
}