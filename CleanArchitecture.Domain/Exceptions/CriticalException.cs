﻿namespace CleanArchitecture.Domain.Exceptions;
public class CriticalException(string message) : Exception(message);