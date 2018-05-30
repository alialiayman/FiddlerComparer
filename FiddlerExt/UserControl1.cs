using System;
using System.IO;
using System.Windows.Forms;
using Fiddler;

namespace onSoft
{
    public partial class UserControl1 : UserControl
    {
        private Session[] _sessionsData;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_DragDrop(object sender, DragEventArgs e)
        {
            var cg = new Comparer();
            _sessionsData = ((Session[]) e.Data.GetData("Fiddler.Session[]"));
            if (_sessionsData.Length != 2)
            {
                dfsBodyLeft.Text = "Please select only two sessions to compare";
                return;
            }

            var urlComparisonResult = cg.CompareUrls(_sessionsData[0].url, _sessionsData[1].url);
            dfsUrlLeft.Text = urlComparisonResult[0];
            dfsUrlRight.Text = urlComparisonResult[1];
            dfsLeftUrlOriginal.Text = _sessionsData[0].url;
            dfsRightUrlOriginal.Text = _sessionsData[1].url;

            var headersComparisonResult = cg.CompareHeaders(_sessionsData[0].RequestHeaders, _sessionsData[1].RequestHeaders);
            dfsHeaderLeft.Text = headersComparisonResult[0];
            dfsHeaderRight.Text = headersComparisonResult[1];


        }



        private void UserControl1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent("Fiddler.Session[]") ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void UserControl1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent("Fiddler.Session[]") ? DragDropEffects.Copy : DragDropEffects.None;
        }










    }
}