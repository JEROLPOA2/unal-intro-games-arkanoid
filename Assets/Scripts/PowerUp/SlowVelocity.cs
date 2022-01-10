using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowVelocity : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _activeBalls;

    [SerializeField]
    private GameObject _me;
    void Start()
    {
        _me = this.gameObject;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Ball[] _Balls = GameObject.FindObjectsOfType<Ball>();
        foreach(Ball comp in _Balls)
        {
            _activeBalls.Add(comp.gameObject);
        }

        for(int i = 0; i<_activeBalls.Count;i++)
        {
            Ball _ballComponent = _activeBalls[i].gameObject.GetComponent<Ball>();
            _ballComponent._initSpeed = 3;
            _ballComponent.Start();
        }
        Destroy(_me);
    }
}
