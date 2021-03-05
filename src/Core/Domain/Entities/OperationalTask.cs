using System;

namespace Core.Domain
{
    public class OperationalTask
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int EstimateInWholeHours { get; private set; }
        public string AdditionalContext { get; private set; }
        public OperationalTask(string title)
        {
            Id = Guid.NewGuid();
            SetTitle(title);
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