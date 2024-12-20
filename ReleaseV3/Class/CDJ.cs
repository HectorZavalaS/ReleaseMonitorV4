using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseMonitorV4.Class
{
    public class CDJ
    {
        string m_review;
        string m_route;
        string m_batchId;
        int m_batchQty;
        bool m_isMit;

        public string Review { get => m_review; set => m_review = value; }
        public string Route { get => m_route; set => m_route = value; }
        public string BatchId { get => m_batchId; set => m_batchId = value; }
        public int BatchQty { get => m_batchQty; set => m_batchQty = value; }
        public bool IsMit { get => m_isMit; set => m_isMit = value; }

        public CDJ(String review, String route, String Batch, int Qty, bool isMit)
        {
            Review = review;
            Route = route;
            BatchId = Batch;
            BatchQty = Qty;
            IsMit = isMit;
        }
    }
}
