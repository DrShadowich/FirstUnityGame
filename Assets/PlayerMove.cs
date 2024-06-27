using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Range(0.1f, 5f)] public float Speed = 5f;
    

    void Start()
    {

    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        transform.Translate(Speed * Time.deltaTime * new Vector3(horizontalMove, 0, 0));
        transform.Translate(Speed * Time.deltaTime * new Vector3(0, 0, verticalMove));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy")) Debug.Log("Вас поймали!");
    }
}

