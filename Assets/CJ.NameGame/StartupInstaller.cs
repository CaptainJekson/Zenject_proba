using CJ.NameGame.CoreGame.Installer;
using CJ.NameGame.Service.Installer;
using CJ.NameGame.UI.Installer;
using Zenject;

namespace CJ.NameGame
{
    public class StartupInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            ServiceInstaller.Install(Container);
            CoreGameInstaller.Install(Container);
            UIInstaller.Install(Container);
        }
    }
}
