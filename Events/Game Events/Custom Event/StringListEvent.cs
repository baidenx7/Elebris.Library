using System;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Events
{
    [CreateAssetMenu(fileName = "StringEvent", menuName = "Game Events/ StringListEvent")]
    public class StringListEvent : BaseGameEvent<List<string>>
    {
    }
}
