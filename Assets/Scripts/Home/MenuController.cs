using Agate.MVC.Base;
using Deathfated.Trivia.Boot;
using Deathfated.Trivia.Utility;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneLoader.Instance.LoadScene(Scenes.Pack);

            SceneManager.LoadScene("Pack");
        }
    }
}