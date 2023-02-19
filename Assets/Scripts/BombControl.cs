using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombControl : MonoBehaviour
{
    public GameObject EffectPre;
    //爆炸效果预制件，关联“项目”面板种的Explosion
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Boom",2f);
    }
    void Boom()
    {
        //爆炸效果
        GameObject effect = Instantiate(EffectPre, transform.position,transform.rotation);
                                                                      //2s后删除爆炸效果
            Destroy(effect,2f);
        //获取场景中的敌人
        GameObject[]ememys=GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in ememys)
        {
            //判断该敌人和炸弹间的距离是否小于3m
            if (Vector3.Distance(transform.position,enemy.transform.position)<3f)
            {
                Destroy(enemy);
            }
            //炸弹自身销毁
            Destroy(gameObject);
        }
    }
    //遍历敌人
  
    // Update is called once per frame
   
}
