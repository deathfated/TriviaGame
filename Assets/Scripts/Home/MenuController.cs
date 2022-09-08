using Agate.MVC.Base;
using UnityEngine;

namespace Deathfated.Trivia.Home
{
    public class MenuController : ObjectController<MenuController, MenuView>
    {
        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.Init(OnStart);
        }

        public void OnStart()
        {
            //SceneLoader.Instance.LoadScene(Scenes.LevelSelect);

            //SceneManager.LoadScene("Pack");
        }
    }
}