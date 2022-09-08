using System.Collections;
using Agate.MVC.Base;
using Deathfated.Trivia.Boot;
using Deathfated.Trivia.Utility;
using UnityEngine;

namespace Deathfated.Trivia.Pack
{
    public class PackSelectController : ObjectController<PackSelectController, PackSelectModel, PackSelectView>
    {
        private PackStatusController _packStatus;
        
        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }

        public override IEnumerator Finalize()
        {
            return base.Finalize();
        }

        public override void SetView(PackSelectView view)
        {
            base.SetView(view);
            view.Init(Onclose, Onpack);
        }

        public void SetPack(int source)
        {
            _model.SetPack(source);
        }

        public void Onpack(int index)
        {
            SetPack(index);
            bool IsUnlockResult = _packStatus.IsUnlock(_model.Pack);

            if(IsUnlockResult)
            {
                Debug.Log("Pack" + _model.PackNumber + " is unlocked");
                SceneLoader.Instance.LoadScene(Scenes.Level);
            }
            else
            {
                Debug.Log("Level" + _model.PackNumber + " is locked");
                //publish lock mess
            }
        }

        public void Onclose()
        {
            SceneLoader.Instance.LoadScene(Scenes.Home);
        }
    }
}