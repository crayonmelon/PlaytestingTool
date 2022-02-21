using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PlaytestingTool
{
    public class PopupWindow : EditorWindow
    {
        private static string popupText;

        public void Init(string popupName, string newPopupText)
        {
            PopupWindow window = ScriptableObject.CreateInstance<PopupWindow>();

            popupText = newPopupText;

            window.position = new Rect(Screen.width / 2, Screen.height / 2, 250, 150);
            window.ShowPopup();
        }


        private void OnGUI()
        {
            GUILayout.Label(popupText);

            if (GUILayout.Button("Close"))
            {
                this.Close();
            }
        }

    }
}
