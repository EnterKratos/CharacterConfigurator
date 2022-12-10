using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/CharacterData")]
    public class CharacterData: ScriptableObject
    {
        public ModelData model;
        public WeaponData weapon;
        public ColourData colour;

        public double Total => model.price + weapon.price + colour.price;
    }
}