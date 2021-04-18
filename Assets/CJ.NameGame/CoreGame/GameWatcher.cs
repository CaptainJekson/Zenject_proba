using System;
using UnityEngine;
using Zenject;

namespace CJ.NameGame.CoreGame
{
    public class GameWatcher : MonoBehaviour
    {
        private LevelCreator _levelCreator;
        
        [Inject]
        public void Construct(LevelCreator levelCreator)
        {
            _levelCreator = levelCreator;
        }

        private void Update() //TODO Test
        {
            Debug.Log("Карт на поле: " + _levelCreator.Card.Count);
        }
    }
}