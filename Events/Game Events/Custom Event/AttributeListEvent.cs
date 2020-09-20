using RPG.CharacterValues;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Events
{

    [CreateAssetMenu(fileName = "AttributeListEvent", menuName = "Game Events/ AttributeListEvent")]
    public class AttributeListEvent : BaseGameEvent<List<AttributeObject>>
    {
    }
}
