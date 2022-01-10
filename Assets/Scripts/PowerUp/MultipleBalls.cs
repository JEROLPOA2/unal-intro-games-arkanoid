using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleBalls : MonoBehaviour
{

    [SerializeField]
    private GameObject _ballPrefab;
    [SerializeField]
    private GameObject _me;
    private const string BALL_PREFAB_PATH = "Prefabs/Ball";
    void Start()
    {
        _ballPrefab = Resources.Load<GameObject>(BALL_PREFAB_PATH);
        _me = this.gameObject;
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        for(int i = 0; i<2; i++)
        {
            Instantiate(_ballPrefab, new Vector3(0,-0.86f,0),Quaternion.identity);
        
        }
        Destroy(_me);
    }
    
}
