using UnityEngine;

namespace Platform.Events {


    [CreateAssetMenu(menuName = "Event Bus/Cached Int Bus")]
    public class CachedIntBusSO : CachedPrimitiveBusSO<int> {


        protected override void Init() {
            LastValue = 0;
        }

        
    }


}
