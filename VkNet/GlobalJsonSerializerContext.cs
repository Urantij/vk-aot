using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using VkNet.Model;
using VkNet.Utils.JsonConverter;

namespace VkNet;

public static class GlobalJsonSerializerOptions
{
	public static JsonSerializerOptions Options { get; } = new JsonSerializerOptions()
	{
		TypeInfoResolver = GlobalJsonSerializerContext.Default
	};
}

// Почему прямо в руте, а не в утилс например? Да он там потеряется, ептыть
[JsonSerializable(typeof(AmountObject))]
public partial class GlobalJsonSerializerContext : JsonSerializerContext
{
}

public enum Formatting
{
	None,

	Indented
}

// https://stackoverflow.com/a/73418854
[AttributeUsage(AttributeTargets.Property)]
public class DateTimeToStringFormatAttribute : JsonConverterAttribute
{
	private readonly string _format;

	public DateTimeToStringFormatAttribute(string format)
	{
		_format = format;
	}

	public override JsonConverter CreateConverter(Type typeToConvert)
	{
		if (typeToConvert != typeof(DateTime))
		{
			throw new ArgumentException($"{nameof(DateTimeToStringFormatAttribute)} bad {nameof(typeToConvert)} ({typeToConvert.Name})");
		}

		return new DateTimeToStringFormatConverter(_format);
	}
}

public class VkCollectionConverterAttribute<T> : JsonConverterAttribute
{
	[CanBeNull]
	private readonly string _collectionField;

	public VkCollectionConverterAttribute(string collectionField)
	{
		_collectionField = collectionField;
	}

	public VkCollectionConverterAttribute()
	{
		_collectionField = null;
	}

	public override JsonConverter CreateConverter(Type typeToConvert)
	{
		if (typeToConvert != typeof(DateTime))
		{
			throw new ArgumentException($"{nameof(VkCollectionConverterAttribute<T>)} bad {nameof(typeToConvert)} ({typeToConvert.Name})");
		}

		if (_collectionField != null)
			return new VkCollectionJsonConverter<T>(_collectionField);

		return new VkCollectionJsonConverter<T>();
	}
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false)]
public class LowerCaseWithDigitJsonStringEnumConverterAttribute<T> : JsonConverterAttribute
	where T : struct, Enum
{
	public override JsonConverter CreateConverter(Type typeToConvert)
	{
		if (typeToConvert != typeof(DateTime))
		{
			throw new ArgumentException($"{nameof(LowerCaseWithDigitJsonStringEnumConverterAttribute<T>)} bad {nameof(typeToConvert)} ({typeToConvert.Name})");
		}

		return new JsonStringEnumConverter<T>(new LowerCaseWithDigitNamingStrategy());
	}
}