using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Fiddler;

namespace onSoft
{
    public class Comparer
    {

        public Comparer()
        {

        }

        public List<string> CompareUrls(string left, string right)
        {
            var leftResult = left;
            var rightResult = right;
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] == right[i])
                {
                    leftResult = leftResult.Substring(1);
                    rightResult = rightResult.Substring(1);
                }
                else
                {
                    break;
                }
            }
            return new List<string> {leftResult,rightResult};
        }

        internal List<string> CompareHeaders(HTTPRequestHeaders left, HTTPRequestHeaders right)
        {
            var leftResult = string.Empty;
            var rightResult = string.Empty;
            foreach (var head in left)
            {
                var sameInRight = right.FirstOrDefault(x => x.Name == head.Name);
                if (sameInRight == null)
                {
                    leftResult += head.Name + ":" + head.Value + Environment.NewLine;
                }
                else
                {
                    if (head.Value != sameInRight.Value)
                    {
                        leftResult += head.Name + ":" + head.Value + Environment.NewLine;
                        rightResult += sameInRight.Name + ":" + sameInRight.Value + Environment.NewLine;
                    }
                }
            }
            return new List<string> { leftResult, rightResult };
        }
    }
}