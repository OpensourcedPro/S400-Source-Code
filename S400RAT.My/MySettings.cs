using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.2.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	public static MySettings defaultInstance;

	public static bool addedHandler;

	public static object addedHandlerLockObject;

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						Class2.FEo51Ss0j.Shutdown += [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
						{
							if (Class2.FEo51Ss0j.SaveMySettingsOnExit)
							{
								MySettingsProperty.Settings.Save();
							}
						};
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("https://pastebin.com/raw/RA0D0Drd")]
	[DebuggerNonUserCode]
	public string Setting
	{
		get
		{
			return Conversions.ToString(this["Setting"]);
		}
		set
		{
			this["Setting"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://pastebin.com/raw/6uFy9vCY")]
	public string Setting1
	{
		get
		{
			return Conversions.ToString(this["Setting1"]);
		}
		set
		{
			this["Setting1"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("https://pastebin.com/raw/krReK92m")]
	[DebuggerNonUserCode]
	public string Setting2
	{
		get
		{
			return Conversions.ToString(this["Setting2"]);
		}
		set
		{
			this["Setting2"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public DateTime Fdate
	{
		get
		{
			return Conversions.ToDate(this["Fdate"]);
		}
		set
		{
			this["Fdate"] = value;
		}
	}

	static MySettings()
	{
		defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
		addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (Class2.FEo51Ss0j.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
