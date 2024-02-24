using System.Reflection;
using System.Windows.Forms;

internal static class Class45
{
	internal static string smethod_0(Assembly assembly)
	{
		if (!(assembly == typeof(Class45).Assembly))
		{
			return assembly.Location;
		}
		return Application.ExecutablePath;
	}
}
