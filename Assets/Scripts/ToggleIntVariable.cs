using CharacterConfigurator.ScriptableObjects;
using UnityEngine;

namespace CharacterConfigurator
{
    public class ToggleIntVariable : MonoBehaviour
    {
        public IntVariable intVariable;
        public int value1;
        public int value2;

        public void Toggle()
        {
            intVariable.value = intVariable.value == value1 ? value2 : value1;
        }

        private void OnEnable()
        {
            intVariable.value = value1;
        }
    }
}