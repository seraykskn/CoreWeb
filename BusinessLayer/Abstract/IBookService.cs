using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface IBookService  /*Bir öğrenci sertifilka alacak sertifikaya uygun mu Veri iletişim katmanıyla iletişim kurar*/
    {

        List<Book> GetAll();

        Book GetById(int id);

        List<Book> GetAuthorId(int id);

        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);

    }
}
