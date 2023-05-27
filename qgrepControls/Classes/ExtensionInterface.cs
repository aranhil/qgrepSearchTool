﻿using qgrepControls.ModelViews;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace qgrepControls.Classes
{
    public interface IExtensionInterface
    {
        string GetSolutionPath(bool useGlobalPath);
        void GatherAllFoldersAndExtensionsFromSolution(StringCallback extensionCallback, StringCallback folderCallback);
        void OpenFile(string path, string line);
        string GetSelectedText();
        System.Drawing.Color GetColor(string resourceKey);
        string GetMonospaceFont();
        string GetNormalFont();
        void RefreshResources(Dictionary<string, object> newResources);
        bool SearchWindowOpened { get; set; }
        bool IsStandalone { get; }
        Dictionary<string, Hotkey> ReadKeyBindings();
        void ApplyKeyBindings(Dictionary<string, Hotkey> bindings);
        void SaveKeyBindings(Dictionary<string, Hotkey> bindings);
        System.Windows.Window GetMainWindow();
        void GetIcon(string filePath, uint background, SearchResult searchResult);
    }
}
