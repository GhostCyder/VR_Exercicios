using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    [SerializeField] private Image targetImage;
    [SerializeField] private Sprite[] images;

    public void ShowImage(int index)
    {
        if (index < 0 || index >= images.Length)
            return;

        targetImage.sprite = images[index];
    }
}