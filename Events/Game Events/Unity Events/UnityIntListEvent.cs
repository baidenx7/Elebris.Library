using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace RPG.Events
{
    [Serializable]
    public class UnityIntListEvent : UnityEvent<List<int>>
    {
    }
}
