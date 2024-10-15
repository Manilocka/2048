using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private Sprite musicOnSprite;  
    [SerializeField] private Sprite musicOffSprite; 
    [SerializeField] private Button musicButton;     

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); 
        UpdateButtonSprite(); 
    }

    public void ToggleMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();
        }

        UpdateButtonSprite(); 
    }

    private void UpdateButtonSprite()
    {
        
        if (audioSource.isPlaying)
        {
            musicButton.GetComponent<Image>().sprite = musicOnSprite;
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicOffSprite;
        }
    }
}