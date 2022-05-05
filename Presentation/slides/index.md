- title : FsReveal
- description : Introduction to FsReveal
- author : Karlkim Suwanmongkol
- theme : beige
- transition : default

***

### What is CQRS

Command and Query Responsibility Segregation
'  So this is breaking out the concerns of Reading Data 
' and Writing Data (Writing being Creating, Updating 
' and Deleting - the CUD of CRUD)

***


### CUD
![Cud Cow](images/cow.jpg)

***

### Reading Data vs Creating Data

**Reading data might have more fields**

**Like a User**

' Often times, the model you have for READING data will 
' have more fields, properties, information than a model
' that would be used for CREATING that data.
' Such as a User. A user might have a User ID that you 
' generate for them. But when I ADD a user, it wouldn’t make 
' sense to have a field for that, until I am READING that user.

***

### Commands and Queries

---

### Commands
**"Tasked-based"**
' Commands should be “Tasked-based” or provide a means to
' execute a full call chain / orchestrate one request,
' rather than being “Data-centric” like, updating a field.
' “Add User” might have multiple operations to execute, 
' but you should have one command for it. 

--- 

### Queries
**Retrieves Data**

***

### Benefits
* Evelve Separately to maximize performance, scalability, security
* Commands can be queued and asynchronous
* Queries cannot modify data. Just returns DTOs
* Data stores can be separated and configured accordingly.

---

### Downsides
* Not "DRY"
* Complex implementation

***
