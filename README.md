# Example Workflow webservice with basic-auth
This is an example project for using a "Workflow Manager Web Service Activity" with a webservice with basic authentication.  
The use of basic authentication is a new feature included in __DocuWare 7.1__ for the first time.

Current sample is based on the existing sample described [here]("https://developer.docuware.com/Extension_Services/extension_services.html#workflow-manager-web-service-activity").
## Todo before start
In [BasicAuthHttpModule.cs](https://github.com/DocuWare/Workflow-Webservice-BasicAuth/blob/master/SampleWebServiceWithBasicAuth/BasicAuthHttpModule.cs) on method "_CheckPassword_" you'll find the current validation for username and password.\
__Edit this part__ for your individual needs, e.g. checking with database, ActiveDirectory or LDAP.