using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace RPG.Events
{
    [Serializable]
    public class UnityFloatListEvent : UnityEvent<List<float>>
    {
    }
}
