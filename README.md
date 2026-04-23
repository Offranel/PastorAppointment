# PastorAppointment

Simple Windows Forms App (.NET 10) for creating and submitting pastor appointment records.

## Description

This is a minimal Windows Forms application that captures basic information for pastor appointments and allows the user to submit a record.

## Features

- Enter pastor name
- Enter location
- Enter reason for appointment
- Enter additional information
- Choose date of appointment
- Submit appointment button

## Fields

- Name of pastor
- Location
- Reason for appointment
- Additional information
- Date of appointment
- Submit appointment

## Screenshot

Place a screenshot of the form at `docs/docs/pastorProgramForm.png` and include it in the README like this:

![Create pastor appointment](docs/Pasto22.PNG)

Adjust the path if your screenshot is stored elsewhere.


## Prerequisites to run your app on their machine

Before running or building this Windows Forms app, ensure the following are installed on the machine:

- Windows 10 or later (required for Windows Forms desktop apps).
- .NET 10 Desktop Runtime (required to run the published app) or .NET 10 SDK (required to build from source).
- If you want to open and edit the project: Visual Studio 2022/2026 (or later) with the ".NET desktop development" workload installed.
- Optional: Git to clone the repository and a compatible package restore tool (NuGet) — Visual Studio handles this automatically.

After installing the prerequisites: clone the repo, restore NuGet packages, open the solution in Visual Studio (or use dotnet build / dotnet run), and run the app.

## Usage


1. Fill in the form fields (Name, Location, Reason, Additional information, Date).
2. Click "Submit appointment" to save/submit the record.


