using UnityEditor;
using UnityEngine;


namespace Game
{
    [CustomEditor(typeof(CarContoll))]
    public class CustomCarContoll : Editor
    {
        public override void OnInspectorGUI()
        {
            CarContoll testTarget = (CarContoll)target;
            testTarget.speed = EditorGUILayout.IntSlider(testTarget.speed, 0, 10);
            testTarget.DeadUI =
                EditorGUILayout.ObjectField("Экран проигрыша",
                        testTarget.DeadUI, typeof(GameObject), false)
                    as GameObject;
            testTarget.VictoryUI =
                EditorGUILayout.ObjectField("Экран победы",
                        testTarget.VictoryUI, typeof(GameObject), false)
                    as GameObject;
        }
    }

}

