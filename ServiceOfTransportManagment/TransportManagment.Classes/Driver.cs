﻿namespace TransManagment.Domain;
public class Driver
{
    /// <summary>
    /// Unique key of driver
    /// </summary>
    public int DriverId { get; set; } = 0;
    /// <summary>
    /// First name of driver
    /// </summary>
    public string FirstName { get; set; } = string.Empty;
    /// <summary>
    /// Last name of driver
    /// </summary>
    public string LastName { get; set; } = string.Empty;
    /// <summary>
    /// Patronymic of driver
    /// </summary>
    public string Patronymic { get; set; } = string.Empty;
    /// <summary>
    /// Number of passport driver
    /// </summary>
    public int Passport { get; set; } = 0;
    /// <summary>
    /// Number of driver's card
    /// </summary>
    public int DriverCard { get; set; } = 0;
    /// <summary>
    /// number - telephon number of driver
    /// </summary>
    public int Number { get; set; } = 0;
    public Driver() { }
    public Driver(int driverId, string firstName, string lastName, string patronymic, int passport, int driverCard, int number)
    {
        DriverId = driverId;
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Passport = passport;
        DriverCard = driverCard;
        Number = number;
    }
}