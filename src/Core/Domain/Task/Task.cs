namespace Core.Domain.Task
{
    public class Task
    {
        public string Title { get; private set; }
        public int EstimateInWholeHours { get; private set; }
        public string AdditionalContext { get; private set; }
        public Task()
        {
            
        }

        private void SetTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new System.ArgumentException($"'{nameof(title)}' cannot be null or empty.", nameof(title));
            }

            Title = title;
        }

        private void SetEstimate(int estimateInWholeHours)
        {
            EstimateInWholeHours = estimateInWholeHours;
        }

        private void SetAdditionalContext(string additionalContextDescription)
        {
            AdditionalContext = additionalContextDescription;
        }
    }
}