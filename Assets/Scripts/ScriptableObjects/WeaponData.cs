using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/WeaponData")]
    public class WeaponData : Purchasable
    {
        public new string name;
        public GameObject prefab;
    }
}