using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserClassSequencyListTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(UserClassList.Instance.GroupCount);
        Debug.Log(UserClassList.Instance.GetGroup(0));
        Debug.Log(UserClassList.Instance.GetGroup(0).UserCount);
        Debug.Log(UserClassList.Instance.GetGroup(0).GetUser(0));
        Debug.Log(UserClassList.Instance.GetGroup(0).GetUser(0).ID);
        Debug.Log(UserClassList.Instance.GetGroup(0).GetUser(0).PW);
        Debug.Log(UserClassList.Instance.GetGroup(0).GetUser(1));
        Debug.Log(UserClassList.Instance.GetGroup(0).GetUser(1).ID);
        Debug.Log(UserClassList.Instance.GetGroup(0).GetUser(1).PW);
    }
}
