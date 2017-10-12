﻿using System;
namespace SchoolLibrary
{
    public static class ExtensionMethods
    {
        public static int WordCount (this string str)
        {
            var wordCount = str.Split(new char[] { ' ', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
