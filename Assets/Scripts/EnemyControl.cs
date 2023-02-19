using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    //玩家角色
    private GameObject player;
    void Start()
    {
        //通过标签获取玩家角色
        player = GameObject.FindWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        //获取与玩家角色距离
        float distance = Vector3.Distance(player.transform.position,transform.position);
        //如果距离小于3m，追踪玩家
        if (distance<3)
        {
            //看向玩家
            transform.LookAt(player.transform);
            //向玩家移动
            transform.Translate(Vector3.forward*1f*Time.deltaTime);
            
        }
        //如果距离小于2m玩家死亡
        if (distance<2)

        {
            //Destroy(player);
            Debug.Log("玩家死亡，游戏结束");
            Time.timeScale = 0;
        }
    }
}
