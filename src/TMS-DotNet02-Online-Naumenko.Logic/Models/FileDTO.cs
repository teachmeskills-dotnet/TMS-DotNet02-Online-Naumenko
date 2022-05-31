﻿namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class FileDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Path { get; set; }

        public int FileExtensionId { get; set; }

        public FileExtensionDto FileExtension { get; set; }

        public int UserId { get; set; }

        public UserDto User { get; set; }

        public IEnumerable<FileTermDto> FileTerms { get; set; }

        public IEnumerable<PostDto> Posts { get; set; }
    }
}
