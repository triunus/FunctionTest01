using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnityClass", menuName = "TestReference Test/Reference/UnityClass")]
public class UnityClass : ScriptableObject
{
    [SerializeField]
    private Texture2D test01;

    public Texture2D Test01 { get { return this.test01; } set { this.test01 = value; } }
}

[CreateAssetMenu(fileName = "UnityClassColony", menuName = "TestReference Test/Reference/UnityClassColony")]
public class UnityClassColony : ScriptableObject
{
    [SerializeField]
    private List<Texture> test01;

    public int Count { get { return this.test01.Count; } }
    public Texture GetTexture(int i) { return this.test01[i]; }
    public ref List<Texture> GetAllTexture() { return ref this.test01; }
}