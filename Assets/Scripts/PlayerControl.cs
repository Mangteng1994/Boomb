using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    // Update is called once per frame
    //炸弹预制件，关联“层级”面板中创建好的炸弹预制件
    public GameObject BombPre;
    //炸弹CD计时器
    private float CD = 2;
    void Update()
    {    //移动部分
        //获取水平虚拟轴
        float horizontal = Input.GetAxis("Horizontal");
        //获取垂直虚拟轴
        float vertical = Input.GetAxis("Vertical");
        //创建向量
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        //如果向量不等于0，表名按下了方向键
        if (dir!=Vector3.zero)
        {
            //玩家转向向量
            transform.rotation = Quaternion.LookRotation(dir);
            //以每秒2m向前移动
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
        //计时器时间增加
        CD += Time.deltaTime;
        //如果按下U键
        if (Input.GetKeyDown(KeyCode.U))
        {
            //2s的CD
            if (CD>2)
            {
                //重置CD
                CD = 0;
                //释放炸弹
                Instantiate(BombPre,transform.position,transform.rotation);
            }
        }
    }
}
