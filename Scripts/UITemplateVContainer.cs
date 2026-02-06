namespace UITemplate.Scripts
{
    using UnityEngine;
    using global::VContainer;
    using UITemplate.Scripts.VContainer;

    public static class UITemplateVContainer
    {
        public static void RegisterUITemplate(this IContainerBuilder builder)
        {
            Application.targetFrameRate = 60;

            builder.RegisterUITemplateLocalData();
        }
    }
}