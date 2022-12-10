using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/WeaponData")]
    public class WeaponData : ScriptableObject
    {
        public new string name;
        public double price;
        public GameObject prefab;
    }
}