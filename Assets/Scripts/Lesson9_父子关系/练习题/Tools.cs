using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools {
    public static void Sort(this Transform obj) {
        List<Transform> list = new List<Transform>();
        for (int i = 0; i < obj.childCount; i++) {
            list.Add(obj.GetChild(i));
        }
        list.Sort((a, b) => {
            if (a.name.Length < b.name.Length)
                return -1;
            else return 1;
        });
        for (int i = 0; i < list.Count; i++) {
            list[i].SetSiblingIndex(i);
        }
    }
    public static Transform FindMyChild(this Transform father, string objName) {
        Transform target = null;
        target = father.Find(objName);
        if (target != null) {
            return target;
        }
        for (int i = 0; i < father.childCount; i++) {
            target = father.GetChild(i).FindMyChild(objName);
            if (target != null) { return target; }
        }
        return target;
    }
}
