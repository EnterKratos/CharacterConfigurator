using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/ColourData")]
    public class ColourData : ScriptableObject
    {
        public Color colour;
        public double price;
        public GameObject prefab;
    }
}