﻿namespace NetlifySharp.Models
{
    // Not in Open API specification (https://github.com/netlify/open-api/issues/47)
    public partial class CssProcessingSettings : Model
    {
        public CssProcessingSettings(NetlifyClient client) : base(client)
        {
        }

        public bool? Bundle { get; set; }
        public bool? Minify { get; set; }
    }
}
