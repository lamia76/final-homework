using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Gamemanger : MonoBehaviour
{   
    public GameObject st;//开始按钮按钮
    public GameObject SettingPanel;//设置面板
    public GameObject PricePanel;//价格面板图片
    public int P1Money;//玩家一金钱
    public int P2Money;//玩家二金钱
    public int P3Money;//玩家三金钱
    public int P4Money;//玩家四金钱
    // Start is called before the first frame update
    void Start()
    {
       SettingPanel.gameObject.SetActive(false);
       PricePanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void GameStartButton()//开始按钮
    {
       st.gameObject.SetActive(false);
       PricePanel.gameObject.SetActive(true);
    }
    public  void GameSettingButton()//设置按钮
    {
       SettingPanel.gameObject.SetActive(true);
    }
    public  void GameSettingButtonOFF()//设置界面关闭按钮
    {
       SettingPanel.gameObject.SetActive(false);
    }
}
