using UnityEngine;

namespace RPG.Magic
{
    [CreateAssetMenu(fileName = "New Element", menuName = "Magic/Element")]
    public class Element : ScriptableObject
    {
        [SerializeField] private new string name = "New Element Name";
        [SerializeField] private Color textColour;

        public string Name => name;
        public Color TextColour => textColour;
    }
}