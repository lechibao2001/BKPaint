using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPaint.Utils
{
    /// <summary>
    /// Enum cho biết lựa chọn hình vẽ hiện tại của người dùng
    /// </summary>
    public enum CurrentShapeStatus
    {
        Void,
        Line,
        Rectangle,
        Ellipse,
        Square,
        Circle,
        Curve,
        Polygon,
        Pen,
        Eraser
    }
}
