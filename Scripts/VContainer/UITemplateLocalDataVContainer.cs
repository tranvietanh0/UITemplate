namespace UITemplate.Scripts.VContainer
{
    using GameFoundationCore.Scripts.Models.Interfaces;
    using UITemplate.Scripts.Models.Core.Interface;
    using UITemplate.Scripts.UserData;
    using UniT.Extensions;
    using global::VContainer;

    public static class UITemplateLocalDataVContainer
    {
        public static void RegisterUITemplateLocalData(this IContainerBuilder builder)
        {
            typeof(ILocalData).GetDerivedTypes().ForEach(type => builder.Register(type, Lifetime.Singleton));
            typeof(IUITemplateControllerData).GetDerivedTypes().ForEach(type => builder.Register(type, Lifetime.Singleton).AsImplementedInterfaces().AsSelf());
            builder.Register<UserDataManager>(Lifetime.Singleton);
        }
    }
}