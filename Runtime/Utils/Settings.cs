using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    public class Settings 
    {
        private static string _FOLDERPATH = ".Assets/SessionData";
        private static string _WEBENDPOINT = "https://my-json-server.typicode.com/typicode/demo";
        private static bool _UPLOADDATA = false;
        private static bool _ENABLE = true;

        public static string FOLDERPATH
        {
            get { return _FOLDERPATH; }
            set { _FOLDERPATH = value;  }
        }

        public static string WEBENDPOINT
        {
            get { return _WEBENDPOINT; }
            set { _WEBENDPOINT = value; }
        }

        public static bool ENABLE
        {
            get { return _ENABLE; }
            set { _ENABLE = value; }
        }

        public static bool UPLOADDATA
        {
            get { return _UPLOADDATA; }
            set { _UPLOADDATA = value; }
        }
    }
}
