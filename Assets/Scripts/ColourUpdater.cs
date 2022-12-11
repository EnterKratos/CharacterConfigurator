using CharacterConfigurator.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterConfigurator
{
    public class ColourUpdater : MonoBehaviour
    {
        public Image image;
        public ColourData colourData;

        public void Update()
        {
            image.color = colourData.colour;
        }

        private void OnEnable()
        {
            Update();
        }
    }
}