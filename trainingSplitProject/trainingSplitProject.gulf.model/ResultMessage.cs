namespace trainingSplitProject.gulf.model
{
    public class ResultMessage
    {
        public ResultStatusClass result { get; set; }
        public object data { get; set; }
        private ResultMessage() { }

        public static ResultMessage Create(object data, int resultCode, string resultMessage)
        {
            var result = new ResultMessage();
            result.data = data;
            result.result = new ResultStatusClass() { code = resultCode, message = resultMessage };

            return result;
        }

        public static ResultMessage Create(int resultCode, string resultMessage)
        {
            var result = new ResultMessage();
            result.result = new ResultStatusClass() { code = resultCode, message = resultMessage };

            return result;
        }

        public static ResultMessage BadRequest(string resultMessage = "Request message incorrect")
        {
            var result = new ResultMessage();
            result.result = new ResultStatusClass() { code = 400, message = resultMessage };

            return result;
        }

        public class ResultStatusClass
        {
            public int code { get; set; }
            public string message { get; set; }
        }

    }
}