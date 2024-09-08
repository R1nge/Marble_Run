using System;
using _Assets.Scripts.Services.MainLoop;
using _Assets.Scripts.Services.StateMachine.States;
using _Assets.Scripts.Services.UIs.StateMachine;

namespace _Assets.Scripts.Services.StateMachine
{
    public class GameStatesFactory
    {
        private readonly UIStateMachine _uiStateMachine;
        private readonly SceneService _sceneService;
        private readonly MarbleFactory _marbleFactory;

        private GameStatesFactory(UIStateMachine uiStateMachine, SceneService sceneService, MarbleFactory marbleFactory)
        {
            _uiStateMachine = uiStateMachine;
            _sceneService = sceneService;
            _marbleFactory = marbleFactory;
        }

        public IAsyncState CreateAsyncState(GameStateType gameStateType, GameStateMachine gameStateMachine)
        {
            switch (gameStateType)
            {
                case GameStateType.Init:
                    return new InitState(gameStateMachine, _uiStateMachine);
                case GameStateType.Game:
                    return new GameState(gameStateMachine, _sceneService, _marbleFactory);
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameStateType), gameStateType, null);
            }
        }
    }
}