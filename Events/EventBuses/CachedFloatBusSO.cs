using UnityEngine;

namespace Platform.Events {


    [CreateAssetMenu(menuName = "Event Bus/Cached Float Bus")]
    public class CachedFloatBusSO : CachedPrimitiveBusSO<float> {
                
        
        protected override void Init() {
            LastValue = 0f;
        }


    }


}