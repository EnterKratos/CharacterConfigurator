using TMPro;
using UnityEngine;

namespace CharacterConfigurator
{
    public class ItemCard : MonoBehaviour
    {
        public Purchasable item;
        public TextMeshProUGUI priceLabel;

        private void OnEnable()
        {
            OnMenuChanged();
        }

        public void OnMenuChanged()
        {
            priceLabel.text = Helpers.FormatCurrencyValue(item.price);
        }
    }
}