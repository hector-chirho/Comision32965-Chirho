using UnityEngine;

public class EnemyChirho : MonoBehaviour
{
    public int TypeEnemyChirho = 0;
    public Transform positionPlayerChirho;
    public float speedChirho = 2f;
    private float maxDistanceChirho = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        DistanceChirho();
        if(TypeEnemyChirho == 1)
        {
            LookAtPlayerQuaternionChirho();
        }
        else if(TypeEnemyChirho == 2){
            FollowPlayerChirho();
        }
        else
        {
            LookAtPlayerQuaternionChirho();
            FollowPlayerChirho();
        }
    }

    void DistanceChirho()
    {
        float distanceChirho = Vector3.Distance(positionPlayerChirho.position, transform.position);
        speedChirho = 2f;
        if(distanceChirho < maxDistanceChirho)
        {
            speedChirho = 0;
        }
        
    }

    void LookAtPlayerQuaternionChirho()
    {
        Quaternion rotationChirho = Quaternion.LookRotation(positionPlayerChirho.position - transform.position);
        transform.rotation = rotationChirho;
    }

    void FollowPlayerChirho()
    {
        transform.position = Vector3.Lerp(transform.position, positionPlayerChirho.position, speedChirho * Time.deltaTime);
    }
}
