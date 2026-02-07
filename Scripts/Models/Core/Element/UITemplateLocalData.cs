using IUITemplateLocalData = UITemplate.Scripts.Models.Core.Interface.IUITemplateLocalData;

namespace Submodules.UITemplate.Scripts.Models.Core.Element
{
    using System;
    using GameFoundationCore.Scripts.Models.Interfaces;

    public abstract class UITemplateLocalData<TController> : ILocalData, IUITemplateLocalData
    {
        Type IUITemplateLocalData.ControllerType => typeof(TController);

        void ILocalData.Init()
        {
            this.Init();
        }

        protected virtual void Init()
        {
        }
    }
}