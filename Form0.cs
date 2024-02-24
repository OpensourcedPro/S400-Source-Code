using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		Class2.FEo51Ss0j.Run(args);
	}

	public Form0()
		: base(AuthenticationMode.Windows)
	{
		base.IsSingleInstance = false;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	protected override void OnCreateMainForm()
	{
		base.MainForm = Class2.XTBfo6WOm.License;
	}
}
