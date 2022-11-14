using UnityEngine;


public class PlayerChirho : MonoBehaviour
{
    public GameObject objectChirho;
    public Transform placeChirho;

    void Update()
    {
        MovementPlayerChirho();
    }

    void MovementPlayerChirho()
    {
        float movXChirho = Input.GetAxis("Horizontal");
        float movYChirho = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movXChirho, 0, movYChirho));
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0,-2.5f,0));
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0,2.5f,0));
        }
    }

}
