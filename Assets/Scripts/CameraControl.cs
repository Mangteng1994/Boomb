using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //保存向量
    private Vector3 vector;
    //玩家的Transform组件
    private Transform player;
    void Start()
    {
        //通过标签获得玩家Transform组件
        player = GameObject.FindWithTag("Player").transform;
        //获取从摄像机到玩家的向量
        vector = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //执行向量计算，更新摄像机的位置进行跟随
        transform.position = player.transform.position - vector;
    }
}
