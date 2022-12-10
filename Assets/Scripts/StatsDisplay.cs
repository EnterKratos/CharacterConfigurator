using CharacterConfigurator.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CharacterConfigurator
{
    public class StatsDisplay : MonoBehaviour
    {
        public CharacterData characterData;

        public TextMeshProUGUI modelLabel;
        public TextMeshProUGUI modelPriceLabel;

        public TextMeshProUGUI weaponLabel;
        public TextMeshProUGUI weaponPriceLabel;

        public TextMeshProUGUI colourPriceLabel;

        public TextMeshProUGUI totalPriceLabel;

        private void OnEnable()
        {
            OnCharacterConfigChanged();
        }

        public void OnCharacterConfigChanged()
        {
            modelLabel.text = characterData.model.name;
            modelPriceLabel.text = Helpers.FormatCurrencyValue(characterData.model.price);
            weaponLabel.text = characterData.weapon.name;
            weaponPriceLabel.text = Helpers.FormatCurrencyValue(characterData.weapon.price);
            colourPriceLabel.text = Helpers.FormatCurrencyValue(characterData.colour.price);
            totalPriceLabel.text = Helpers.FormatCurrencyValue(characterData.Total);
        }
    }
}