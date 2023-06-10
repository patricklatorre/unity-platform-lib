using UnityEngine;


namespace Platform.Audio {


    public static class AudioSourceExtensions {


        public static void PlayRandomOneShot(this AudioSource audioSource, AudioSetSO audioSet) {
            if (Random.value > audioSet.chanceToPlay) { return; }
            audioSource.volume = audioSet.preferredVolume;
            audioSource.PlayOneShot(audioSet.Random());
        }


        /*
         * Sets a random clip from the AudioSet and matches its volume preference.
         */
        public static void InitializeFromSet(this AudioSource audioSource, AudioSetSO audioSet) {
            audioSource.clip = audioSet.Random();
            audioSource.volume = audioSet.preferredVolume;
        }


        /*
         * Only starts if AudioSource is not playing.
         */
        public static void TryPlay(this AudioSource audioSource) {
            if (audioSource.isPlaying) { return; }
            audioSource.Play();
        }


        /*
         * Only stops if AudioSource is currently playing.
         */
        public static void TryStop(this AudioSource audioSource) {
            if (!audioSource.isPlaying) { return; }
            audioSource.Stop();
        }


    }


}