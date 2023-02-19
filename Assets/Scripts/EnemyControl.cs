using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    //��ҽ�ɫ
    private GameObject player;
    void Start()
    {
        //ͨ����ǩ��ȡ��ҽ�ɫ
        player = GameObject.FindWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        //��ȡ����ҽ�ɫ����
        float distance = Vector3.Distance(player.transform.position,transform.position);
        //�������С��3m��׷�����
        if (distance<3)
        {
            //�������
            transform.LookAt(player.transform);
            //������ƶ�
            transform.Translate(Vector3.forward*1f*Time.deltaTime);
            
        }
        //�������С��2m�������
        if (distance<2)

        {
            //Destroy(player);
            Debug.Log("�����������Ϸ����");
            Time.timeScale = 0;
        }
    }
}
