using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class respuesta
    {
        private int code;
        private string message;

        public respuesta()
        {
            this.code=Code;
            this.Message = Message;
        }

        public int Code { get => code; set => code = value; }
        public string Message { get => message; set => message = value; }
    }
}
