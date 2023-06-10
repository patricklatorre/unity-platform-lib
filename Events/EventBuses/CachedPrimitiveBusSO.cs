using System;
using UnityEngine;

namespace Platform.Events {


    public abstract class CachedPrimitiveBusSO<T> : ScriptableObject {


        public Action<T> Event = delegate {  };
        public T LastValue { get; protected set; }


        protected abstract void Init();
        

        protected void OnEnable() {
            Init();
            Event += UpdateLastValue;
        }


        protected void OnDisable() {
            Event -= UpdateLastValue;
        }


        protected void UpdateLastValue(T value) {
             LastValue = value;
        }


    }


}