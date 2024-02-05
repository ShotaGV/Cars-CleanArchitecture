using System.Runtime.Serialization;

namespace Cars.Application.Features.ModelFeatures.GetByIdModel
{
    [Serializable]
    internal class ModelNotFoundException : Exception
    {
        private Guid id;

        public ModelNotFoundException()
        {
        }

        public ModelNotFoundException(Guid id)
        {
            this.id = id;
        }

        public ModelNotFoundException(string? message) : base(message)
        {
        }

        public ModelNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ModelNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}