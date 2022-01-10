using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private GameObject _me;
    [SerializeField]
    private float _velocity;


    void Start()
    {
        _me = this.gameObject;
    }
    void Update()
    {
        Vector3 _DownVelocity = new Vector3(0,_velocity,0) * Time.deltaTime;
        _me.transform.position -= _DownVelocity;
    }
}
