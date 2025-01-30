using UnityEngine;

public class RSBehavior : MonoBehaviour
{
    public SecretGameEnder secretGameEnder;

    public void IncrementRS()
    {
        secretGameEnder.rightStar += 1;
    }
}
