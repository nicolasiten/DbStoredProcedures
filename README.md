
# DbStoredProcedures

# Stored Procedures
Find more information about the Stored Procedures in the following documentation: [stored_procedures_refernce_documentation](https://github.com/nicolasiten/DbStoredProcedures/blob/master/stored_procedures_refernce_documentation.pdf)
To call the Stored Procedures in a nice and clean way there's an Extension Class in the project: [StoredProcedureExtensions.cs](https://github.com/nicolasiten/DbStoredProcedures/blob/master/DbStoredProcedures/Data/Extensions/EfCoreStoredProcedureExtension.cs)
By including this class Stored Procedures can be called as follows:

                var issues = await IssueTrackerContext.LoadStoredProc("StoredProcName")
	                .WithSqlParam("Param1", param1)
	                .WithSqlParam("Param2", param2)
	                .WithSqlParam("Param3", param3)
	                .ExecuteStoredProcAsync<ObjectToCastTo>();
# Console Application
Project which sets up a Database and adds Stored Procedures to it to retrieve data.
It's also able to generate new issues. To generate Problem text that is random and makes sense, a Natural Language Generation Library from the University Of Aberdeen is used (SimpleNLG).
# Test Project
There are 2 Test Cases for each Stored Procedure to test them and demonstrate how to use them.