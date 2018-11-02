using System.ComponentModel;

namespace App.Data.Enums
{
    public enum OrderStatus
    {
        [Description("New bill")]
        New = 1,

        [Description("In Progress")]
        InProgress = 2,

        [Description("Being Transported")]
        BeingTransported = 3,

        [Description("Returned")]
        Returned = 4,

        [Description("Cancelled")]
        Cancelled = 5,

        [Description("Completed")]
        Completed = 6
    }
}