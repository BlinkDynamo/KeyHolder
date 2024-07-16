
# ![alt text](images/KeyHolderIcon.png "KeyHolder Logo")
## KeyHolder - Password Manager

KeyHolder is very bare-bones password and account management software built in visual C# using 
Dapper and SQLite. It came from my desire to create a project that was both achievable and useful.

## Features
KeyHolder in it's current state is extremely simple. There are only two main actions: Adding and 
Removing "Entries", which consist of an ID, a Username, and a Password. The reasoning behind having 
an ID as well as a Username is that some account structures require an email address as well as a 
username, and this allows for that. 

## Master Password
KeyHolder uses a master password to encrypt and decrypt the database. There is no feature that allows
for multiple databases on the same machine. You either have an account and are asked to login to it,
or you don't and are asked to set a password to create one. This means that if you forget your password,
you will lose all of your data.


## Build and Install
There are two ways to build and install KeyHolder. The first is to clone the repository and build it using
Visual Studio. The second is to download the installer from the releases page and run it.

### Building from Source

1. Clone the repository
    ```Git Bash
    
    git clone https://github.com/BlinkDynamo/KeyHolder.git
    
    ```

2. Open the project in Visual Studio and build it with the following steps:
    - Open Visual Studio
    - Click on "Open a project or solution"
    - Navigate to the cloned repository and open the .sln file
    - Click on "Build" in the top menu
    - Click on "Build Solution"

### Installing from Release

1. Download the installer from the releases page
2. Run the installer and follow the instructions

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change. Keep in mind the scope of the project
is to be extremely simple. 


## License

[MIT](https://choosealicense.com/licenses/mit/)