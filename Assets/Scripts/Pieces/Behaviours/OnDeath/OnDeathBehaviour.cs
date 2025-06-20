using System.Dynamic;
using UnityEngine;

public abstract class OnDeathBehaviour : MonoBehaviour
{
    public abstract void Invoke(Piece piece);
}
