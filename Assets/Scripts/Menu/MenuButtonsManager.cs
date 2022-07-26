using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonsManager : MonoBehaviour
{
    public List<GameObject> buttons;

    [Header("Animations Variables")]
    public float duration = .1f;
    public float startDelay = .1f;
    public float delay = .1f;
    public Ease easy = Ease.OutBack;

    private void OnEnable()
    {
        HideAllButtons();
        Invoke(nameof(ShowButtons),startDelay);
        
        //ShowButtons();
    }
    
    private void HideAllButtons()
    {
        foreach(var b in buttons)
        {
            b.transform.localScale = Vector3.zero;
            b.SetActive(false);
        }
    }
    
    private void ShowButtons()
    {
        //foreach (var b in buttons)
        for(int i = 0; i < buttons.Count; i++)
        {
            var b = buttons[i];
            b.SetActive(true);
            b.transform.DOScale(1, duration).SetDelay(startDelay + i*delay).SetEase(easy);
            //b.transform.DOScale(1, duration).SetDelay(i*delay).SetEase(easy);
        }
    }    
}