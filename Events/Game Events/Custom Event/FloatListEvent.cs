using System.Collections.Generic;
using UnityEngine;

namespace RPG.Events
{
    [CreateAssetMenu(fileName = "FloatEvent", menuName = "Game Events/ FloatListEvent")]
    public class FloatListEvent : BaseGameEvent<List<float>>
    {
    }
}
