﻿using ConstructionUniversity.Infrastructure.Common;

namespace ConstructionUniversity.Infrastructure.Teachers;

internal record TeacherDb : IGuidProperty
{
    public Guid Id { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string MiddleName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
}