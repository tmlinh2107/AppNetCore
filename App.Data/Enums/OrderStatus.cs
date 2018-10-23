using System.ComponentModel;

namespace App.Data.Enums
{
    public enum OrderStatus
    {
        [Description("New bill")]
        New,

        [Description("In Progress")]
        InProgress,

        [Description("Being Transported")]
        BeingTransported,

        [Description("Returned")]
        Returned,

        [Description("Cancelled")]
        Cancelled,

        [Description("Completed")]
        Completed
    }
}