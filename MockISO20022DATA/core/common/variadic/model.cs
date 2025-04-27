namespace datapltf.core.common.variadic;
public interface IModel { }

public delegate void VariadicOption(IModel I);

public abstract class AModel : IModel
{

    protected void Validate(VariadicOption[] options)
    {
        foreach (var option in options)
        {
            option(this);
        }
    }
}

