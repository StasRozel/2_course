using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    class CustomException : Exception
    {

        public CustomException() 
        {
            
        }
    }

    class CreateDateException : CustomException
    {
        public new string Message;

        public CreateDateException()
        {
            Message = "Дата введена не корректно";
        }

        public CreateDateException(string message) {
            Message = message;
        }
        
    }

    class AddedProductException : CustomException
    {
        public new string Message;

        public AddedProductException()
        {
            Message = "Введенно не коррретное число";
        }
        public AddedProductException(string message) 
        {
            Message = message;
        }
    }

    class AddedInfoExcepiton : CustomException
    {
        public new string Message;

        public AddedInfoExcepiton()
        {
            Message = "Введенно не коррретное число";
        }
        public AddedInfoExcepiton(string message)
        {
            Message = message;
        }
    }
    class AddedCheckExcepiton : CustomException
    {
        public new string Message;

        public AddedCheckExcepiton()
        {
            Message = "Введенно не коррретное число";
        }
        public AddedCheckExcepiton(string message)
        {
            Message = message;
        }
    }

}
