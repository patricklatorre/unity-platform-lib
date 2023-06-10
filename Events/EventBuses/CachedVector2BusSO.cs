using UnityEngine;

namespace Platform.Events {


    [CreateAssetMenu(menuName = "Event Bus/Cached Vector2 Bus")]
    public class CachedVector2BusSO : CachedPrimitiveBusSO<Vector2> {

        
        protected override void Init() {
            LastValue = Vector2.zero;
        }


    }


}