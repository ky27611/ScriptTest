using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //　魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //配列を初期化
        int[] array = { 10, 20, 30, 40, 50 };

        //順番に表示
        Debug.Log("順番に表示");

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //逆順に表示
        Debug.Log("逆順に表示");
        
        for (int i = array.Length - 1 ; i > -1; i--)
        {
            Debug.Log(array[i]);
        }


        //魔法使用
        Boss lastboss = new Boss();
        
        for (int i = 0; i < 11 ; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
