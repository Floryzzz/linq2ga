﻿namespace linq2ga.Core.DataFields
{
    internal class YesNoBoolFieldConverter : IFieldConverter<bool>
    {
        const string YES = "Yes";
        const string NO = "No";

        public bool GetValue(string value)
        {
            if (value == YES)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetStringValue(bool value)
        {
            if (value)
            {
                return YES;
            }
            else
            {
                return NO;
            }
        }
    }
}
