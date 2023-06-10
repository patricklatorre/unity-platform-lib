using UnityEngine;

namespace Platform.Events {


    [CreateAssetMenu(menuName = "Event Bus/Cached String Bus")]
    public class CachedStringBusSO : CachedPrimitiveBusSO<string> {


        protected override void Init() {
            LastValue = string.Empty;
        }


    }


}