using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
public class ImageRetriever : MonoBehaviour
{
    [SerializeField] ImageFromGoogle imageFromGoogle;
    [SerializeField] RawImage rawImage;
    private void Awake()
    {
        imageFromGoogle = FindObjectOfType<ImageFromGoogle>(); 
    }

    public void GetImage()
    {
        rawImage.texture = imageFromGoogle.getTexture;
    }
}
