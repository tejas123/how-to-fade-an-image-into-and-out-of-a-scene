using UnityEngine;
using System.Collections;

public class PanelManager : MonoBehaviour {
    public GameObject panelOne, panelTwo;
    public static PanelManager instance;

    void Awake()
    {
        instance = this;
    }
}
