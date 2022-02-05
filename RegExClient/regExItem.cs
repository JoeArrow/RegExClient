#region © 2021 JoeWare.
//
// All rights reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical, or otherwise, is prohibited
// without the prior written consent of the copyright owner.
//
#endregion

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
