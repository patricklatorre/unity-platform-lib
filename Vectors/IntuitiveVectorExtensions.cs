using UnityEngine;


namespace Platform.Vectors {


    public static class IntuitiveVectorExtensions {


        public static bool IsForward(this Vector3 v) {
            return v.x > 0f;
        }


        public static bool IsForward(this Vector2 v) {
            return v.y > 0f;
        }


        public static bool IsBackward(this Vector3 v) {
            return v.x < 0f;
        }


        public static bool IsBackward(this Vector2 v) {
            return v.y < 0f;
        }


        public static bool IsRight(this Vector3 v) {
            return v.z > 0f;
        }


        public static bool IsRight(this Vector2 v) {
            return v.x > 0f;
        }


        public static bool IsLeft(this Vector3 v) {
            return v.z < 0f;
        }


        public static bool IsLeft(this Vector2 v) {
            return v.x < 0f;
        }


        public static bool IsUpward(this Vector3 v) {
            return v.y > 0f;
        }


        public static bool IsDownward(this Vector3 v) {
            return v.y < 0f;
        }


        /* Input extensions */
        public static bool IsPressed(this float v) {
            return v > 0f;
        }


    }


}