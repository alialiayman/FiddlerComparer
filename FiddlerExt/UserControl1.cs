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
            dfsUrlLeftOriginal.Text = _sessionsData[0].url;
            dfsUrlRightOriginal.Text = _sessionsData[1].url;

            var headersComparisonResult = cg.CompareHeaders(_sessionsData[0].RequestHeaders, _sessionsData[1].RequestHeaders);
            dfsHeaderLeft.Text = headersComparisonResult[0];
            dfsHeaderRight.Text = headersComparisonResult[1];
            dfsHeaderLeftOriginal.Text = cg.HeaderString(_sessionsData[0].RequestHeaders);
            dfsHeaderRightOriginal.Text = cg.HeaderString(_sessionsData[1].RequestHeaders);


            var bodyComparisonResult = cg.CompareUrls(_sessionsData[0].GetRequestBodyAsString(), _sessionsData[1].GetRequestBodyAsString());
            dfsBodyLeft.Text = bodyComparisonResult[0];
            dfsBodyRight.Text = bodyComparisonResult[1];
            dfsBodyLeftOriginal.Text = _sessionsData[0].GetRequestBodyAsString();
            dfsBodyRightOriginal.Text = _sessionsData[1].GetRequestBodyAsString();


        }



        private void UserControl1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent("Fiddler.Session[]") ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void UserControl1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent("Fiddler.Session[]") ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            var cg= new Comparer();
            var urlComparisonResult = cg.CompareUrls(dfsUrlLeft.Text, dfsUrlRight.Text);
            dfsUrlLeft.Text = urlComparisonResult[0];
            dfsUrlRight.Text = urlComparisonResult[1];
            dfsUrlLeftOriginal.Text = _sessionsData[0].url;
            dfsUrlRightOriginal.Text = _sessionsData[1].url;

            var headersComparisonResult = cg.CompareHeaders(dfsHeaderLeft.Text, dfsHeaderRight.Text);
            dfsHeaderLeft.Text = headersComparisonResult[0];
            dfsHeaderRight.Text = headersComparisonResult[1];
            dfsHeaderLeftOriginal.Text = cg.HeaderString(_sessionsData[0].RequestHeaders);
            dfsHeaderRightOriginal.Text = cg.HeaderString(_sessionsData[1].RequestHeaders);


            var bodyComparisonResult = cg.CompareUrls(dfsBodyLeft.Text, dfsBodyRight.Text);
            dfsBodyLeft.Text = bodyComparisonResult[0];
            dfsBodyRight.Text = bodyComparisonResult[1];
            dfsBodyLeftOriginal.Text = _sessionsData[0].GetRequestBodyAsString();
            dfsBodyRightOriginal.Text = _sessionsData[1].GetRequestBodyAsString();
        }
    }
}