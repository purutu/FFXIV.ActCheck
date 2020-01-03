using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFActCheck
{
	public partial class CheckForm : Form
	{
		private static string[] UiCultures =
			{
				Properties.Resources.Lang_en,
				Properties.Resources.Lang_ko ,
				Properties.Resources.Lang_ja
			};

		LineDb _lang;
		EnvWork _test;

		public CheckForm()
		{
			InitializeComponent();

			var culture = Thread.CurrentThread.CurrentUICulture;
			if (culture.Name.StartsWith("ko"))
				cboLanguage.SelectedIndex = 1;
			else if (culture.Name.StartsWith("ja"))
				cboLanguage.SelectedIndex = 2;
			else
				cboLanguage.SelectedIndex = 0;

			btnSetRuntime.Enabled = false;

			lstRuntime.DrawItem += LstRuntime_DrawItem;

			//
#if DEBUG
			_test = new EnvWork(@"D:\FF14\act-20200101-full");
#else
            _test = new EnvWork();
#endif
			txtActLocation.Text = _test.PathAct;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			var db = new LineDb(UiCultures[cboLanguage.SelectedIndex]);

			System.Version sv = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			DateTime bdt = new DateTime(2000, 1, 1).AddDays(sv.Build).AddSeconds(sv.Revision * 2);


			this.Text = db["Title"] + " - " + bdt.ToShortDateString();
			lblActLocation.Text = db["ActLocation"];
			tpCheck.Text = db["Check"];
			tpConfig.Text = db["Config"];
			tpExtra.Text = db["Extra"];

			// 
			btnCheckRuntime.Text = db["CheckRuntime"];
			btnSetRuntime.Text = db["SetRuntime"];
			btnSetRuntime.Enabled = false;
			lstRuntime.Items.Clear();
			lstRuntime.Items.Add(db["ClickCheck"]);

			//
			lblCfgConfigs.Text = db["CfgConfigs"];
			chkCfgHojoringYukkuri.Text = db["ItemYukkuri"];
			chkCfgHojoringUltsc.Text = db["ItemUltsco"];
			chkCfgDfassist.Text = db["ItemDfassist"];
			chkCfgPing.Text = db["ItemPing"];

			lblCfgOverlay.Text = db["CfgOverlay"];
			rdoOvHoriz.Text = db["ItemHoriz"];
			rdoOvKagerou.Text = db["ItemKagerou"];
			chkOvEnmity.Text = db["ItemEnmity"];
			chkOvEureka.Text = db["ItemEureka"];
			chkOvFish.Text = db["ItemFish"];

			chkIknowOverwrite.Text = db["IknowOverwrite"];
			btnCfgWrite.Text = db["CfgWrite"];

			//
			_lang = db;
		}

		private void LstRuntime_DrawItem(object sender, DrawItemEventArgs e)
		{
			lstRuntime.DrawMode = DrawMode.OwnerDrawFixed;
			Brush brush = Brushes.Black;

			e.DrawBackground();

			var item = lstRuntime.Items[e.Index].ToString();
			if (item.Length > 0)
			{
				var ch = item[0];
				if (ch == '*')
					brush = Brushes.Red;
				else if (ch == '+')
					brush = Brushes.Blue;
				else if (ch == '-')
					brush = Brushes.DarkOrange;
			}

			e.Graphics.DrawString(item, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
			e.DrawFocusRectangle();
		}

		private string BuildResultString(string who, string where, bool result, string reason = null)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(result ? '+' : '-');
			sb.Append(who).Append(' ').Append(_lang[where]).Append(" - ");

			if (reason != null)
				sb.Append(_lang[reason]);
			else
			{
				var r = _lang[result ? "TestOk" : "TestFail"];
				sb.Append(r);
			}

			return sb.ToString();
		}

		private void DoCheckRuntime(bool showconfignow)
		{
			_test.TestRuntime();

			lstRuntime.Items.Add(BuildResultString("ACT", "Source", _test.IsSourceActOk));
			lstRuntime.Items.Add(BuildResultString("Anoyetta", "Source", _test.IsSourceAnoyettaOk));
			lstRuntime.Items.Add(BuildResultString("ACT", "Target", _test.IsTargetActOk, _test.ReasonTargetAct));
			lstRuntime.Items.Add(BuildResultString("Anoyetta", "Target", _test.IsTargetAnoyettaOk, _test.ReasonTargetAnoyetta));

			if (_test.IsTargetActOk && _test.IsTargetAnoyettaOk)
				btnSetRuntime.Enabled = !_test.IsTargetActOk || !_test.IsTargetAnoyettaOk;
			else
			{
				btnSetRuntime.Enabled = false;
				lstRuntime.Items.Add("*" + _lang["NeedSettingUp"]);
			}

			lstRuntime.Items.Add("");

			//
			if (showconfignow)
			{
				lstRuntime.Items.Add(_lang["ChangeTabToConfig"]);
			}
			else
			{
				lstRuntime.Items.Add(string.Format("  {0} - {1}", _lang["ConfigPath"], _lang[_test.ExistConfigDir ? "TestOk" : "TestFail"]));
				lstRuntime.Items.Add(string.Format("  {0} - {1}/{2}", _lang["ConfigCount"], _test.ConfigFilesCount, _test.MaxConfigFiles));
			}

			//
			btnSetRuntime.Enabled = (!_test.IsTargetActOk || !_test.IsTargetAnoyettaOk);
		}

		private void btnCheckRuntime_Click(object sender, EventArgs e)
		{
			lstRuntime.Items.Clear();

			DoCheckRuntime(false);
		}

		private void btnSetRuntime_Click(object sender, EventArgs e)
		{
			lstRuntime.Items.Clear();

			_test.SetupRuntime();

			lstRuntime.Items.Add(_lang["FinishSetRuntime"]);
			lstRuntime.Items.Add("");

			DoCheckRuntime(true);
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			chkIknowOverwrite.Checked = false;
			btnCfgWrite.Enabled = false;
		}

		private void chkIknowOverwrite_CheckedChanged(object sender, EventArgs e)
		{
#if false
			if (!_test.IsTargetActOk || !_test.IsTargetAnoyettaOk)
				return;
#endif

			btnCfgWrite.Enabled = chkIknowOverwrite.Checked;
		}

		private void btnCfgWrite_Click(object sender, EventArgs e)
		{
			if (!chkIknowOverwrite.Checked)
				return;

			var cfg = new EnvWork.Configuration();
			cfg.Yukkiri = chkCfgHojoringYukkuri.Checked;
			cfg.Ultsco = chkCfgHojoringUltsc.Checked;
			cfg.DFAssist = chkCfgDfassist.Checked;
			cfg.Ping = chkCfgPing.Checked;
			cfg.Horiz = rdoOvHoriz.Checked;
			cfg.Kagerou = rdoOvKagerou.Checked;
			cfg.Enmity = chkOvEnmity.Checked;
			cfg.Eureka = chkOvEureka.Checked;
			cfg.Fish = chkOvFish.Checked;

			_test.WriteConfig(ref cfg);

			lstRuntime.Items.Clear();
			foreach (var i in cfg.Results)
			{
				StringBuilder sb = new StringBuilder();
				sb
					.Append(i.Value ? '+' : '-')
					.Append(_lang[i.Value ? "Success" : "Fail"])
					.Append(" - ")
					.Append(i.Key);
				lstRuntime.Items.Add(sb.ToString());
			}

			tabControl1.SelectedIndex = 0;
		}
	}
}
