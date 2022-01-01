using System;

namespace AarquieSolutions.InspectorAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ExpandableAttribute : DrawerAttribute
	{
	}
}
