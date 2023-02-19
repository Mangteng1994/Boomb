using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    // Update is called once per frame
    //ը��Ԥ�Ƽ����������㼶������д����õ�ը��Ԥ�Ƽ�
    public GameObject BombPre;
    //ը��CD��ʱ��
    private float CD = 2;
    void Update()
    {    //�ƶ�����
        //��ȡˮƽ������
        float horizontal = Input.GetAxis("Horizontal");
        //��ȡ��ֱ������
        float vertical = Input.GetAxis("Vertical");
        //��������
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        //�������������0�����������˷����
        if (dir!=Vector3.zero)
        {
            //���ת������
            transform.rotation = Quaternion.LookRotation(dir);
            //��ÿ��2m��ǰ�ƶ�
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
        //��ʱ��ʱ������
        CD += Time.deltaTime;
        //�������U��
        if (Input.GetKeyDown(KeyCode.U))
        {
            //2s��CD
            if (CD>2)
            {
                //����CD
                CD = 0;
                //�ͷ�ը��
                Instantiate(BombPre,transform.position,transform.rotation);
            }
        }
    }
}
