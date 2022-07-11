using System;

namespace Abby.Utility
{
    public static class SD
    {
        public const string ManagerRole = "Manager";
        public const string FrontDeskRole = "Front";
        public const string KitchenRole = "Kitchen";
        public const string CustomerRole = "Customer";
        public const string StatusPending = "Pending_Payment";  //order is placed and ready to payment
        public const string StatusSubmitted = "Submitted_PaymentApproved";  // submitted payment
        public const string StatusRejected = "Rejected_Payment"; //if card deatils wrong
        public const string StatusInProcess = "Being Prepared"; //food status
        public const string StatusReady = "Ready for Pickup"; //food ready
        public const string StatusCompleted = "Completed"; //
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";
        public const string SessionCart = "SessionCart";
    }
}
