using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace CJ.NameGame.CoreGame
{
    public class LevelCreator : MonoBehaviour
    {
        [SerializeField] private Card card;
        [SerializeField] private Transform _tableParent;
        
        private LevelConfig _levelConfig;

        private List<Card> _cards;

        public List<Card> Card => _cards;
        
        [Inject]
        public void Construct(LevelConfig levelConfig)
        {
            _levelConfig = levelConfig;
            _cards = new List<Card>();
        }

        private void Awake()
        {
            for (var i = 0; i < _levelConfig.Count; i++)
            {
                var spawnedCard = Instantiate(card, _tableParent);
                _cards.Add(spawnedCard);
            }
        }
    }
}