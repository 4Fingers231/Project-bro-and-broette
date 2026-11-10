using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainGame : MonoBehaviour
{
    public DialogSequence[] Dialogs;
    public TMP_Text TextDialog;
    public TMP_Text TextCharacterName;
    public Image ImageCharacter;
    public Image ImageBackground;
    public int _CurrentSequenceNumber;
    public AudioSource audioSource;
    public void OnClickNextDialog()
        {
            if (_CurrentSequenceNumber < Dialogs.Length-1)
            {
                audioSource.Play();
                _CurrentSequenceNumber++;
                UpdateDialogSequence(Dialogs[_CurrentSequenceNumber]);
            }
            else
            {
                if (_CurrentSequenceNumber >= Dialogs.Length-1)
                {
                    if (SceneManager.GetActiveScene().name == "MAINGAME")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("CHOIX");
                    }
                    /////////////////////////////////////////////////////////
                    if (SceneManager.GetActiveScene().name == "MAINGAME1")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("CHOIX1");
                    }
                    if (SceneManager.GetActiveScene().name == "MAINGAME1_1")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("ending 1");
                    }
                    if (SceneManager.GetActiveScene().name == "MAINGAME1_2")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("ending 2");
                    }
//////////////////////////////////////////////////////////////////////////
                    if (SceneManager.GetActiveScene().name == "MAINGAME2")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("CHOIX2");
                    }
                    if (SceneManager.GetActiveScene().name == "MAINGAME2_1")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("ending 3");
                    }
                    if (SceneManager.GetActiveScene().name == "MAINGAME2_2")
                    {
                        audioSource.Play();
                        SceneManager.LoadScene("ending 4");
                    }
                }
            }
           
        }
  
    void UpdateDialogSequence( DialogSequence sequence )
    {
        TextDialog.text = sequence.TextDialog;
        TextCharacterName.text = sequence.TextNameCharacter;
        ImageCharacter.sprite = sequence.SpriteCharacter;
        ImageBackground.sprite = sequence.SpriteBackground;
    }
    void Start()
    {
        UpdateDialogSequence(Dialogs[0]);
        OnClickNextDialog();
    }
    
        
}

