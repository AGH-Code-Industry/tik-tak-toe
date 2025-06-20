using UnityEngine;

namespace Pieces
{
    [CreateAssetMenu(fileName = "PieceSO", menuName = "Scriptable Objects/PieceSO")]
    public class PieceSO : ScriptableObject
    {
        public string pieceName;
        public GameObject piecePrefab;
        public GameObject boardEnterBehaviour;
        public GameObject onTurnBehaviour;
        public GameObject onHitBehaviour;
        public GameObject onDeathBehaviour;
    }
}
