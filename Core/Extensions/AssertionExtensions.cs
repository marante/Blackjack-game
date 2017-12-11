using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Core.Extensions
{
	public static class AssertionExtensions
	{
		/// <summary>
		/// Assertion method that ensures that <paramref name="this"/> is not null
		/// </summary>
		/// <param name="this">
		/// The object in which to ensure non-nullability upon
		/// </param>
		/// <param name="elementName">
		/// the parameter name of the object in which to ensure non-nullability upon
		/// </param>
		/// <param name="callerMemberName">
		/// Compiler-provided string of the method name containing this call
		/// </param>
		[ContractAnnotation("this:null => halt"), AssertionMethod]
		public static void IsNotNull(
			[AssertionCondition(AssertionConditionType.IS_NOT_NULL), NotNull] this object @this,
			[InvokerParameterName] string elementName,
			[CallerMemberName] string callerMemberName = "")
		{
			if (@this == null)
				throw new ArgumentNullException(
					elementName,
					$"Parameter {elementName.SQuote()} passed to the " +
					$"method {callerMemberName.SQuote()} cannot be null.");
		}


		[ContractAnnotation("this:null => halt"), AssertionMethod]
		public static void IsNotNullOrWhiteSpace(
			[AssertionCondition(AssertionConditionType.IS_NOT_NULL)] this string @this,
			[InvokerParameterName] string elementName,
			[CallerMemberName] string callerMemberName = null)
		{
			if (@this.IsNullOrWhiteSpace())
				throw new ArgumentException(
					elementName,
					$"Parameter {elementName.SQuote()} passed to the " +
					$"method {callerMemberName.SQuote()} cannot be null or whitespace.");
		}


		[ContractAnnotation("this:null => halt"), AssertionMethod]
		public static void IsNotNullOrEmptyEx(
			[AssertionCondition(AssertionConditionType.IS_NOT_NULL)] this string @this,
			[InvokerParameterName] string elementName,
			[CallerMemberName] string callerMemberName = null)
		{
			if (@this.IsNullOrWhiteSpace())
				throw new ArgumentException(
					elementName,
					$"Parameter {elementName.SQuote()} passed to the " +
					$"method {callerMemberName.SQuote()} cannot be null or whitespace.");
		}
	}
}
