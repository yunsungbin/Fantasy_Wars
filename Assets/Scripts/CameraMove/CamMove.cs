using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    private float move;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveCamera());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveCamera()
    {
        for(int i = 1; i < 11; i++)
        {
            move = i * 0.2f;
            transform.position = new Vector3(-move, 0, -10);
            yield return new WaitForSeconds(0.05f);
            if(i == 10)
            {
                yield return new WaitForSeconds(0.5f);
            }
        }

        for (int i = 10; i > 0; i--)
        {
            move = i * 0.2f;
            transform.position = new Vector3(-move, 0, -10);
            yield return new WaitForSeconds(0.05f);
        }

        for (int i = 1; i < 11; i++)
        {
            move = i * 0.2f;
            transform.position = new Vector3(move, 0, -10);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
