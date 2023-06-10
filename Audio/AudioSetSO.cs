using UnityEngine;


namespace Platform.Audio {


    [CreateAssetMenu(menuName = "Scriptable Objects/Audio Set")]
    public class AudioSetSO : ScriptableObject {


        [Range(0, 1)] public float preferredVolume = 1f;
        [Range(0, 1)] public float chanceToPlay = 1f;
        public AudioClip[] clips;


        public AudioClip Random() {
            var index = UnityEngine.Random.Range(0, clips.Length-1);
            return clips[index];
        }


    }


}