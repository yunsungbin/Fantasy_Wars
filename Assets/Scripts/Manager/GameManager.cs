using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject MoveControler;
    private void Awake()
    {
        StartCoroutine(MoveActiveTRUE());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveActiveTRUE()
    {
        yield return new WaitForSeconds(2.1f);
        MoveControler.SetActive(true);
    }
}
