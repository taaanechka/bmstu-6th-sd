using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreMock;

using Xunit;
using Xunit.Abstractions;
using Moq;

using DB;
using BL;

namespace TestsDB;

public class UnitTestDepartures: IDisposable
{
    public DbContextOptions<ApplicationContext> DummyOptions { get; } = new DbContextOptionsBuilder<ApplicationContext>().Options;

    private DbContextMock<ApplicationContext> dbContextMock;
    private DbSetMock<DB.Departure> DeparturesDbSetMock;
    private DB.DeparturesRepository Rep;

    public UnitTestDepartures()
    {
        DateTime Date1 = DateTime.ParseExact("2022-04-10", "yyyy-MM-dd",
                                        System.Globalization.CultureInfo.InvariantCulture);

        DateTime Date2 = DateTime.ParseExact("2022-04-11", "yyyy-MM-dd",
                                        System.Globalization.CultureInfo.InvariantCulture);

        var initialEntities = new[]
        {
            new DB.Departure {Id = 1, UserId = 1, DepartureDate = Date1},
            new DB.Departure {Id = 2, UserId = 1, DepartureDate = Date1},
            new DB.Departure {Id = 3, UserId = 2, DepartureDate = Date2}
        };

        // Arrange
        dbContextMock = new DbContextMock<ApplicationContext>(DummyOptions);
        DeparturesDbSetMock = dbContextMock.CreateDbSetMock(x => x.Departures, initialEntities);

        Rep = new DB.DeparturesRepository(dbContextMock.Object);
    }

    public void Dispose() {}

    [Fact]
    public void TestGetDepartures()
    {
        // Act
        List<BL.Departure> Departures = Rep.GetDepartures();

        // Assert
        Assert.Equal(3, dbContextMock.Object.Departures.Count());
        Assert.Equal(3, Departures.Count);
    }

    [Fact]
    public void TestGetDepartureByIdCorrect()
    {
        // Act
        BL.Departure Departure = Rep.GetDepartureById(1);

        // Assert
        Assert.NotNull(Departure);
    }

    [Fact]
    public void TestGetDepartureByIdUncorrect()
    {
        // Assert
        Assert.Throws<DB.DepartureNotFoundException>(()=> Rep.GetDepartureById(5));
    }

    [Fact]
    public void TestAddDepartureCorrect()
    {   
        DateTime Date2 = DateTime.ParseExact("2022-04-11", "yyyy-MM-dd",
                                        System.Globalization.CultureInfo.InvariantCulture);    
        var Departure = new BL.Departure(4, 3, Date2);

        // Assert: initial
        Assert.Equal(3, dbContextMock.Object.Departures.Count());

        // Act
        Rep.AddDeparture(Departure);

        // Assert: final
        DeparturesDbSetMock.Verify(m => m.Add(It.IsAny<DB.Departure>()), Times.Once());
        dbContextMock.Verify(m => m.SaveChanges(), Times.Once());

        Assert.Equal(4, dbContextMock.Object.Departures.Count());
    }

    [Fact]
    public void TestAddDepartureUncorrect()
    {
        DateTime Date2 = DateTime.ParseExact("2022-04-11", "yyyy-MM-dd",
                                        System.Globalization.CultureInfo.InvariantCulture);
        var Departure = new BL.Departure(4, -3, Date2);

        // Assert
        Assert.Throws<DB.DeparturesValidatorFailException>(()=> Rep.AddDeparture(Departure));
    }

    [Fact]
    public void TestDeleteDepartureCorrect()
    {
        // Act
        Rep.DeleteDeparture(3);

        DeparturesDbSetMock.Verify(m => m.Remove(It.IsAny<DB.Departure>()), Times.Once());
        dbContextMock.Verify(m => m.SaveChanges(), Times.Once());

        // Assert
        Assert.Equal(2, dbContextMock.Object.Departures.Count());
    }

    [Fact]
    public void TestDeleteDepartureUncorrect()
    {
        // Assert
        Assert.Throws<DB.DepartureNotFoundException>(()=> Rep.DeleteDeparture(5));
    }
}