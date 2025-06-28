using System.Collections.Generic;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.RemoteUpload;

/// <summary>
/// Represents the configuration settings for the RemoteUpload plugin.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        uploaddir = "/";
        uploaddirs = new List<string>();
    }

    /// <summary>
    /// Executable for media-upload-plugin
    /// </summary>
    public string uploaddir { get; set; }

    /// <summary>
    /// List of upload directories
    /// </summary>
    public List<string> uploaddirs { get; set; }

    /// <summary>
    /// Adds a directory to the list if not already present.
    /// </summary>
    public void AddUploadDir(string dir)
    {
        if (!uploaddirs.Contains(dir))
        {
            uploaddirs.Add(dir);
        }
    }
}
