using System;

namespace AarquieSolutions.InspectorAttributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class ShowNativePropertyAttribute : SpecialCaseDrawerAttribute
	{
	}
}
