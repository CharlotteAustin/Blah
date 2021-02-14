using UnityEngine;
using System.IO;

public class ButtonBehaviour : MonoBehaviour
{
    public AudioManager audioManager;

    public void HoverAudio()
    {
        audioManager.Play("ButtonHover");
    }

    public void ClickAudio()
    {
        audioManager.Play("ButtonClick");
    }
}
