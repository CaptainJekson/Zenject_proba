using Zenject;

namespace CJ.NameGame.CoreGame.Installer
{
    public class CoreGameInstaller : Installer<CoreGameInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<LevelConfig>().FromScriptableObjectResource("Configs/LevelConfig").AsSingle();
            Container.Bind<LevelCreator>().FromComponentInNewPrefabResource("CoreGames/CardTableCanvas").AsSingle();
            Container.Bind<GameWatcher>().FromComponentInNewPrefabResource("CoreGames/GameWatcher").AsSingle();
        }
    }
}