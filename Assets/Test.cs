using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        // anchorMin-Max는 상대값으로 위치 조정.
        this.gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(0.3f, 0.5f);
        this.gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.7f);

        // offestMin-Max는 절대값으로 위치 조정.
        this.gameObject.GetComponent<RectTransform>().offsetMin = new Vector2(0.5f, 0.7f);
        this.gameObject.GetComponent<RectTransform>().offsetMax = new Vector2(0.5f, 0.7f);
    }
}
