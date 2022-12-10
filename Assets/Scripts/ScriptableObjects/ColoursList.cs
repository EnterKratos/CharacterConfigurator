using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/ColoursList")]
    public class ColoursList : ScriptableObject
    {
        public ColourData[] colours;
    }
}