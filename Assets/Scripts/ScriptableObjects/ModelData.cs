using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/ModelData")]
    public class ModelData : ScriptableObject
    {
        public new string name;
        public double price;
        public GameObject modelPrefab;
    }
}