using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BookManager : MonoBehaviour
{
    public int BookCount;
    public Text BookText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BookText.text = "Book Collection: " + BookCount.ToString();
    }
}
