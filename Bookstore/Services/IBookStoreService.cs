using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Services
{
    public interface IBookStoreService
    {
        List<Book> GetBooks();
        List<Book> GetBooksByString(String searchParam);
        Book GetBookByTitle(String argBookTitle);
        Book GetBookByISBN(String argISBN);
        List<BookVolume> GetVolumesByBook(String argBookISBN);
        List<Lending> GetLendingsForVolume(int argLibraryId);
        BookVolume GetVolumeById(int argId);
        bool CreateLending(LendingViewModel model, string userID);
        bool DoesOverLap(DateTime start, DateTime end, int volumeId);
        int GetLendingsNumberForBook(string argBookISBN);
    }
}
