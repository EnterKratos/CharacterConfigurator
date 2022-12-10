using CharacterConfigurator.ScriptableObjects;
using UnityEngine;

namespace CharacterConfigurator
{
    public class MenuPanel : MonoBehaviour
    {
        public GameObject container;
        public IntVariable currentMenuIndex;
        private int _menuIndex;

        private void OnEnable()
        {
            _menuIndex = transform.GetIndex();
            OnMenuChanged();
        }

        public void OnMenuChanged()
        {
            container.SetActive(currentMenuIndex.value == _menuIndex);
        }
    }
}
