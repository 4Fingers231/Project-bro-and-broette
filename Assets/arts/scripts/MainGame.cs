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
    public void OnClickNextDialog()
        {
            if (_CurrentSequenceNumber < Dialogs.Length-1)
            {
                _CurrentSequenceNumber++;
                UpdateDialogSequence(Dialogs[_CurrentSequenceNumber]);
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

