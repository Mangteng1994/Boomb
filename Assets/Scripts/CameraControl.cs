using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //��������
    private Vector3 vector;
    //��ҵ�Transform���
    private Transform player;
    void Start()
    {
        //ͨ����ǩ������Transform���
        player = GameObject.FindWithTag("Player").transform;
        //��ȡ�����������ҵ�����
        vector = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ִ���������㣬�����������λ�ý��и���
        transform.position = player.transform.position - vector;
    }
}
