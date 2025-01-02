﻿using NbpApp.Utils.Utils;

namespace NbpApp.Tests.Mocks;

public class TimeProviderMock : ITimeProvider
{
    public DateTime CurrentTime { get; set; } = new(2025, 1, 1);
    public DateOnly CurrentDate { get; set; } = DateOnly.FromDateTime(new(2025, 1, 1));
}