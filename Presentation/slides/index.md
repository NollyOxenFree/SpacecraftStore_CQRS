- title : CQRS
- description : A quick explanation of the CQRS Patter
- author : Nolly Oxen Free
- theme : beige
- transition : default

***

### What is CQRS

Command and Query Responsibility Segregation
'  CQRS is the command and query responsibiltiy segregation pattern
' This means breaking out and seperating the logic of what does reading data
' from the logic that does all the other logic like Creating, Updating Deleting


***


### CUD
![Cud Cow](images/cow.jpg)

***

### Reading Data vs Creating Data

**Reading data might have more fields**

**Like a User**

' The reason to break these are to have you your models be soley concerned for their operations
' and only contain fields or data pertaining to their responsibility.
' the models you use to read data might contain more information
' than you need to create that data.
' For instance a "User" might have an ID associated with it. But you wouldn't have that ID 
' at the time you would create it. So your "CreateUser" model wouldn't have that ID field.
' But maybe your "ReadUser" model would. This can be applied to other fields like
' "CreationDate" or maybe you need a model to read inventory. And than can evolve on it's own
' and that model wouldn't need to be concerned about how the inventory is updated. 

***

### Commands and Queries

---

### Commands
**"Tasked-based"**
' Commands are responsible for executing the CUD operations.
' Commands should be "Tasked-based" or provide a means to
' execute a full call chain / orchestrate one request.
' For example "AddUser" might have multiple steps- like 'Add User to DB'
' and 'Generate profile' but those should all be part of the "AddUser" command.

--- 

### Queries
**Retrieves Data**

' Queries are responsible for retrieving data for your program.
' This data should be transformed or represented as DTOs
' (Future Video)

***

### Handlers
- Commands and Queries are typically executed via Handlers.
' I've usually seen these as domain-centric orchestraters.
' You would typically see a "UserHandler" that has multiple "Handle"
' methods to invoke based on your query or command you are executing.

***

### Benefits
* Evolve Separately 
* Maximize performance, scalability, security
* Queries cannot modify data. Just returns DTOs
* Commands can be queued and asynchronous
* Data stores can be separated and configured accordingly.

' The benefits of breaking out your models and operations this way to
' have them evolve separately. But also allows to manage performace, security
' seperately. Which can help with Scalability.
' Meaning that when you have queries, you know that they only are responsible for reading,
' and they will never have the permissions to write data.
' And then you can build your application to manage writing data how you need with out impacting
' the reading operations. By executing queries as queue messages and submitting that
' asynchronously.
' And the data stores between these operations can also be managed seperately.
' For instance, you can have a "view" of your db that your read models connect with and can be optimized for reading data.

---

### Downsides
* Not "DRY"
* Complex implementation

' The downsides to this are that this is not really a "DRY" implementation.
' If your User model changes and now has more fields, like a Birthday or something,
' then you have multiple classes, and methods to update- increasing that maintainability.
' And while this pattern is conceptually easy to understand, it can be complex to implement
' because this is typically implemented along side other patterns such as Event Sourcing or 
' mediator patterns.

***

### Resources:

' Microsoft has a lot more you can dive in with CQRS Pattern for a more in-depth explanation of the pattern and why to use it.
' Martin Fowler has great blog post about this as well.

***

### Demo!

' Let's jump into some code!