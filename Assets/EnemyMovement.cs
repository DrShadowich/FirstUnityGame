using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField][Range(1, 10)] private int HardLevel;
    private PlayerMove _target;
    private Vector3 _directionOnTarget;
    void Start()
    {
        _target = FindObjectOfType<PlayerMove>();
        _directionOnTarget = Vector3.RotateTowards(transform.forward, _target.transform.position - transform.position, 20, 0.0f);
    }

    
    void Update()
    {

        _directionOnTarget = Vector3.RotateTowards(transform.forward, _target.transform.position - transform.position, 20, 0.0f);

        if (_target.transform.position.x > transform.position.x) transform.Translate(HardLevel * Time.deltaTime * new Vector3(1f, 0, 0));
        else if (_target.transform.position.x < transform.position.x) transform.Translate(HardLevel * Time.deltaTime * new Vector3(-1f, 0, 0));

        if (_target.transform.position.z > transform.position.z) transform.Translate(HardLevel * Time.deltaTime * new Vector3(0, 0, 1f));
        else if (_target.transform.position.z < transform.position.z) transform.Translate(HardLevel * Time.deltaTime * new Vector3(0, 0, -1f));

        transform.rotation = Quaternion.LookRotation(_directionOnTarget);
    }
}
