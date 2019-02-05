using System;
using System.IO;
using System.Windows.Forms;

namespace FFActCheck
{
    public partial class MainForm : Form
    {
        private string _appdata;
        private string _basedir;

        private bool _ok_act = true;
        private bool _ok_hoz = true;

        public MainForm()
        {
            InitializeComponent();

#if DEBUG
            var prgdir = @"D:\FF14\act";
#else
            var prgdir = Environment.CurrentDirectory;
#endif

            _appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _basedir = Path.Combine(prgdir, "AppData");

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
            }
        }

        private void SettingUp()
        {
            if (!_ok_act)
                MakeJunction(Path.Combine(_basedir, "Advanced Combat Tracker"), Path.Combine(_appdata, "Advanced Combat Tracker"));

            if (!_ok_hoz)
                MakeJunction(Path.Combine(_basedir, "anoyetta"), Path.Combine(_appdata, "anoyetta"));

            TestEnvironment();
            LstResult.Items.Add(MakeListViewItem(true, "설정 결과", "처리했습니다"));

            BtnSetting.Enabled = false;
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
