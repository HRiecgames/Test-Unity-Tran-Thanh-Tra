using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : ScriptableObject
{
    public GameObject itemViewPrefab;
    public List<Sprite> items = new List<Sprite>();

    public List<Sprite> bonusItems = new List<Sprite>();
}
