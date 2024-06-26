﻿namespace Infrastructure.Entities;

public class UserEntity
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string HashedPassword { get; set; } = null!;
    public string Salt { get; set; } = null!;
    public string SecurityKey { get; set; } = null!;
}
