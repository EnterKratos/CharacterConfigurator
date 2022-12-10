﻿using System.Collections.Generic;
using CharacterConfigurator.ScriptableObjects;
using UnityEngine;

namespace CharacterConfigurator
{
    public class CharacterDisplay : MonoBehaviour
    {
        public CharacterData characterData;
        public ColoursList coloursList;

        private readonly Dictionary<ColourData, int> _colourIndexMap = new();

        public void OnCharacterChanged()
        {
            Reset();

            var colour = _colourIndexMap[characterData.colour];
            var prefab = characterData.model.prefabs[colour];

            var parentTransform = transform;
            Instantiate(prefab, parentTransform);
        }

        private void OnEnable()
        {
            Reset();

            for (var i = 0; i < coloursList.colours.Length; i++)
            {
                _colourIndexMap[coloursList.colours[i]] = i;
            }

            OnCharacterChanged();
        }

        private void Reset()
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}