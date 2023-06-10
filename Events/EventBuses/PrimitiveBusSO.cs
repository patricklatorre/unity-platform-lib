using System;
using UnityEngine;

namespace Platform.Events {
    

    public class PrimitiveBusSO<T> : ScriptableObject {


        public Action<T> Event = delegate {  };


    }


}