using System;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Contains my site's global variables.
/// </summary>
public static class Global
{
    /// <summary>
    /// Global variable storing important stuff.
    /// </summary>
    static bool _normBool = false;
    static bool _genBool = false;

    /// <summary>
    /// Get or set the static important data.
    /// </summary>
    public static bool NormBool
    {
        get { return _normBool; }
        set { _normBool = value; }
    }

    public static bool GenBool
    {
        get { return _genBool; }
        set { _genBool = value; }
    }
}