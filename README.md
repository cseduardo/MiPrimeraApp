# MiPrimeraApp
Questions and Answers

Question 1: What’s difference between Portable (CPL) and Shared (SAP) projects?
SAP creates one file for each project, while PCL creates a dll for compilation of all projects

Question 2: What are the requirements to configure Xamarin Mac Agent?
-Have a Mac computer
-In the configuration of the Mac give the permission of Remote Login
-Have Xcode installed and open it to accepted its terms and conditions
-Install Visual Studio for Mac

Question 3: How many projects you have and why you need all?
There are 4 projects, one is called portable and it is needed because it is the one that will share the code with the other projects that refer to each platform, Android, iOS and UWP, in each one of them have code tha they will only use them  either for their native code, or to give them certain permissions

