using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like <strong> Aldus PageMaker </strong> including versions of Lorem Ipsum.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colours"},
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"},
                },
                Favourite = true
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like <strong> Aldus PageMaker </strong> including versions of Lorem Ipsum.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Script"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Pencils"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Inks"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Colours"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Letters"},
                },
                Favourite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like <strong> Aldus PageMaker </strong> including versions of Lorem Ipsum.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Script"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Pencils"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Inks"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Colours"},
                    new Artist() { Name = "Graham Chukwumaobi", Role = "Letters"},
                },
                Favourite = false
            },

    };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }

            return comicBookToReturn;
        }
    }
}