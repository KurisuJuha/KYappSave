using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KYapp.Save.Runtime;
using KYapp.Save.Editor;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RuntimeSave.Save("test2");
        Debug.Log(RuntimeSave.Load());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
