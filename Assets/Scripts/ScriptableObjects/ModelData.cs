using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/ModelData")]
    public class ModelData : Purchasable
    {
        public new string name;
        public GameObject[] prefabs;
    }
}