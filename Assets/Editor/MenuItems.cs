using UnityEditor;
namespace Game
{
    public class MenuItems
    {
        [MenuItem("CustomMenu/Изменения цвета")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "MyMenu");
        }
    }
}