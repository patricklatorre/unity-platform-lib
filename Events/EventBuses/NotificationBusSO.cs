using System;
using UnityEngine;

namespace Platform.Events {

    [CreateAssetMenu(menuName = "Event Bus/Notification Bus")]
    public class NotificationBusSO : ScriptableObject {


        public Action Event = delegate { };


    }

}