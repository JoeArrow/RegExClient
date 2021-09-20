#region © 2021 Aflac.
//
// All rights reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical, or otherwise, is prohibited
// without the prior written consent of the copyright owner.
//
#endregion

namespace RegExClient
{
    // ----------------------------------------------------
    /// <summary>
    ///     SampleRegEx Description
    /// </summary>

    public class SampleRegEx
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Expression { get; set; }

        // ------------------------------------------------

        public override string ToString()
        {
            return Name;
        }
    }
}
