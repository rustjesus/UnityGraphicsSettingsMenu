using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadingTip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI loadingTipTxt;
    [SerializeField] private string[] loadingTips;
    // Start is called before the first frame update
    void Start()
    {
        int randomValue = Random.Range(0, loadingTips.Length);
        loadingTipTxt.text = loadingTips[randomValue];
    }
}
