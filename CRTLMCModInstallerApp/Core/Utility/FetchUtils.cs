using System.Threading.Tasks;
using Avalonia.Controls;

namespace CRTLMCModInstallerApp.Core.Utility;

public class FetchUtils
{
    public static async Task<string> OpenAndRetrieveDirectory(Window window)
    {
        OpenFolderDialog folderDialog = new OpenFolderDialog();
        return await folderDialog.ShowAsync(window);
    }
}