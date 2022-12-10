using CharacterConfigurator.ScriptableObjects;
using UnityEngine;

namespace CharacterConfigurator
{
    public class MenuButton : MonoBehaviour
    {
        public IntVariable selectedMenuIndex;
        public GameEvent menuChangedEvent;
        private int _buttonMenuIndex;

        public void OnClick()
        {
            selectedMenuIndex.value = _buttonMenuIndex;
            menuChangedEvent.Raise();
        }

        private void OnEnable()
        {
            _buttonMenuIndex = transform.GetIndex();
        }
    }
}