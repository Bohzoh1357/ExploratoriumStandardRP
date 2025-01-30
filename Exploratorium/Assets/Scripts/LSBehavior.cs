using UnityEngine;

public class LSBehavior : MonoBehaviour
{
    public SecretGameEnder secretGameEnder;

    public void IncrementLS()
    {
        secretGameEnder.leftStar += 1;
    }
}
