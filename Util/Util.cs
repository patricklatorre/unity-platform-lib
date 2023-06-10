using System.Collections.Generic;
using UnityEngine;


namespace Platform.Util {


    public static class Util {


        static readonly Dictionary<float, WaitForSeconds> WaitDictionary = new();


        public static WaitForSeconds GetWait(float time) {
            if (WaitDictionary.TryGetValue(time, out var wait)) {
                return wait;
            }

            WaitDictionary[time] = new WaitForSeconds(time);
            return WaitDictionary[time];
        }


        public static void DeleteChildren(this Transform t) {
            foreach (Transform child in t) {
                Object.Destroy(child.gameObject);
            }
        }


        public static void Quit(int exitCode) {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit(exitCode);
            #endif
        }


    }


}