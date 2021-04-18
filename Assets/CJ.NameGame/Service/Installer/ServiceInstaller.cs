using Zenject;

namespace CJ.NameGame.Service.Installer
{
    public class ServiceInstaller : Installer<ServiceInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ISave>().To<GameSaver>().AsSingle();
        }
    }
}