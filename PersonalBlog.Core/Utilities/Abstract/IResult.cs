using PersonalBlog.Core.Utilities.ComplexTypes;

namespace PersonalBlog.Core.Utilities.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Info { get; }
        public Exception Exception { get; }
    }
}
