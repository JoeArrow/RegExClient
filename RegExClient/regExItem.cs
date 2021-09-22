#region © 2021 Aflac.
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

    public class regExItem
    {
        public string RegEx { get; set; }
        public string Text { get; set; }

        // ------------------------------------------------

        public override string ToString()
        {
            var jsSer = new JavaScriptSerializer();
            return jsSer.Serialize(this);
        }
    }
}
