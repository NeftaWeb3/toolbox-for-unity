namespace Nefta.Core
{
    public class Analytics
    {
        public enum Events
        {
            TutorialComplete,
            NewHighScore,
            Achievement,
            SelectContent,
            SpendVirtualCurrency,
            LevelAchieved,
            Unlock,
            PurchaseClick,
            PurchaseCancelled,
            PurchaseComplete,
        }

        /// <summary>
        /// Call this function to enable or disable tracking of the analytic events
        /// </summary>
        /// <param name="enable">True to enable and False to disable</param>
        public void EnableTracking(bool enable)
        {
            
        }

        /// <summary>
        /// Call this function to track player behaviour
        /// </summary>
        /// <param name="event">The event or action name</param>
        /// <param name="parameter">Name, subtype or name of object used in action</param>
        public void AddEvent(Events @event, string parameter)
        {
            
        }

        /// <summary>
        /// If case you want to track anything in more detail, you can use this method with custom data
        /// </summary>
        /// <param name="data">Custom tracking data</param>
        public void AddCustomEvent(string data)
        {
            
        }
    }
}