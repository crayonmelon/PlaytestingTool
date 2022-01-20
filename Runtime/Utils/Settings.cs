using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytestingTool
{
    public class Settings 
    {
        private static string _FOLDERPATH = ".Assets/SessionData";
        private static string _WEBENDPOINT = ".Assets/SessionData";

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
    }
}
