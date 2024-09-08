using _Assets.Scripts.Gameplay.Marble;
using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig")]
    public class GameConfig : ScriptableObject
    {
        [SerializeField] private Marble marble;
        public Marble Marble => marble; 
    }
}