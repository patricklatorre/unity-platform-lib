using UnityEngine;


namespace Platform.AtomicSO {


    public abstract class PrimitiveSO<T> : ScriptableObject {


        public bool editable = false;


        T Value {
            get => Value;
            set {
                if (editable) {
                    Value = value;
                }
            }
        }


    }


}