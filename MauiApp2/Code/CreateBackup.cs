using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using CommunityToolkit.Maui.Storage;
using Windows.Networking.Sockets;

namespace simulcrum
{
	public static class CreateBackup
	{
		public static string destPath = "";

		public async static void destbtn_Click()
		{
			var folderPicker = await FolderPicker.PickAsync(default);
			var folderPath = folderPicker.Folder.Path;
			destPath = folderPath;
		}
	}
}
