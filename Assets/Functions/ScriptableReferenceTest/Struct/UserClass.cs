using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserClassList", menuName = "TestReference Test/Reference/UserClassList")]
[System.Serializable]
public class UserClassList : ScriptableObject
{
    public static UserClassList instance_;

    [SerializeField]
    private List<UserClass> userGroup;

    public static UserClassList Instance
    {
        get
        {
            if (UserClassList.instance_ == null)
            {
                UserClassList.instance_ = Resources.Load<UserClassList>("Test/UserClassList");
            }

            return UserClassList.instance_;
        }
    }

    public int GroupCount { get { return this.userGroup.Count; } }
    public UserClass GetGroup(int i) { return this.userGroup[i]; }
}

[System.Serializable]
public class UserClass
{
    [SerializeField]
    private List<UserInfo> users;

    public int UserCount { get { return this.users.Count; } }
    public UserInfo GetUser(int i) { return this.users[i]; }
}

[System.Serializable]
public class UserInfo
{
    [SerializeField]
    private string id_;
    [SerializeField]
    private int pw_;

    public string ID { get { return this.id_; } set { this.id_ = value; } }
    public int PW { get { return this.pw_; } set { this.pw_ = value; } }
}