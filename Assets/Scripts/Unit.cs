using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type { Sword, Range, Guard, Wizard, Bullet };
public class Unit : MonoBehaviour
{

    public Type type;

    [SerializeField]
    private float Speed;
    [SerializeField]
    private GameObject Dust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
