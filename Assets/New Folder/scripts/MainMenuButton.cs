using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainMenuButton : MonoBehaviour
{
    public Image ImageOutline;
    public TMP_Text UITextMeshPro;
    public Color InitialColor, OverColor;
    public Image ImageFade;
    public List<MainMenuButton> Buttons;
    // Start is called before the first frame update
    private void Start()
    {
        ImageFade.DOFade(0,0);
        ImageFade.gameObject.SetActive(false);
    }
    public void Hide(float time)
    {
        ImageOutline.DOKill();
        ImageOutline.DOFade(0, time);
        UITextMeshPro.DOKill();
        UITextMeshPro.DOColor(OverColor, time);
        _hidden = true;
    }
    bool _hidden = false;
    public void OnPointerEnter()
    {
        if (_hidden == true) {return;}
        ImageOutline.DOKill();
        ImageOutline.DOFade(1, 0.6f);
        UITextMeshPro.DOKill();
        UITextMeshPro.DOColor(OverColor,0.3f);
    }
    public void OnPointerExit()
    {
        if (_hidden == true) {return;}
        ImageOutline.DOKill();
        ImageOutline.DOFade(0, 0.1f);
        UITextMeshPro.DOKill();
        UITextMeshPro.DOColor(InitialColor,0.2f);
    }
    public void OnClickPlay()
    {
        ImageFade.gameObject.SetActive(true);
        ImageFade.DOFade(1, 0.8f).OnComplete(FadeComplete);
        for (int i = 1; i < Buttons.Count; i++)
        {
            Buttons[i].Hide(0.1f);
        }
    }
    public void FadeComplete()
    {
        SceneManager.LoadScene("MAINGAME");
    }


    // Update is called once per frame
    void Update()
    {
    }
}
