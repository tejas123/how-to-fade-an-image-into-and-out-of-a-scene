using UnityEngine;
using System.Collections;

public class PanelOne : MonoBehaviour {

	// Use this for initialization
    void OnEnable()
    {
        //GameObject.Find("FadeGameObject").GetComponent<Fading>().BeginFade(-1);
    }

    void OnDisable()
    {
       // GameObject.Find("FadeGameObject").GetComponent<Fading>().BeginFade(-1);
    }

    public void onGotoSecondButtonClick()
    {
        PanelManager.instance.panelTwo.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
