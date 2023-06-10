using UnityEngine;

namespace Platform.Events {


    [CreateAssetMenu(menuName = "Event Bus/Cached Vector3 Bus")]
    public class CachedVector3BusSO : CachedPrimitiveBusSO<Vector3> {


        protected override void Init() {
            LastValue = Vector3.zero;
        }


    }


}