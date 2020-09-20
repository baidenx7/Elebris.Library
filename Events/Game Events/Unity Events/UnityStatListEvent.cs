﻿using RPG.CharacterValues;
using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace RPG.Events
{
    [Serializable]
    public class UnityStatListEvent : UnityEvent<List<StatObject>>
    {
    }
}
