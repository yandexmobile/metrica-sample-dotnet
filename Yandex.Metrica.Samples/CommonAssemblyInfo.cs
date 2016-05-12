using System;
using System.Reflection;

[assembly: AssemblyCompany("Yandex")]
[assembly: AssemblyProduct("AppMetrica")]
[assembly: AssemblyCopyright("© YANDEX 2016")]
[assembly: AssemblyCulture("")]

#if SILVERLIGHT || NETFX_CORE
// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: System.Runtime.InteropServices.ComVisible(false)]
#endif

[assembly: AssemblyVersion("1.1.9999.9999")]
[assembly: AssemblyFileVersion("1.1.9999.9999")]

internal static class AssemblyProperties
{
    public static Version Version
    {
        get { return new Version("1.1.9999.9999"); }
    }

    public static string Edition
    {
        get
        {
#if YMM_DESKTOP
            return "1";
#elif YMM_WINRT
            return "2";
#elif YMM_WINRT81
            return "3";
#elif YMM_WP8
            return "4";
#elif YMM_WP81
            return "5";
#else
            return "0";
#endif
        }
    }
}
