using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ImageFromGoogle : MonoBehaviour
{
    [SerializeField] string Url;
    public Texture getTexture;

    IEnumerator GetTexture(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.Send();

        Texture myTexture = DownloadHandlerTexture.GetContent(www);
        getTexture = myTexture;
    }

    private void Start()
    {
        StartCoroutine(GetTexture(Url));
    }
}
