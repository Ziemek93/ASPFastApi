namespace ASPFastApi.Models
{
    public class ResponseObject<O>
    {
        public O? responeObject { get; init; }
        public string responseMessage { get; init; }
        public ResponseObject(O? resObject, string resMessage = "")
        {
            responeObject = resObject;
            responseMessage = resMessage;
        }
    }
}
