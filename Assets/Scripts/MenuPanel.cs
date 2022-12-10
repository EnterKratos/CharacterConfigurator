using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CharacterConfigurator
{
    public class MenuPanel : MonoBehaviour
    {
        public GameObject container;
        public int menuIndex;
        public IntVariable currentMenuIndex;

        private void OnEnable()
        {
            OnMenuChanged();
        }

        public void OnMenuChanged()
        {
            container.SetActive(currentMenuIndex.value == menuIndex);
        }
    }
}
