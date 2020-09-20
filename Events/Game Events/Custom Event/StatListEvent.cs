using RPG.CharacterValues;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Events
{
    [CreateAssetMenu(fileName = "StatListEvent", menuName = "Game Events/ StatListEvent")]
    public class StatListEvent : BaseGameEvent<List<StatObject>>
    {
    }
}
