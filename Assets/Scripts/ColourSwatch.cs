using CharacterConfigurator.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterConfigurator
{
    public class ColourSwatch : MonoBehaviour
    {
        public CharacterData characterData;
        public Image image;

        public void OnCharacterChanged()
        {
            image.color = characterData.colour.colour;
        }

        private void OnEnable()
        {
            OnCharacterChanged();
        }
    }
}