using Extensions;
using Enums;
using UnityEngine.Events;

namespace Signals
{
    public class CoreGameSignals : MonoSingleton<CoreGameSignals>
    {
        public UnityAction<GameStates> OnGameStates = delegate {  };
        public UnityAction<float,float> OnUpdatingHealthBar =delegate {  };
    }
}
