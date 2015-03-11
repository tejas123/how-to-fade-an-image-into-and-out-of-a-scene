using UnityEngine;
using System.Collections;

public class PanelTwo : MonoBehaviour {

    void OnEnable()
    {
        GameObject.Find("FadeGameObject").GetComponent<Fading>().BeginFade(-1);
    }

    public void onGotoFirstButtonClick()
    {
        this.gameObject.SetActive(false);
        PanelManager.instance.panelOne.gameObject.SetActive(true);
    }
}
