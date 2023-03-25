namespace ONGLIVES.API.VO.Interfaces
{
    public interface IParser <O, D>
    {
        D  Parse (O orign);
        List<D> Parse (List<O> origin);
    }
}