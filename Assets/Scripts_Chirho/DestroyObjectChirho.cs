using UnityEngine;

public class DestroyObjectChirho : MonoBehaviour
{
    public float destroyTimeChirho = 2;

    void Start()
    {
        Destroy(gameObject, destroyTimeChirho);
    }
}
