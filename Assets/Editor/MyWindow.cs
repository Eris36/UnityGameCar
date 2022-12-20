using UnityEditor;
using UnityEngine;
namespace Game
{
    public class MyWindow : EditorWindow
    {
        public static GameObject Object;
        private void OnGUI()
        {
            GUILayout.Label("Выберите объект для назначения рандомного цвета", EditorStyles.boldLabel);
            Object = EditorGUILayout.ObjectField("Объект который хотим изменить цвет",
                        Object, typeof(GameObject), true) as GameObject;
            
            
            var button = GUILayout.Button("Изменить цвет");
            EditorGUILayout.EndToggleGroup();
            if (button)
            {
                var tempRenderer = Object.GetComponent<Renderer>();               
                tempRenderer.material.color = Random.ColorHSV();
            }
        }
    }
}
