using System.Collections.Generic;
using UnityEngine;

namespace RPG.Events
{
    [CreateAssetMenu(fileName = "IntEvent", menuName = "Game Events/ IntListEvent")]
    public class IntListEvent : BaseGameEvent<List<int>>
    {
    }
}
