# OrchardApiTest

The purpose of this project is to learn how the orchard cms works under the hood.  By setting up an orchard service from scratch and seeing how it interacts with both local files and the target database, you can learn how to manage multiple tenants.

This project assumes you already have an sql server up with an empty database named "FakeOrchardDb".

Running the app setup for the first time requires different code compared to an existing api.

<h1>First Time Setup</h1>
<ol>
  
  <li>
    Open a new terminal
  </li>
  
  <li>
    Navigate to the project directory where Program_Initial.cs file is located.  The code for Program.Initial.cs should be uncommented, while the code for Program_Existing.cs should be commented.  
    <ul>
      <li>
        <b>The hotkey to comment out a selection is ctrl+k+c.  The hotkey to uncomment a selection is ctrl+k+u.</b>
      </li>
    </ul>
  </li>
  
  <li>
    Run the following commands in order: 
    <ol>
      <li>
        dotnet clean
      </li>
      <li>
        dotnet build
      </li>
      <li>
        dotnet run
      </li>
      </ol>
  </li>
  
  <li>
    Go through the Orchard service setup.  Below is an example of the setup page.  Once you submit the form, it will create the necessary tables for your database.  It will also write autogenerate code for the following files: tenants.json, ContentDefinitions.json.
  </li>
</ol>

<img src="Guide Files\Initial Startup Page.png">

<h1>Launching an existing orchard service</h1>
<ol>
  
  <li>
    If you still have the orchard api running in terminal, close the app.
  </li>
  
  <li>
    Comment out the code for Program_Initial.cs, then  uncomment the code for Program_Existing.cs.
  </li>
  
  <li>
    Run the following commands in order: 
    <ol>
      <li>
        dotnet clean
      </li>
      <li>
        dotnet build
      </li>
      <li>
        dotnet run
      </li>
      </ol>
  </li>
  
  <li>
    Log in using the credentials you set in the setup phase.
  </li>
</ol>
