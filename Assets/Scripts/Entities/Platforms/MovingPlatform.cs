using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointA;
    [SerializeField]
    private GameObject _pointB;
    private GameObject _target;
    [SerializeField]
    private float _speed;
    private float _step;
    private void Start()
    {
        _step = _speed * Time.deltaTime;
        transform.position = _pointA.transform.position;
        _target = _pointB;
    }
    private void FixedUpdate()
    {
        checkPositionChangeTarget();
        Move();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.parent = this.transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
    private void checkPositionChangeTarget()
    {
        if (transform.position == _pointB.transform.position)
        {
            _target = _pointA;
        }
        else if (transform.position == _pointA.transform.position)
        {
            _target = _pointB;
        }
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _step);
    }
}
