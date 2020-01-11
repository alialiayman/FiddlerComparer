using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

            leftResult = Reverse(leftResult);
            rightResult = Reverse(rightResult);
            left = leftResult;
            right = rightResult;

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] == right[i] && right.Length < i)
                {
                    leftResult = leftResult.Substring(1);
                    rightResult = rightResult.Substring(1);
                }
                else
                {
                    break;
                }
            }

            return new List<string> {Reverse(leftResult), Reverse(rightResult)};
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        internal List<string> CompareHeaders(HTTPRequestHeaders left, HTTPRequestHeaders right)
        {
            var leftResult = string.Empty;
            var rightResult = string.Empty;
            var leftOnly = string.Empty;

            foreach (var head in left)
            {
                var sameInRight = right.FirstOrDefault(x => x.Name == head.Name);
                if (sameInRight == null)
                {
                    leftOnly += head.Name + ":" + head.Value + Environment.NewLine;
                }
                else
                {
                    if (head.Value != sameInRight.Value)
                    {
                        leftResult += head.Name + ":" + head.Value + Environment.NewLine;
                        rightResult += sameInRight.Name + ":" + sameInRight.Value + Environment.NewLine;
                    }
                    right.Remove(sameInRight.Name);
                }
            }
            foreach (var head in right)
            {
                rightResult += head.Name + ":" + head.Value + Environment.NewLine;
            }
            return new List<string> { leftResult+ Environment.NewLine + leftOnly, rightResult };
        }

        internal List<string> CompareHeaders(string leftstring, string rightstring)
        {
            HTTPRequestHeaders left = new HTTPRequestHeaders();
            HTTPRequestHeaders right = new HTTPRequestHeaders();
            foreach (var s in leftstring.Split('\n'))
            {
                if (string.IsNullOrEmpty(s) || s.Split(':').Length <2) continue;
                left.Add(s.Split(':')[0], s.Split(':')[1]);
            }
            foreach (var s in rightstring.Split('\n'))
            {
                if (string.IsNullOrEmpty(s) || s.Split(':').Length < 2) continue;
                right.Add(s.Split(':')[0], s.Split(':')[1]);
            }

            var leftResult = string.Empty;
            var rightResult = string.Empty;
            var leftOnly = string.Empty;
            foreach (var head in left)
            {
                var sameInRight = right.FirstOrDefault(x => x.Name == head.Name);
                if (sameInRight == null)
                {
                    leftOnly += head.Name + ":" + head.Value + Environment.NewLine;
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

            foreach (var head in right)
            {
                rightResult += head.Name + ":" + head.Value + Environment.NewLine;
            }
            return new List<string> { leftResult + Environment.NewLine + leftOnly, rightResult };
        }

        internal string HeaderString(HTTPRequestHeaders input)
        {
            var result = string.Empty;
            foreach (var head in input.OrderBy(x=> x.Name))
            {


                        result += head.Name + ":" + head.Value + Environment.NewLine;

            }
            return result;
        }

        public List<string> CompareJsons(string leftString, string rightString)
        {
            var leftArray = leftString.Split(',').ToList();
            var rightArray = rightString.Split(',').ToList();
            var leftResult = string.Empty;
            var rightResult = string.Empty;
            var leftOnly = string.Empty;

            foreach (var item in leftArray)
            {
                var itemName = item.Split(':');

                var sameInRight = rightArray.FirstOrDefault(x => x.Split(':')[0] == itemName[0]);
                if (sameInRight == null)
                {
                    leftOnly += item + Environment.NewLine;
                }
                else
                {
                    if (!sameInRight.Contains(":") || !item.Contains(":") || sameInRight.Split(':')[1] != itemName[1])
                    {
                        leftResult += item + Environment.NewLine;
                        rightResult += sameInRight + Environment.NewLine;
                    }
                    rightArray.Remove(sameInRight);
                }
            }

            foreach (var item in rightArray)
            {
                rightResult += item + Environment.NewLine;
            }
            return new List<string> { leftResult + Environment.NewLine + leftOnly, rightResult };
        }
    }
}