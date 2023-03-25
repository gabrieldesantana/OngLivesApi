using ONGLIVES.API.Entidades;
using ONGLIVES.API.VO.Interfaces;

namespace ONGLIVES.API.VO.Converter 
{
    public class VoluntaryConverter : IParser<VoluntarioVO, Voluntario>, IParser<Voluntario, VoluntarioVO>
    {
        public Voluntario Parse(VoluntarioVO orign)
        {
            return new Voluntario 
            {
                Nome = orign.Nome,
                Sobrenome = orign.Sobrenome,
                CPF = orign.CPF,
                Email = orign.Email,
                DataAniversario = orign.DataAniversario,
                Escolaridade = orign.Escolaridade,
                Genero = orign.Genero,
                Endereco = orign.Endereco,
            };
        }

        public VoluntarioVO Parse(Voluntario orign)
        {
            return new VoluntarioVO
            {
                Nome = orign.Nome,
                Sobrenome = orign.Sobrenome,
                CPF = orign.CPF,
                Email = orign.Email,
                DataAniversario = orign.DataAniversario,
                Escolaridade = orign.Escolaridade,
                Genero = orign.Genero,
                Endereco = orign.Endereco,
            };
        }


        public List<VoluntarioVO> Parse(List<Voluntario> origin)
        {
            return origin.Select(x => Parse(x)).ToList();
        }
        public List<Voluntario> Parse(List<VoluntarioVO> origin)
        {
            return origin.Select(x => Parse(x)).ToList();
        }

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