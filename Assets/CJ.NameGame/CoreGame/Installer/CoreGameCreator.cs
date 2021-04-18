using UnityEngine;
using Zenject;

namespace CJ.NameGame.CoreGame.Installer
{
    public class CoreGameCreator : MonoBehaviour
    {
        private LevelCreator _levelCreator;
        private GameWatcher _gameWatcher;
    
        [Inject]
        public void Construct(LevelCreator levelCreator, GameWatcher gameWatcher)
        {
            _levelCreator = levelCreator;
            _levelCreator.transform.SetParent(transform);
            _gameWatcher = gameWatcher;
            _gameWatcher.transform.SetParent(transform);
        }
    }
}
