using System;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    private ExamDbContext _dbContext;
    private GenreRepository _repository;
    
    [SetUp]
    public void Setup()
    {
        var builder = new DbContextOptionsBuilder();
        builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

        _dbContext = new ExamDbContext(builder.Options);
        _repository = new GenreRepository(_dbContext);
    }

    [Test]
    public void CreateGenre_ShouldReturnOk()
    {
        _repository.Create(new Genre {Name = "Example"});
        var genre = _repository.Read(1);
        
        Assert.IsNotNull(genre);
    }
    
    [Test]
    public void ReadGenre_ShouldReturnOk()
    {
        _repository.Create(new Genre {Name = "Example"});
        var genre = _repository.Read(1);

        Assert.IsNotNull(genre);
    }
    
    [Test]
    public void ReadAllGenres_ShouldReturnOk()
    {
        _repository.Create(new Genre {Name = "Example"});
        var genres = _repository.ReadAll();
        
        Assert.IsNotNull(genres);
    }
    
    [Test]
    public void UpdateGenre_ShouldReturnOk()
    {
        _repository.Create(new Genre {Name = "Example"});
        
        var genre = _repository.Read(1);
        genre.Name = "Example1";
        _repository.Update(genre);

        genre = _repository.Read(1);

        Assert.AreEqual(genre.Name, "Example1");
    }
    
    [Test]
    public void DeleteGenre_ShouldReturnOk()
    {
        _repository.Create(new Genre {Name = "Example"});
        var genre = _repository.Read(1);
        
        _repository.Delete(genre.Key);
        
        genre = _repository.Read(1);
        
        Assert.IsNull(genre);
    }
}