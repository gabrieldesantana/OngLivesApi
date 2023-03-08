namespace ONGLIVES.API.VO.Converter 
{
    public class VoluntaryConverter 
    {

    }
}

// namespace RestWithASPNETUdemy.Data.Converter.Implementations
// {
//     public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
//     {
//         public Book Parse(BookVO origin)
//         {
//             if (origin == null) return null;
//             return new Book
//             {
//                 Id = origin.Id,
//                 Author = origin.Author,
//                 LaunchDate = origin.LaunchDate,
//                 Price = origin.Price,
//                 Title = origin.Title
//             };
//         }

//         public BookVO Parse(Book origin)
//         {
//             if (origin == null) return null;
//             return new BookVO
//             {
//                 Id = origin.Id,
//                 Author = origin.Author,
//                 LaunchDate = origin.LaunchDate,
//                 Price = origin.Price,
//                 Title = origin.Title
//             };
//         }

//         public List<Book> Parse(List<BookVO> origin)
//         {
//             return origin.Select(item => Parse(item)).ToList();
//         }

//         public List<BookVO> Parse(List<Book> origin)
//         {
//             return origin.Select(item => Parse(item)).ToList();
//         }
//     }
// }