using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityClassTest : MonoBehaviour
{
    /*    [SerializeField]
        private UnityClass resourceLoadTest;
        public UnityClass componentTest;*/

    [SerializeField]
    private UnityClassColony unityClassColony;


    private void Awake()
    {
    }

    private void OnEnable()
    {
        this.unityClassColony = Resources.Load<UnityClassColony>("Test/UnityClassColony");

        Debug.Log("private_Resources_01 : " + this.unityClassColony.Count);
        Debug.Log("private_Resources_02 : " + this.unityClassColony.GetTexture(0));
        Debug.Log("private_Resources_03 : " + this.unityClassColony.GetTexture(1));
        Debug.Log("private_Resources_04 : " + this.unityClassColony.GetTexture(2));
        Debug.Log("private_Resources_05 : " + this.unityClassColony.GetAllTexture()[0]);
        Debug.Log("private_Resources_06 : " + this.unityClassColony.GetAllTexture()[1]);
        Debug.Log("private_Resources_07 : " + this.unityClassColony.GetAllTexture()[2]);

    }

    private void Start()
    {
    }
}
