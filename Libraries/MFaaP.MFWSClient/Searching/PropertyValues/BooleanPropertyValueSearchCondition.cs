using System;

namespace MFaaP.MFWSClient
{
	/// <summary>
	/// Represents a search condition that restricts by a boolean property value.
	/// </summary>
	[Serializable]
	public class BooleanPropertyValueSearchCondition
		: PropertyValueSearchConditionBase<bool>
	{
		/// <summary>
		/// Creates a <see cref="BooleanPropertyValueSearchCondition"/>, searching for the value supplied.
		/// </summary>
		/// <param name="propertyDefId">The Id of the property def to search by.</param>
		/// <param name="value">The value to search by.</param>
		/// <param name="searchConditionOperator">The operator to use (defaults to Equals if not provided).</param>
		/// <param name="invertOperator">Whether to invert the search operator (defaults to false if not provided).</param>
		public BooleanPropertyValueSearchCondition(
			int propertyDefId,
			bool value,
			SearchConditionOperators searchConditionOperator = SearchConditionOperators.Equals,
			bool invertOperator = false)
			: base(propertyDefId, value, searchConditionOperator, invertOperator)
		{
		}

		/// <inheritdoc />
		public override string EncodedValue => this.Value ? "true" : "false";
	}
}