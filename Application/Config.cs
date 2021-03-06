﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class Config
    {
        public const string seed = "https://eclass.hiast.edu.sy/";
        //public const string seed = "https://google.com/";
        //public const string seed = "http://en.wikipedia.org/wiki/Main_Page";

        public const int maxNbrOfLinks = 15; // should be >= 1

        public const string filesDirectory = "../../files";
        public const string filesPrefix = "eclass_";

        public const string proxyIp = "172.25.1.152";
        public const int proxyPort = 8080;
        public const string proxyUserName = "farouk.hjabo";
        public const string proxyPassword = "********";

        public static string[] absoluteLinkPatterns = { "//", "http://", "https://" };
        public static int MaxAllowedFileLength = 100000; // 10^5
    }
}
