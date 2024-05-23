namespace ASPFastApi.Models.Entities
{
    public class ResponseTuple<T, ResponseEnum>
    {
        private T _resObject { get; set; }
        private ResponseEnum _resInfo { get; set; }
        public string _message { get; set; } = "";

        public T  resObj => _resObject;
        public ResponseEnum resInfo => _resInfo;

        public ResponseTuple() { }
        public ResponseTuple(T resObject, ResponseEnum resInfo)
        {
            _resObject = resObject;
            _resInfo = resInfo;
        }

        public ResponseTuple<T, ResponseEnum> Make(T resObject, ResponseEnum resInfo)
        {
            _resObject = resObject;
            _resInfo = resInfo;

            return this;
        }
        public ResponseTuple<T, ResponseEnum> Make(T resObject, ResponseEnum resInfo, string message)
        {
            _resObject = resObject;
            _resInfo = resInfo;
            _message = message;

            return this;
        }

        public override string ToString()
        {
            return _message;
        }
    }
}
