using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/ColourData")]
    public class ColourData : Purchasable
    {
        public Color colour;
        public GameObject prefab;
    }
}