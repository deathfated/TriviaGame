using System.Collections;
using Agate.MVC.Base;

namespace Deathfated.Trivia.Pack
{
    public class PackStatusController : DataController<PackStatusController, PackStatusModel, IPackStatusModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();

        }

        public bool IsUnlock(int level)
        {
            return _model.CheckStatus(level);
        }

        public void Unlock(int level)
        {
            _model.UnlockPack(level);
        }

        public void Reset()
        {
            _model.Reset();
        }

        public void SetLevel(int level)
        {
            _model.SetPack(level);
        }
    }
}