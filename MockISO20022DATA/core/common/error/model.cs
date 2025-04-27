
namespace datapltf.core.common.error;

public abstract class ModelError : Exception
{
    public ModelError(string message) : base(message) { }
}

public class ModelValidationError : ModelError
{
    public ModelValidationError(string message) : base(message) { }
}


