using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddPoints : MonoBehaviour
{
    private ArkanoidController _ark;

    [SerializeField]
    private int _score;

    [SerializeField]
    private GameObject _me;

    [SerializeField]
    private GameObject _grid;

    void Start()
    {
        _me = this.gameObject;
        _grid = GameObject.Find("GridController");
        _ark = _grid.GetComponent<ArkanoidController>();
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        _ark._totalScore += _score;
        ArkanoidEvent.OnScoreUpdatedEvent?.Invoke(_score, _ark._totalScore);
        Destroy(_me);
    }
}
