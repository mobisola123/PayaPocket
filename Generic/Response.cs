﻿namespace PayAPocket.Generic
{
    public class Response<T>
    {
        public T Data { get; set; }
        public ResponseError Error { get; set; }
        public bool IsSuccessful { get; set; }
        public string Description { get; set; }
        public string ResponseCode { get; set; }
    }
}
