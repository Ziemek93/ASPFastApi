﻿namespace ASPFastApi.Models.Entities
{
    public sealed class ResponseTuple<T, ResponseEnum>
    {
        private T _resObject { get; set; }
        private ResponseEnum _resCode { get; set; }
        public string _message { get; set; } = "";

        public T resultResponse => _resObject;

        private ResponseObject<T> _response = null;
        public ResponseObject<T> ResponsResult
        {
            get
            {
                return _response;
            }
            set
            {
                if (_response != null)
                {
                    _response = value;
                }
            }
        }

        public ResponseEnum responseCode => _resCode;
        //public ResponseObject<T> ResponsResult { get; set; }

        public ResponseTuple() { }
        public ResponseTuple(T resObject)
        {
            //ResponsResult = new ResponseObject<T>(resObject);
            _resObject = resObject;
        }
        public ResponseTuple(T resObject, ResponseEnum responseCode)
        {
            _resCode = responseCode;
            _resObject = resObject;

        }

        public ResponseTuple<T, ResponseEnum> Make(T resObject, ResponseEnum responseCode)
        {
            _resCode = responseCode;
            _resObject = resObject;
            SetResponse();
            return this;
        }
        public ResponseTuple<T, ResponseEnum> Make(T resObject, ResponseEnum responseCode, string message)
        {
            _resObject = resObject;
            _resCode = responseCode;
            _message = message;
            SetResponse();
            return this;
        }

        public ResponseObject<T> SetResponse()
        {
            this.ResponsResult = new ResponseObject<T>(_resObject, _message);
            return this.ResponsResult;
        }
        //public ResponseObject<O> SetResponse<O>(Func<T, O> resObjectMapper)
        //{

        //    var responseDto = resObjectMapper(resultResponse);
        //    if (responseDto != null)
        //    {
        //        return new ResponseObject<O>(responseDto, _message);

        //    }
        //    return null;
        //}


        public override string ToString()
        {
            return _message;
        }
    }
}
