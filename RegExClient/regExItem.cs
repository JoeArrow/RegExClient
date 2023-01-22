using System.Web.Script.Serialization;

namespace RegExClient
{
    // ----------------------------------------------------
    /// <summary>
    ///     RegExObj Description
    /// </summary>

    public class RegExItem
    {
        public string Text { get; set; }
        public string RegEx { get; set; }
        public string ReplaceString { get; set; }

        // ------------------------------------------------

        public string ToJson()
        {
            var jsSer = new JavaScriptSerializer();
            return jsSer.Serialize(this);
        }
    }
}
