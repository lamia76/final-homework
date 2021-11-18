using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Card : MonoBehaviour
{   
    private int cardType;//花色 0黄色 1蓝色 2红色 3绿色 4橙色

    private int cardValue;//出售方式 0公开竞价 1一轮竞价 2暗标拍卖 3定价拍卖 4联合拍卖

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Enter ()
    {    
        transform.localScale = new Vector3(1.3f,1.3f,1.3f);//1.3倍大小
    }
    //鼠标移出范围
    public void Exit ()
    {
        //恢复原本大小
        transform.localScale = new Vector3(1f,1f,1f);//1倍大小
    } 
    public int GetCardValue
    {
        set { cardValue = value; }
        get { return cardValue; }
    }
    public int GetCardType
    {
        set { cardType = value; } 
        get { return cardType; }
    }
}
