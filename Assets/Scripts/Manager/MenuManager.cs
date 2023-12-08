using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Objects;
    public static int Map = 0;
    //public static bool AnimStart = false;
    private bool isStart = false; //게임을 실행했을 때만 나오게

    private void Awake()
    {
        Map = 0;
        //AnimStart = false;
        if (!isStart)
        {
            Objects[0].SetActive(true);
            isStart = true;
        }
        Objects[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        Objects[0].SetActive(false);
        Objects[1].SetActive(true);
        Objects[2].SetActive(true);
    }

    public void GameMenuON()
    {
        Objects[3].SetActive(true);
    }

    public void GameMenuOFF()
    {
        Objects[3].SetActive(false);
    }

    public void GlassMapStart()
    {
        Map = 1;
        SceneManager.LoadScene("Stage");
    }
}
