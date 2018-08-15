using System.ComponentModel;

namespace IntegratedPlugin.Enum
{
    /// <summary>
    /// 页面类型
    /// </summary>
    internal enum PageType
    {
        [Description("患者Caprini评分")]
        CapriniScore,

        [Description("推荐治疗方案")]
        RecommendedTreatmentPlan,

        [Description("推荐治疗方案明细")]
        RecommendedTreatmentPlanDetail
    }
}
