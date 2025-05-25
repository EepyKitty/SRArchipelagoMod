using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using TMPro;


namespace SRArchipelagoMod
{
    [HarmonyPatch(typeof(NewGameUI), "Start")]
    class NewGameUI_Start_Patch
    {

        private static void logInstanceTree(Transform start, string prefix)
        {
            Debug.Log($"{prefix}{start.name}");
            for (int i = 0; i < start.childCount; i++)
            {
                logInstanceTree(start.GetChild(i), prefix+"-");
            }
        }

        [HarmonyPostfix]
        public static void Postfix(NewGameUI __instance)
        {
            //Transform testing = __instance.transform;
            //logInstanceTree(testing, "");

            Transform infoPanel = __instance.transform.Find("Panel/InfoPanel");

            // URL Label and Input

            Transform gameNameLabelTransform = infoPanel.Find("GameNameLabel");
            GameObject urlLabel = UnityEngine.Object.Instantiate(gameNameLabelTransform.gameObject);
            urlLabel.name = "urlLabel";
            urlLabel.transform.SetParent(gameNameLabelTransform.parent, false);
            urlLabel.transform.localPosition = new Vector3(0f, 0f);
            UnityEngine.Object.Destroy(urlLabel.GetComponent<XlateText>());
            urlLabel.GetComponentInChildren<TMP_Text>().text = "Archipelago Server URL:";




            //Transform gameNameTransform = __instance.transform.Find("mainMenuUIPrefab/gameNameField");
            //GameObject urlField = UnityEngine.Object.Instantiate(gameNameTransform.gameObject);
            //urlField.name = "urlField";
            //urlField.transform.SetParent(gameNameTransform.parent, false);
            //urlField.transform.localPosition = new Vector3(0f, 0f);
            //UnityEngine.Object.Destroy(urlField.GetComponent<XlateText>());
            //UnityEngine.Debug.Log("Meow");
        }
    }

}
