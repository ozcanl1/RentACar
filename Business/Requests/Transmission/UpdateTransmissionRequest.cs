﻿namespace Business.Requests.Transmission;

public class UpdateTransmissionRequest
{
    public string Name { get; set; }
    public UpdateTransmissionRequest(string name)
    {
        Name = name;
    }
}