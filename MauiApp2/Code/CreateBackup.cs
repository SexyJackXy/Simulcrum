using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using CommunityToolkit.Maui.Storage;

namespace simulcrum
{
    public static class CreateBackup
    {
        public static string destPath = "";
        public static List<string> sourcePaths;
        public static string sourcePathsText = String.Join("", sourcePaths);

        private async static Task<string> SelectFolderAsync()
        {
            var folderPicker = await FolderPicker.PickAsync(default);
            if (folderPicker != null)
            {
                return folderPicker.Folder.Path;
            }
            else
            {
                return string.Empty; // Oder eine andere Standardeinstellung, wenn kein Ordner ausgewählt wurde
            }
        }

        public async static void destbtn_Click()
        {
            destPath = await SelectFolderAsync();
        }

        public async static void sourcebtn_Click()
        {
            var selectedFolder = await SelectFolderAsync();

            if (String.IsNullOrEmpty(selectedFolder))
            {
                sourcePaths.Add(selectedFolder);
            }
        }
    }
}
