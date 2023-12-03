using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TabGroup))]
public class TabGroupEditor : Editor
{
    SerializedProperty tabButtons;
    SerializedProperty objectsToSwap;
    SerializedProperty tabSettings;
    SerializedProperty arraySize;

    private void OnEnable()
    {
        tabButtons = serializedObject.FindProperty("tabButtons");
        objectsToSwap = serializedObject.FindProperty("objectsToSwap");
        tabSettings = serializedObject.FindProperty("tabSettings");
        arraySize = serializedObject.FindProperty("arraySize");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(arraySize);

        arraySize.intValue = Mathf.Max(0, arraySize.intValue);

        while (tabButtons.arraySize < arraySize.intValue)
        {
            tabButtons.InsertArrayElementAtIndex(tabButtons.arraySize);
            objectsToSwap.InsertArrayElementAtIndex(objectsToSwap.arraySize);
        }

        while (tabButtons.arraySize > arraySize.intValue)
        {
            tabButtons.DeleteArrayElementAtIndex(tabButtons.arraySize - 1);
            objectsToSwap.DeleteArrayElementAtIndex(objectsToSwap.arraySize - 1);
        }

        serializedObject.ApplyModifiedProperties();

        EditorGUILayout.LabelField($"{arraySize.intValue} Elements: tabButtons | objectsToSwap");
        for (int i = 0; i < arraySize.intValue; i++)
        {
            EditorGUILayout.BeginHorizontal();

            SerializedProperty tabButtonElement = tabButtons.GetArrayElementAtIndex(i);
            SerializedProperty objectToSwapElement = objectsToSwap.GetArrayElementAtIndex(i);

            EditorGUILayout.PropertyField(tabButtonElement, GUIContent.none, GUILayout.MinWidth(100f));

            EditorGUILayout.PropertyField(objectToSwapElement, GUIContent.none, GUILayout.MinWidth(100f));

            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.Space();

        EditorGUILayout.PropertyField(tabSettings, true);

        serializedObject.ApplyModifiedProperties();
    }
}
