using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveLocal : MonoBehaviour
{
    public Vector3 moveAxis = new Vector3(0, 1, 0);
    public float speed = 1;
    public float destroyTime = 5;

    private void Awake()
    {
        Destroy(gameObject, destroyTime);
        //5초 후에 자기 자신을 삭제
    }
    void Update()
    {
        transform.Translate(moveAxis * speed * Time.deltaTime, Space.Self);
    }
}
