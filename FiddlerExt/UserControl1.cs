using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
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
            Resize += UserControl1_Resize;
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            ResizeAll();
        }

        private void ResizeAll()
        {
            CenterContols(grbUrl, dfsUrlLeft, dfsUrlRight);
            CenterContols(grbBodies, dfsHeaderLeft, dfsHeaderRight);
            CenterContols(grbHeaders, dfsBodyLeft, dfsBodyRight);

            CenterContols(grbUrlOriginal, dfsUrlLeftOriginal, dfsUrlRightOriginal);
            CenterContols(grbBodiesOriginal, dfsBodyLeftOriginal, dfsBodyRightOriginal);
            CenterContols(grbHeadersOriginal, dfsHeaderLeftOriginal, dfsHeaderRightOriginal);
        }

        private void CenterContols(Control groupBox, Control leftControl, Control rightControl)
        {
            var halfWidth = (groupBox.Width / 2) - (leftControl.Left * 2);
            leftControl.Width = halfWidth;
            rightControl.Width = halfWidth;
            rightControl.Left = leftControl.Left + leftControl.Width;

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


            var urlComparisonResult = new List<string>();
            var headersComparisonResult = new List<string>();
            var bodyComparisonResult = new List<string>();

            Parallel.Invoke(() =>
            {
                urlComparisonResult = cg.CompareUrls(_sessionsData[0].url, _sessionsData[1].url);
                headersComparisonResult = cg.CompareHeaders(_sessionsData[0].RequestHeaders, _sessionsData[1].RequestHeaders);
                if (IsJsonBody(_sessionsData[0].GetRequestBodyAsString()))
                {
                     bodyComparisonResult = cg.CompareJsons(_sessionsData[0].GetRequestBodyAsString(), _sessionsData[1].GetRequestBodyAsString());
                }
                else
                {
                     bodyComparisonResult = cg.CompareUrls(_sessionsData[0].GetRequestBodyAsString(), _sessionsData[1].GetRequestBodyAsString());
                }
            });
            
            dfsUrlLeft.Text = urlComparisonResult[0];
            dfsUrlRight.Text = urlComparisonResult[1];
            dfsUrlLeftOriginal.Text = _sessionsData[0].url;
            dfsUrlRightOriginal.Text = _sessionsData[1].url;

            
            dfsHeaderLeft.Text = headersComparisonResult[0];
            dfsHeaderRight.Text = headersComparisonResult[1];
            dfsHeaderLeftOriginal.Text = cg.HeaderString(_sessionsData[0].RequestHeaders);
            dfsHeaderRightOriginal.Text = cg.HeaderString(_sessionsData[1].RequestHeaders);


            if (IsJsonBody(_sessionsData[0].GetRequestBodyAsString()))
            {
                dfsBodyLeft.Text = DisplayJson(bodyComparisonResult[0]);
                dfsBodyRight.Text = DisplayJson(bodyComparisonResult[1]);
                dfsBodyLeftOriginal.Text = DisplayJson(_sessionsData[0].GetRequestBodyAsString());
                dfsBodyRightOriginal.Text = DisplayJson(_sessionsData[1].GetRequestBodyAsString());
            }
            else
            {
                dfsBodyLeft.Text = bodyComparisonResult[0];
                dfsBodyRight.Text = bodyComparisonResult[1];
                dfsBodyLeftOriginal.Text = _sessionsData[0].GetRequestBodyAsString();
                dfsBodyRightOriginal.Text = _sessionsData[1].GetRequestBodyAsString();
            }

            lblLeftBodyStats.Text = dfsBodyLeft.Lines.Length + " Lines, " + dfsBodyLeft.Text.Length + "Chars";
            lblRightBodyStats.Text = dfsBodyRight.Lines.Length + " Lines, " + dfsBodyRight.Text.Length + "Chars";

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

            if (IsJsonBody(dfsBodyLeft.Text))
            {
                var bodyComparisonResult = cg.CompareJsons(dfsBodyLeft.Text, dfsBodyRight.Text);
                dfsBodyLeft.Text = DisplayJson( bodyComparisonResult[0]);
                dfsBodyRight.Text = DisplayJson(bodyComparisonResult[1]);
                dfsBodyLeftOriginal.Text = DisplayJson(_sessionsData[0].GetRequestBodyAsString());
                dfsBodyRightOriginal.Text = DisplayJson(_sessionsData[1].GetRequestBodyAsString());
            }
            else
            {
                var bodyComparisonResult = cg.CompareUrls(dfsBodyLeft.Text, dfsBodyRight.Text);
                dfsBodyLeft.Text = bodyComparisonResult[0];
                dfsBodyRight.Text = bodyComparisonResult[1];
                dfsBodyLeftOriginal.Text = _sessionsData[0].GetRequestBodyAsString();
                dfsBodyRightOriginal.Text = _sessionsData[1].GetRequestBodyAsString();
            }


        }

        private string DisplayJson(string input)
        {
            return input.Replace(",", Environment.NewLine);
        }

        private bool IsJsonBody(string input)
        {
            if (input.Contains(":")) return true;
            else return false;
        }

        private void tabCompare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResizeAll();
        }
    }
}