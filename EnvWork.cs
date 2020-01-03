using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFActCheck
{
	class EnvWork
	{
		public class Configuration
		{
			public bool Yukkiri = false;
			public bool Ultsco = false;
			public bool DFAssist = false;
			public bool Ping = false;

			public bool Horiz = false;
			public bool Kagerou = false;
			public bool Enmity = false;
			public bool Eureka = false;
			public bool Fish = false;

			public Dictionary<string, bool> Results = new Dictionary<string, bool>();
		}

		private static string[] ConfigFileNames =
		{
			"RainbowMage.OverlayPlugin.config.json",	// 첫번째에 있어야 한다!
			"Advanced Combat Tracker.config.xml",
			"FFXIV_ACT_Plugin.config.xml",
			"ACT.DFAssist.config.xml",
			"ACT.FFXIVPing.config.xml"
		};

		private static string[] ConfigContents =
		{
			"",
			Properties.Resources.cfg_act,
			Properties.Resources.cfg_fcp,
			Properties.Resources.cfg_dfa,
			Properties.Resources.cfg_ping,
		};

		//
		public string PathAct { get; }
		public string PathConfig { get; }
		public string PathAnoyetta { get; }
		public string PathAppData { get; }

		//
		public bool IsSourceActOk { get; private set; } = false;
		public bool IsSourceAnoyettaOk { get; private set; } = false;

		public bool IsTargetActOk { get; private set; } = false;
		public bool IsTargetAnoyettaOk { get; private set; } = false;
		public string ReasonTargetAct { get; internal set; }
		public string ReasonTargetAnoyetta { get; internal set; }

		//
		public bool ExistConfigDir { get; private set; } = false;
		public int ConfigFilesCount { get; private set; } = 0;
		public int MaxConfigFiles { get; private set; } = ConfigFileNames.Length;


		public EnvWork(string path = null)
		{
			if (path == null)
				path = Environment.CurrentDirectory;

			PathAct = path;
			PathConfig = Path.Combine(path, "Config");
			PathAnoyetta = Path.Combine(path, "Anoyetta");

			PathAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		}

		public void TestRuntime()
		{
			IsSourceActOk = Directory.Exists(PathAct);
			IsSourceAnoyettaOk = Directory.Exists(PathAnoyetta);

			var tgtAct = Junction.Check(PathAct, Path.Combine(PathAppData, "Advanced Combat Tracker"));
			var tgtAyo = Junction.Check(PathAnoyetta, Path.Combine(PathAppData, "anoyetta"));

			IsTargetActOk = tgtAct == Junction.Result.Ok;
			IsTargetAnoyettaOk = tgtAyo == Junction.Result.Ok;
			ReasonTargetAct = Junction.ResultToString(tgtAct);
			ReasonTargetAnoyetta = Junction.ResultToString(tgtAyo);

			// 설정파일
			ConfigFilesCount = 0;

			if (!Directory.Exists(PathConfig))
				ExistConfigDir = false;
			else
			{
				ExistConfigDir = true;

				foreach (var s in ConfigFileNames)
				{
					var fn = Path.Combine(PathConfig, s);
					if (File.Exists(fn))
						ConfigFilesCount++;
				}
			}
		}

		public void SetupRuntime()
		{
			if (!IsTargetActOk)
				Junction.Make(PathAct, Path.Combine(PathAppData, "Advanced Combat Tracker"));

			if (!IsTargetAnoyettaOk)
				Junction.Make(PathAnoyetta, Path.Combine(PathAppData, "anoyetta"));
		}

		public void WriteConfig(ref Configuration cfg)
		{
			var basedir = PathAct;
			var baseunix = PathAct.Replace('\\', '/');
			var appdata = PathAppData;

			var cfgyukkuri = cfg.Yukkiri.ToString();
			var cfgultsco = cfg.Ultsco.ToString();
			var cfgdfassist = cfg.DFAssist.ToString();
			var cfgping = cfg.Ping.ToString();

			// 레인보우먼저 조합한다
			StringBuilder rmop = new StringBuilder();
			rmop.Append(Properties.Resources.cfg_rmop_basis_head);
			if (cfg.Horiz)
				rmop.Append(Properties.Resources.cfg_rmop_item_horiz);
			if (cfg.Kagerou)
				rmop.Append(Properties.Resources.cfg_rmop_item_kagerou);
			if (cfg.Enmity)
				rmop.Append(Properties.Resources.cfg_rmop_item_enmity);
			if (cfg.Eureka)
				rmop.Append(Properties.Resources.cfg_rmop_item_eureka);
			if (cfg.Fish)
				rmop.Append(Properties.Resources.cfg_rmop_item_fish);
			rmop.Append(Properties.Resources.cfg_rmop_basis_tail);
			ConfigContents[0] = rmop.ToString();

			//
			cfg.Results.Clear();

			for (var i = 0; i < ConfigFileNames.Length; i++)
			{
				var txt = ConfigContents[i]
					.Replace("%BASEDIR%", basedir)
					.Replace("%BASEUNIX%", baseunix)
					.Replace("%APPDATA%", appdata)
					.Replace("%CFGYUKKURI%", cfgyukkuri)
					.Replace("%CFGULTSCO%", cfgultsco)
					.Replace("%CFGPING%", cfgping)
					.Replace("%CFGDFASSIST%", cfgdfassist)
					;

				try
				{
					var path = Path.Combine(PathConfig, ConfigFileNames[i]);

					File.WriteAllText(path, txt, System.Text.Encoding.UTF8);
					cfg.Results.Add(ConfigFileNames[i], true);
				}
				catch (Exception)
				{
					cfg.Results.Add(ConfigFileNames[i], false);
				}
			}
		}
	}
}
