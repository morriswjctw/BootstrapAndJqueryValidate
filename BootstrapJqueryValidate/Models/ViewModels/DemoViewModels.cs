using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapJqueryValidate.Models
{
    public class DemoViewModels
    {
        public List<DemoModel> GetList { get; set; }
    }

    public class DemoModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public string RecId { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 內容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 發表時間
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 發表人
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime? EditDate { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string EditUser { get; set; }
    }
}