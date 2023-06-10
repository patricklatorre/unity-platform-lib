using UnityEngine;

namespace Platform.Events {


    [CreateAssetMenu(menuName = "Event Bus/Cached Bool Bus")]
    public class CachedBoolBusSO : CachedPrimitiveBusSO<bool> {
        
        
        protected override void Init() {
            LastValue = false;
        }


    }


}