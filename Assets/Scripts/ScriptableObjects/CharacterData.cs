using UnityEngine;

namespace CharacterConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Character/CharacterData")]
    public class CharacterData: ScriptableObject
    {
        public ModelData model;
        public WeaponData weapon;
        public ColourData colour;

        [SerializeField]
        [HideInInspector]
        private ModelData _model;

        [SerializeField]
        [HideInInspector]
        private WeaponData _weapon;

        [SerializeField]
        [HideInInspector]
        private ColourData _colour;

        public double Total => model.price + weapon.price + colour.price;

        public void Set(ModelData input) => model = input;
        public void Set(WeaponData input) => weapon = input;
        public void Set(ColourData input) => colour = input;

        private void OnEnable()
        {
            _model = model;
            _weapon = weapon;
            _colour = colour;
        }

        private void OnDisable()
        {
            model = _model;
            weapon = _weapon;
            colour = _colour;
        }
    }
}