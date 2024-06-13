# Contact Manager Project

## Overview

This project is a console application for managing contacts, allowing users to view, search, add, and delete contacts. The application also includes unit tests to ensure the functionality of each feature.

## Features

- **View Contacts**: View all contacts or filter by categories such as family, friends, or work.
- **Search Contacts**: Search for a contact by name.
- **Add Contact**: Add a new contact to the list and optionally categorize it.
- **Remove Contact**: Remove an existing contact from the list.

## Unit Tests

The project uses Xunit for unit testing. The tests cover the following functionalities:

- Viewing all contacts
- Searching for a contact by name
- Adding a new contact
- Removing an existing contact

## Getting Started

### Prerequisites

- .NET Core SDK
- Xunit

### Running the Application

1. Clone the repository:
    ```bash
    git clone https://github.com/Nory9/Contacts-Manager.git
    ```

2. Navigate to the project directory:
    ```bash
    cd contentmanager
    ```

3. Run the application:
    ```bash
    dotnet run
    ```

### Running Unit Tests

1. Navigate to the test project directory:
    ```bash
    cd contentmanager/tests
    ```

2. Run the tests:
    ```bash
    dotnet test
    ```

## Project Structure

- **contentmanagerproject**: Contains the main application logic.
- **contentmanager**: Contains the unit tests for the application.

## Code Overview

### Main Application

#### Program.cs

The `Program` class contains the main logic for the contact manager application. It defines methods for viewing, searching, adding, and removing contacts.

- **ContactsManager**: Main menu for interacting with the contact manager.
- **GetContacts**: View contacts based on category.
- **GetContact**: Search for a contact by name.
- **AddContact**: Add a new contact.
- **RemoveContact**: Remove an existing contact.


#### Unit Tests
` UnitTest1.cs`
The ``UnitTest1`` class contains unit tests to verify the functionality of the contact manager.

- **GetContactsCase**: Tests viewing all contacts.
- **GetContactCase**: Tests searching for a contact by name.
- **AddContactCase**: Tests adding a new contact.
- **RemoveContactCase**: Tests removing an existing contact.