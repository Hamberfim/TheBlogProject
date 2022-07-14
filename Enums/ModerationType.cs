using System.ComponentModel;

namespace TheBlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political")]
        Political,
        [Description("Offensive Language")]
        Language,
        [Description("Drug Reference")]
        Drugs,
        [Description("Threatening Speach")]
        Threatening,
        [Description("Sexual Content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming
    }
}
