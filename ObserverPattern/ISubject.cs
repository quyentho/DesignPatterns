﻿// See https://aka.ms/new-console-template for more information


public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void UnRegisterObserver(IObserver IObserver);
}