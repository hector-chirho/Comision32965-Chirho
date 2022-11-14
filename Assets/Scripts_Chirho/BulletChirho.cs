using UnityEngine;

public class BulletChirho : MonoBehaviour
{
    public float speedChirho;
    public Vector3 directionChirho;
    public float damageChirho;

    void Update()
    {
        transform.position += new Vector3(directionChirho.x,directionChirho.y,directionChirho.z) * speedChirho * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.localScale += new Vector3(2,2,2);
        }
    }
}
