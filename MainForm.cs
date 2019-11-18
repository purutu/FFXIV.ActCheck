using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FFActCheck
{
	public partial class MainForm : Form
	{
		private string _rundir;
		private string _appdata;
		private string _basedir;
		private string _cfgdir;

		private bool _ok_act = true;
		private bool _ok_hoz = true;

		private static string[] ConfigRes =
		{
			Properties.Resources.cfg_act,
			Properties.Resources.cfg_fcp,
			Properties.Resources.cfg_rmop,
			Properties.Resources.cfg_dfa,
			Properties.Resources.cfg_ping,
		};
		private static string[] ConfigFiles =
		{
			"Advanced Combat Tracker.config.xml",
			"FFXIV_ACT_Plugin.config.xml",
			"RainbowMage.OverlayPlugin.config.json",
			"ACT.DFAssist.config.xml",
			"ACT.FFXIVPing.config.xml"
		};

		public MainForm()
		{
			InitializeComponent();

#if DEBUG
			var prgdir = @"D:\FF14\act-20191118-full";
#else
            var prgdir = Environment.CurrentDirectory;
#endif

			_rundir = prgdir;
			_appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			_basedir = Path.Combine(prgdir, "AppData");
			_cfgdir = Path.Combine(_basedir, "Advanced Combat Tracker", "Config");

			TxtActPath.Text = prgdir;

			TestEnvironment();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnTest_Click(object sender, EventArgs e)
		{
			TestEnvironment();
		}

		private void BtnSetting_Click(object sender, EventArgs e)
		{
			var r = MessageBox.Show(this,
				"ACT는 끄고 누르시는거 맞습니까?!!\n\nFF14는 안꺼도 됩니다", "확인해야함미다!",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (r == DialogResult.Yes)
				SettingUp();
		}

		private void BtnConfig_Click(object sender, EventArgs e)
		{
			var r = MessageBox.Show(this,
				"설정 파일을 만듭니다!\n\n기존 설정은 지워질 수 있습니다!!!", "확인해야함미다!",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (r == DialogResult.Yes)
				ConfigUp();
		}

		private void TestEnvironment()
		{
			string base_act = Path.Combine(_basedir, "Advanced Combat Tracker");
			string base_hoz = Path.Combine(_basedir, "anoyetta");

			bool ok_act = Directory.Exists(base_act);
			bool ok_ayo = Directory.Exists(base_hoz);

			_ok_act = CheckJuntion(base_act, Path.Combine(_appdata, "Advanced Combat Tracker"), out string rsn_act);
			_ok_hoz = CheckJuntion(base_hoz, Path.Combine(_appdata, "anoyetta"), out string rsn_ayo);

			//
			LstResult.Items.Clear();
			LstResult.Items.Add(MakeListViewItem(ok_act, "ACT 데이터", ok_act ? "정상입니다" : "찾을 수 없습니다"));
			LstResult.Items.Add(MakeListViewItem(ok_ayo, "Hojoring 데이터", ok_act ? "정상입니다" : "찾을 수 없습니다"));
			LstResult.Items.Add(MakeListViewItem(_ok_act, "ACT 연결", rsn_act));
			LstResult.Items.Add(MakeListViewItem(_ok_hoz, "Hojoring 연결", rsn_ayo));

			//
			if (ok_act && ok_ayo)
				BtnSetting.Enabled = !_ok_act || !_ok_hoz;
			else
			{
				BtnSetting.Enabled = false;
				BtnSetting.Text = "ACT가 이상합니다\n다시 설치하세요";
				LstResult.Items.Add(MakeListViewItem(false, "오류!", "ACT가 이상합니다, 다시 설치하세요"));
			}

			// 설정파일검사
			if (!Directory.Exists(_cfgdir))
			{
				LstResult.Items.Add(MakeListViewItem(false, "설정 핑;ㄹ", "설정 디렉터리가 없습니다!"));
				BtnConfig.Enabled = false;
				return;
			}

			bool needconfig = false;

			foreach (var s in ConfigFiles)
			{
				var fn = Path.Combine(_cfgdir, s);
				if (!File.Exists(fn))
					needconfig = true;
			}

			if (needconfig)
				LstResult.Items.Add(MakeListViewItem(false, "설정 파일", "설정 파일이 누락됐습니다. 만드세요"));

			BtnConfig.Enabled = true;
		}

		private void SettingUp()
		{
			if (!_ok_act)
				MakeJunction(Path.Combine(_basedir, "Advanced Combat Tracker"), Path.Combine(_appdata, "Advanced Combat Tracker"));

			if (!_ok_hoz)
				MakeJunction(Path.Combine(_basedir, "anoyetta"), Path.Combine(_appdata, "anoyetta"));

			TestEnvironment();

			LstResult.Items.Add(MakeListViewItem(true, "환경 설정", "환경 설정을 완료했습니다"));

			BtnSetting.Enabled = false;
		}

		private void ConfigUp()
		{
			string basedir = _rundir;
			string baseunix = _rundir.Replace('\\', '/');
			string cfghojoring = ChkCfgUseHojoring.Checked ? "True" : "False";

			bool isok = true;

			for (var i=0; i<ConfigFiles.Length;i++)
			{
				var txt = ConfigRes[i].Replace("%BASEDIR%", basedir).
					Replace("%BASEUNIX%", baseunix).
					Replace("%CFGHOJORING%", cfghojoring);

				try
				{
					File.WriteAllText(_cfgdir + "\\" + ConfigFiles[i], txt, System.Text.Encoding.UTF8);
					LstResult.Items.Add(MakeListViewItem(true, ConfigFiles[i], "처리했습니다"));
				}
				catch (Exception)
				{
					LstResult.Items.Add(MakeListViewItem(false, ConfigFiles[i], "파일을 만들 수 없습니다"));
					isok = false;
				}
			}

			TestEnvironment();

			LstResult.Items.Add(MakeListViewItem(isok, "설정 파일", "작업을 마무리했습니다"));
		}

		private static void MakeJunction(string bn, string an)
		{
			if (Directory.Exists(an))
			{
				if (JunctionPoint.Exists(an))
				{
					JunctionPoint.Delete(an);
				}
				else
				{
					DirectoryInfo di = new DirectoryInfo(an);
					FileInfo[] fs = di.GetFiles("*.*", SearchOption.AllDirectories);

					foreach (var f in fs)
						f.Attributes = FileAttributes.Normal;

					Directory.Delete(an, true);
				}
			}

			JunctionPoint.Create(bn, an, true);
		}

		private static ListViewItem MakeListViewItem(bool ok, string title, string result)
		{
			ListViewItem li = new ListViewItem(title, ok ? 1 : 0);
			li.SubItems.Add(result);
			return li;
		}

		private static bool CheckJuntion(string bn, string an, out string rsn)
		{
			try
			{
				if (!JunctionPoint.Exists(an))
					rsn = "설정이 필요합니다";
				else
				{
					if (!string.Equals(JunctionPoint.GetTarget(an), bn))
						rsn = "다른 프로그램에서 설정되어 있을 수 있습니다";
					else
					{
						rsn = "정상입니다";
						return true;
					}
				}
			}
			catch
			{
				// 이거 정션이 아니네
				rsn = "다른 프로그램이 만든 디렉토리가 있습니다";
			}

			return false;
		}
	}
}
