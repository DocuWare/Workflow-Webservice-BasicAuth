# Example Workflow webservice with basic-auth
This is an example project for using a Workflow Manager Web Service Activity with a webservice with Basic Authentication.\
The use of Basic Authentication is a new feature included in DocuWare 7.1 for the first time.
## Check username and password
At BasicAuthHttpModule.cs -> CheckPassword you'll find the current valification for username and password.\
Edit this part for your individual needs, e.g. checking with database, ActiveDirectory or LDAP.