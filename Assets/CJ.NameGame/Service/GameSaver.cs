using UnityEngine;

namespace CJ.NameGame.Service
{
    public class GameSaver : ISave
    {
        public void Load()
        {
            Debug.Log("Игра загружена");
        }

        public void Save()
        {
            Debug.Log("Игра сохранена");
        }
    }
}