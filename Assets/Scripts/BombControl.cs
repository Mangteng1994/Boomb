using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombControl : MonoBehaviour
{
    public GameObject EffectPre;
    //��ըЧ��Ԥ�Ƽ�����������Ŀ������ֵ�Explosion
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Boom",2f);
    }
    void Boom()
    {
        //��ըЧ��
        GameObject effect = Instantiate(EffectPre, transform.position,transform.rotation);
                                                                      //2s��ɾ����ըЧ��
            Destroy(effect,2f);
        //��ȡ�����еĵ���
        GameObject[]ememys=GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in ememys)
        {
            //�жϸõ��˺�ը����ľ����Ƿ�С��3m
            if (Vector3.Distance(transform.position,enemy.transform.position)<3f)
            {
                Destroy(enemy);
            }
            //ը����������
            Destroy(gameObject);
        }
    }
    //��������
  
    // Update is called once per frame
   
}
