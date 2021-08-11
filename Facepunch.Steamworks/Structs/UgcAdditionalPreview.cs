using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steamworks.Data
{
    public struct UgcAdditionalPreview
    {
        internal UgcAdditionalPreview(uint index, uint previewIndex, string urlOrVideoID, string originalFileName, ItemPreviewType itemPreviewType)
        {
            this.Index = index;
            this.PreviewIndex = previewIndex;
            this.UrlOrVideoID = urlOrVideoID;
            this.OriginalFileName = originalFileName;
            this.ItemPreviewType = itemPreviewType;
        }
        public uint Index { get; private set; }
        public uint PreviewIndex { get; private set; }
        public string UrlOrVideoID { get; private set; }
        public string OriginalFileName { get; private set; }
        public ItemPreviewType ItemPreviewType { get; private set; }
    }
}
