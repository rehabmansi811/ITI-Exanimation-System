---------------------------------------------------------------
---------------------------------------------------------------
--FIRSTLY STORED PROCEDURES FOR PERSON
---------------------------------------------------------------
---------------------------------------------------------------
---------------------------------------------------------------

CREATE PROCEDURE DeleteLoginAndUser
    @EmailToDelete NVARCHAR(255)
AS
BEGIN
    DECLARE @SqlStatement NVARCHAR(MAX);

    -- Check if the login exists
    IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = @EmailToDelete)
    BEGIN
        -- Check if the user exists
        IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = @EmailToDelete)
        BEGIN
            -- Delete the user
            SET @SqlStatement = 'DROP USER ' + QUOTENAME(@EmailToDelete) + ';';
            EXEC sp_executesql @SqlStatement;
        END
        -- Delete the login
        SET @SqlStatement = 'DROP LOGIN ' + QUOTENAME(@EmailToDelete) + ';';
        EXEC sp_executesql @SqlStatement;
    END
END;

------------------------------------------ INSERT PERSON------------------------------------------------------

-----THIS PROCEDURE WILL YOU CAN USE IT ONLY WHEN YOUR ROLE IS ADMIN AND HAVE ALL PERMESSION TO INSERT AND GIVE ANOTHR USER GARANTI YOU MUST TO CONNECT WITH OUR
-----OUR DATABASE USING ONE OF ADMIN ACCOUNT (USER CONNECTION)  THERE IS ACCOUNTS :
--devmuatef@admin.com      PASSWORD IS :Admin@123
--Rehab_mansi@admin.com    PASSWORD IS :Admin@123
--Ebtihal_Ali@admin.com    PASSWORD IS :Admin@123       --THIS IS ADMINS ACCOUNT PLEASE ONE OF THEM TO MAKE IT EASE FOR U !.
--Yamine_Saffan@admin.com  PASSWORD IS :Admin@123
--Omar_Tarek@admin.com     PASSWORD IS :Admin@123



CREATE OR ALTER PROCEDURE sp_add_user
    @name NVARCHAR(MAX),
    @mail NVARCHAR(MAX),
    @nationalID NVARCHAR(MAX),
    @address NVARCHAR(MAX),
    @gender CHAR(1),
    @salary DECIMAL(18, 2),
    @date_of_birth DATE,
    @phone NVARCHAR(MAX),
    @role NVARCHAR(30),
    @password NVARCHAR(255),
    @deptID INT = NULL,
    @intakeID INT = NULL,
    @college NVARCHAR(255) = NULL,
    @hireDate DATE = NULL
WITH ENCRYPTION
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        IF EXISTS (SELECT 1 FROM Department WHERE ID = @deptID) OR @deptID IS NULL
        BEGIN
            INSERT INTO [dbo].[Person] 
                ([Name], [Email], [NID], [Address], [Gender], [Salary], [DOB], [Phone], [Role], [Password], [DeptID])
            VALUES
                (@name, @mail, @nationalID, @address, @gender, @salary, @date_of_birth, @phone, @role, @password, @deptID);
            
            PRINT 'Person inserted';

            DECLARE @lastpersonID INT;
            SELECT @lastpersonID = p.ID FROM Person p WHERE p.Email = @mail;
            DECLARE @DefaultDatabase NVARCHAR(255) = 'YEARO_EXAM_SYSTEM';
            DECLARE @SqlStatement NVARCHAR(MAX);

            -- Create Login & User
            SET @SqlStatement = 'CREATE LOGIN ' + QUOTENAME(@mail) + 
                                ' WITH PASSWORD = ''' + @password + ''', DEFAULT_DATABASE = ' + QUOTENAME(@DefaultDatabase) + ';';
            EXEC sp_executesql @SqlStatement;

            SET @SqlStatement = 'CREATE USER ' + QUOTENAME(@mail) + ' FOR LOGIN ' + QUOTENAME(@mail) + ';';
            EXEC sp_executesql @SqlStatement;

            -- Assign Role-Based Permissions
            IF (@role = 'Student')
            BEGIN
                IF EXISTS (SELECT 1 FROM Intake WHERE ID = @intakeID) OR @intakeID IS NULL
                BEGIN
                    INSERT INTO Student (StdID, IntakeID, College) VALUES (@lastpersonID, @intakeID, @college);
                    SET @SqlStatement = 'ALTER ROLE STUDENT ADD MEMBER ' + QUOTENAME(@mail) + ';';
                    EXEC sp_executesql @SqlStatement;
                    PRINT 'Person inserted as a student successfully.';
                END
                ELSE PRINT 'There is no intake with the specified intake ID.';
            END
            ELSE IF (@role = 'Instructor')
            BEGIN
                INSERT INTO Instructor (InsID, HireDate) VALUES (@lastpersonID, @hireDate);
                SET @SqlStatement = 'ALTER ROLE INSTRUCTOR ADD MEMBER ' + QUOTENAME(@mail) + ';';
                EXEC sp_executesql @SqlStatement;
                PRINT 'Person inserted as an instructor successfully.';
            END
            ELSE IF (@role = 'Admin')
            BEGIN
                -- Grant Admin Role
                SET @SqlStatement = 'ALTER ROLE ADMIN ADD MEMBER ' + QUOTENAME(@mail) + ';';
                EXEC sp_executesql @SqlStatement;

                -- Grant Full Control on Database
                SET @SqlStatement = 'GRANT CONTROL ON DATABASE::' + QUOTENAME(@DefaultDatabase) + ' TO ' + QUOTENAME(@mail) + ';';
                EXEC sp_executesql @SqlStatement;

                -- Grant Full Permissions on Schema
                SET @SqlStatement = 'GRANT CONTROL ON SCHEMA::dbo TO ' + QUOTENAME(@mail) + ';';
                EXEC sp_executesql @SqlStatement;

                -- Grant All Permissions on Tables
                SET @SqlStatement = 'GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE ON SCHEMA::dbo TO ' + QUOTENAME(@mail) + ';';
                EXEC sp_executesql @SqlStatement;

                PRINT 'Admin user created with full permissions.';
            END
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'The department ID you provided is not found.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'ERROR OCCURED ';
        ROLLBACK TRANSACTION;
    END CATCH
END;
EXEC sp_add_user
    @name = 'ahmed  hammoda' ,
    @mail = 'ahmedhamoda@example.com', 
    @nationalID = '26666678955555', 
    @address = 'Giza, Egypt', 
    @gender = 'M', 
    @salary = 15000.00, 
    @date_of_birth = '1985-07-15', 
    @phone = '01012345678', 
    @role = 'Admin', 
    @password = 'password1277',
    @DeptID = 6;

  

select * from person

-------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_all_students
WITH ENCRYPTION
AS
BEGIN
    SELECT 
        p.*, 
        s.IntakeID, 
        s.College
    FROM 
        Person p
    INNER JOIN 
        Student s 
    ON 
        p.ID = s.StdID;
END;
-------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_all_instructors
WITH ENCRYPTION
AS
BEGIN
    SELECT 
        p.*, 
        I.Hiredate
    FROM 
        Person p
    INNER JOIN 
        Instructor I
    ON 
        p.ID = I.InsID;
END;
exec  sp_get_all_instructors
--------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_student_byID
@stdID int =null
WITH ENCRYPTION
AS
BEGIN 
 IF @stdID is null
           print 'student ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM student WHERE StdID = @stdID)
 begin
    SELECT 
        p.*, 
        s.IntakeID, 
        s.College
    FROM 
        Person p
    INNER JOIN 
        Student s 
    ON 
        p.ID = s.StdID and s.StdID=@stdID;
 end 
 else 
   print 'the student does not exist in the student table '
END;
exec sp_get_student_byID null
-------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_instructor_byID
@insID int =null
WITH ENCRYPTION
AS
BEGIN 
 IF @insID is null
           print 'instructor ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Instructor WHERE InsID = @insID)
 begin
    SELECT 
        p.*, 
        I.Hiredate
    FROM 
        Person p
    INNER JOIN 
        Instructor I 
    ON 
        p.ID = I.InsID and I.InsID=@insID;
 end 
 else 
   print 'the instructor does not exist in the instructor table '
END;
exec sp_get_instructor_byID 12
---------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_all_persons
WITH ENCRYPTION
AS
BEGIN
    SELECT 
        *
    FROM 
        Person 
END;
exec sp_get_all_persons
----------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_person_role
@personID int 
WITH ENCRYPTION
AS
BEGIN
    IF @personID is null
           print 'person ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Person WHERE ID = @personID)
 begin
    SELECT 
        name,role
    FROM 
        Person where ID=@personID;
 end 
 else 
   print 'the person does not exist in the person table '
END;
exec sp_get_person_role 1 
-----------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_delete_person
@personID int = null
WITH ENCRYPTION
AS
BEGIN 

 IF @personID is null
           print 'person ID should not be null OR EMPTY'

 ELSE IF EXISTS (SELECT * FROM Person WHERE id = @personID)
 begin
     declare @email_for_id nvarchar(255)
     select @email_for_id =p.Email from person p where p.ID=@personID
    delete 
    FROM 
        Person  
    where 
        ID=@personID;
		exec DeleteLoginAndUser @email_for_id;
 end 
 else 
   print 'the person you want to delete does not exist in the person table'
END;
exec sp_delete_person 40

--------------------------------------------------UPDATE PERSON ------------------------------
CREATE OR ALTER PROCEDURE PERSON_Update 
@ID int, 
@Email nvarchar(450) 

WITH ENCRYPTION
AS
BEGIN   -- Update Process for Student Table 

	declare @IDException bit = 0;
	declare @EmailException bit = 0;

	if exists(select * from Person P where P.Email = @Email and P.ID!= @ID)
		set @EmailException = 1; -- If the Email already exists and it is not the same as student being updated then, set the exception flag to 1, indicating that the inserted Email is not unique

	if exists(select * from Person P where P.ID= @ID)
		set @IDException = 1; -- If the Student exists, set the exception flag to 1

	
	if @IDException = 0
		print 'An error has occured, The Student ID you entered does not exist in Student Table'
	else if @EmailException = 1
		print 'An error has occured, the Email you entered already exists , enter a unique Email'
	else
		BEGIN
			DECLARE @DefaultDatabase NVARCHAR(255) = 'YEARO_EXAM_SYSTEM';
			DECLARE @SqlStatement NVARCHAR(MAX);
			DECLARE @oldEmail nvarchar(450);
			SELECT @oldEmail = p.Email FROM person p WHERE p.ID = @ID;

			EXEC DeleteLoginAndUser @EmailToDelete = @oldEmail

			UPDATE Person  set  email = @Email  where ID = @ID;
			declare @per_role NVARCHAR(MAX);
			select @per_role = p.Role  from person p where p.ID=@ID
			declare @per_password NVARCHAR(MAX);
			select @per_password = p.Password  from person p where p.ID=@ID
			
			-- Construct the dynamic SQL statement
			SET @SqlStatement = 'CREATE LOGIN ' + QUOTENAME(@Email) + ' WITH PASSWORD = ''' + @per_password + ''', DEFAULT_DATABASE = ' + QUOTENAME(@DefaultDatabase) + ';';
			EXEC sp_executesql @SqlStatement;

			-- Create user and add to role
		 	SET @SqlStatement = 'CREATE USER ' + QUOTENAME(@Email) + ' FOR LOGIN ' + QUOTENAME(@Email) + ';';
			EXEC sp_executesql @SqlStatement;

			SET @SqlStatement = 'ALTER ROLE '+ QUOTENAME(@per_role)+' ADD MEMBER ' + QUOTENAME(@Email) + ';';
			EXEC sp_executesql @SqlStatement;
		END
END;

EXEC PERSON_Update  40 , 'ELMAZARETA@gmail.com' ;
SELECT * FROM PERSON

-----------------------------------------------------------
-----------------------------------------------------------
-----STORED PROCEDURE FOR INSERT INTAKE DATA
-----------------------------------------------------------
-----------------------------------------------------------

CREATE or alter PROCEDURE InsertIntake
    @Name NVARCHAR(100),
    @StartDate DATE
AS
BEGIN
 BEGIN TRY
    IF @Name IS NULL OR LTRIM(RTRIM(@Name)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

    ELSE IF @StartDate < GETDATE()  
    BEGIN
        print 'StartDate cannot be in the past.';
    END
    ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p WHERE  p.Role='admin' ))   
        BEGIN
            PRINT 'Access denied. You are not the ADMIN !.';
        END
    ELSE IF (SUSER_SNAME() in (SELECT  p.Email FROM Person p WHERE  p.Role='admin' )) 
	BEGIN 
    INSERT INTO Intake (Name, StartDate)
    VALUES (@Name, @StartDate);

	print 'Data inserted successfully.';
	END
	END try
	begin catch
	     select 'invalid input'h
	end catch

    
END;


exec InsertIntake 'intake-42' , '2/2/2026'



-----STORED PROCEDURE FOR DELETE INTAKE 

create OR ALTER proc deleteIntake @name varchar(100)
as 
  IF EXISTS (SELECT 1 FROM Intake WHERE Name = @Name)
  begin
   delete from intake  where name=@name
   print 'deleted successfully.';
  end 

  else
  begin
    print 'The intake is not exists'
  end

--CALL
 EXEC deleteIntake 'intake-48'




--Stored procedure update update Intake Name

create OR ALTER PROCEDURE updateIntakeName
    @oldName NVARCHAR(100), @newName NVARCHAR(100)
AS
BEGIN
    IF @oldName IS NULL OR LTRIM(RTRIM(@oldName)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Intake WHERE Name = @oldName)
     begin
       UPDATE Intake SET Name = @newName
       WHERE Name = @oldName
       print 'Update intake name successfully.';
     end 

    ELSE
	begin
	  print 'the intake name is not exists'
	end
end;

EXEC updateIntakeName 'intake-42' ,'intake-44' 




----STORED PROCEDURE TO UPDATE INTAKE START DATE BY INTAKE NAME-------------


create OR ALTER PROCEDURE updateIntakeStartDate
    @intake_Name NVARCHAR(100), @St_date date 
AS
BEGIN
    IF @intake_Name IS NULL OR LTRIM(RTRIM(@intake_Name)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Intake WHERE Name = @intake_Name)
     begin
       UPDATE Intake SET StartDate = @St_date
       WHERE Name = @intake_Name
       print 'Update Start date for intake ' + @intake_Name +  ' successfully.';
     end 

    ELSE
	begin
	  print 'the intake name is not exists.'
	end
end;

--call
EXEC updateIntakeStartDate 'intake-44' , '2/2/2028'


--STORED PROCEDURE FOR UPDATE INTAKE NAME & START DATE TOGETHER

create PROCEDURE updateIntakeNameAndDate
    @oldName NVARCHAR(100), 
    @NewName NVARCHAR(100),  
    @New_date DATE 
AS
BEGIN
    -- Check if the old name is NULL or empty
    IF @oldName IS NULL OR LTRIM(RTRIM(@oldName)) = ''
    BEGIN
        PRINT 'Name cannot be empty or NULL.';
        RETURN; -- Exit procedure if old name is invalid
    END

    -- Check if the intake with the old name exists
    IF EXISTS (SELECT 1 FROM Intake WHERE Name = @oldName)
    BEGIN
        BEGIN TRANSACTION;
            BEGIN TRY
                -- Update the intake record with new name and date
                UPDATE Intake 
                SET StartDate = @New_date, Name = @NewName
                WHERE Name = @oldName;

                COMMIT TRANSACTION;
                PRINT 'Update intake name ' + @oldName + ' to ' + @NewName + ' and start date to ' + CONVERT(NVARCHAR(20), @New_date, 120) + ' successfully.';
            END TRY
            BEGIN CATCH
                -- Rollback if an error occurs
                ROLLBACK TRANSACTION;
                PRINT 'An error occurred: please check again on your data may intake name do not follow rules ';
            END CATCH
    END
    ELSE
    BEGIN
        PRINT 'The intake name does not exist.';
    END
END;

--call

EXEC updateIntakeNameAndDate 'intake-44' , 'intake-45',  '2/2/2026';
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
---------------------------------STORED PROC TO RETRIVE all INTAKEs INFO --------

Create OR ALTER Proc ViewAIntakesInfo 
with encryption 
as 
  begin
      select * from  intake 
  end


--call
exec ViewAIntakesInfo


-------------------------STORED PROCEDURE TO RETRIVE INFO ABOUT SPECIFIC INTAKE USING NAME------------------


create OR ALTER PROCEDURE ViewSpecificIntakeInfo
    @intake_Name NVARCHAR(100)
AS
BEGIN
    IF @intake_Name IS NULL OR LTRIM(RTRIM(@intake_Name)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Intake WHERE Name = @intake_Name)
     begin
	   select * from intake 
	   where Name=@intake_Name
       
     end 

    ELSE
	begin
	  print 'the intake name is not exists.'
	end
end;

--call
EXEC ViewSpecificIntakeInfo 'intake-45'

select * from in

----------------------------DEPARTMENT--------------------------------
----------------------------DEPARTMENT--------------------------------
----------------------------DEPARTMENT--------------------------------
SELECT * FROM Department

-----------------------STORED PROCEDURE FOR INSERT DEPARTMENT---------

Create PROCEDURE InsertDepartment
    @Name NVARCHAR(100),
    @Describe NVARCHAR(255)
with encryption
AS
BEGIN
    IF @Name IS NULL OR LTRIM(RTRIM(@Name)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Department WHERE Name = @Name) 
     begin
       print 'The Department ' + @Name +  ' Is already exists.';
     end 

    ELSE
	BEGIN try
       INSERT INTO Department(Name, Describe)
       VALUES (@Name, @Describe);
	   print 'Data inserted successfully.';
	END try
	begin catch
	     select 'invalid input'
	end catch
    
END;

--call
exec InsertDepartment 'data sc' , ''
select * from department

------------------------STORED PROCEDURE FOR DELETE Depatment------------

Create OR ALTER PROCEDURE DeleteSpecificDepartment
    @DID NVARCHAR(100)
with encryption
AS
BEGIN
    IF @DID IS NULL OR LTRIM(RTRIM(@DID)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Department WHERE ID = @DID) 
     begin
	   delete from Department WHERE ID = @DID
       print 'The Department ' + @DID +  ' deleted.';
     end 

    ELSE
	   print 'The department is not exsists.';
   
END;

--call
exec DeleteSpecificDepartment 4 
select * from department

----------------------STORED PROCEDURE FOR DELETE ALL  DEPARTMENTS------------
CREATE proc deleteAllDepartments 
with encryption
as 
  begin
      delete from department
	  print 'The departments deleted';
  end

--call
EXEC deleteAllDepartments


----update id for previuos proc
------------------------STORED PROCEDURE FOR Update Department Name AND DESCRIPTION USING ID ----------

CREATE PROCEDURE updateDepartmentName
    @DID INT, @newName NVARCHAR(100) , @Describe NVARCHAR(255)
With encryption
AS
BEGIN
    IF @DID IS NULL OR LTRIM(RTRIM(@DID)) = '' 
	and @newName is null OR LTRIM(RTRIM(@DID)) = ''
    BEGIN
        print 'input cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Department WHERE ID = @DID) 
     begin
       UPDATE Department SET Name = @newName  , Describe=@Describe
       WHERE ID = @DID
       print 'Update intake name successfully.';
     end 

    ELSE
	begin
	  print 'the intake name is not exists'
	end
end;

EXEC updateDepartmentName  6,'data analysis ', ' ' 

select * from Department  




---------------------------------STORED PROC TO RETRIVE all DEPARTMENTS INFO --------

Create Proc ViewADepartmentsInfo 
with encryption 
as 
  begin
      select * from  Department 
  end


--call
exec ViewADepartmentsInfo


-------------------------STORED PROCEDURE TO RETRIVE INFO ABOUT SPECIFIC DEPT USING NAME------------------


create PROCEDURE ViewSpecificDepartmentInfo
    @DID INT
AS
BEGIN
    IF @DID IS NULL OR LTRIM(RTRIM(@DID)) = ''
    BEGIN
        print 'Department id cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Department WHERE ID = @DID)
     begin
	   select * from Department 
	   where ID=@DID
       
     end 

    ELSE
	begin
	  print 'the Department is not exists.'
	end
end;

--call
EXEC ViewSpecificDepartmentInfo 2
select * from Department


--------------------------COURSE--------------------------------
--------------------------COURSE--------------------------------
--------------------------COURSE--------------------------------
--------------------------COURSE--------------------------------



-----------------------------course procedures CRUD---------------------------------
CREATE or alter PROCEDURE sp_AddCourse
    @Name NVARCHAR(100),
    @Hours INT
AS
BEGIN
    IF (@Hours < 3 OR @Hours > 100)
    BEGIN
        RAISERROR ('Course hours must be between 3 and 100.', 16, 1);
        RETURN;
    END
	else
		begin
		INSERT INTO Course (Name, Hours)
		VALUES (@Name, @Hours);
		end
END;
---------------------------------------------
---------------------------------------------
CREATE or alter PROCEDURE sp_DeleteCourse
    @name NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@name;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
	else
			IF EXISTS (SELECT 1 FROM Topic WHERE CrsID = @id)
				BEGIN
					DELETE FROM Topic
					WHERE CrsID = @id
				END
			CREATE TABLE #questionIDS (
			questionID INT
			);
			insert into #questionIDS 
			select id from Question where CrsID=@id;
			DECLARE @QID INT;

			DECLARE question_cursor CURSOR FOR
			SELECT questionID from #questionIDS

			OPEN question_cursor;

			FETCH NEXT FROM question_cursor INTO @QID;

			WHILE @@FETCH_STATUS = 0
				BEGIN
				Delete from Choice
				where  QID = @QID

				FETCH NEXT FROM question_cursor INTO @QID;
				END;

			CLOSE question_cursor;
			DEALLOCATE question_cursor;
			delete from Course where ID=@id;
END;
exec sp_DeleteCourse 'Data Structures';
-------------------------------------------------
-------------------------------------------------
CREATE or alter PROCEDURE sp_GetCourse
    @courseid int
AS
BEGIN
    IF @courseid IS NULL OR LTRIM(RTRIM(@courseid)) = ''
    BEGIN
        print 'course id cannot be empty or NULL.';
    END

  else IF not EXISTS (SELECT * FROM course c WHERE c.ID = @courseid)
        PRINT 'No course found with the specified name';
  ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@courseid))   
        BEGIN
            PRINT 'Access denied. You are not the instructor for this course.';

        END

  else 
    IF EXISTS (SELECT * FROM course c WHERE c.ID = @courseid)
		begin 
			SELECT 
			c.name AS courseName,c.Hours as courseHour,
			ISNULL(STRING_AGG(t.Name, ', '), 'No topics') AS Topics 
		FROM 
			course c
		left JOIN 
			topic t ON c.ID = t.CrsID where c.ID=@courseid
			group by c.name,c.Hours
		end
	else
	 print 'course maybe not exists!' 
END;



exec sp_GetCourse 1


---------------------------------------------
---------------------------------------------


CREATE OR ALTER PROCEDURE sp_get_all_courses
AS
BEGIN
    SELECT *
    FROM Course;
END;
exec sp_get_all_courses
--------------------------------------
-------------------------------------------------------

CREATE or alter PROCEDURE sp_GetAllCoursesWithTopics
AS
BEGIN
    SELECT 
        C.Name AS CourseName,
        C.Hours AS CourseHours,
        ISNULL( STRING_AGG(T.Name, ', '),'no topic') AS Topics 
    FROM Course C
    LEFT JOIN Topic T ON C.ID = T.CrsID
    GROUP BY  C.Name, C.Hours; 
END;
exec sp_GetAllCoursesWithTopics;
-------------------------------------------------------
-------------------------------------------------------
CREATE or alter PROCEDURE sp_UpdateCourseName
    @oldName NVARCHAR(100),
    @newName NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@oldName;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
    else
	   update course set Name=@newName where ID=@id
END;
-------------------------------------------------------
-------------------------------------------------------

CREATE or alter PROCEDURE sp_UpdateCourseHour
    @Name NVARCHAR(100),
    @Hour int
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@Name;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
    else if (@Hour not between 3 and 100 )
	  RAISERROR ('Course hours must be between 3 and 100.', 16, 1);
	else
	   update course set Hours=@Hour where ID=@id
END;

-----------------------------topic procedures CRUD----------------------------------------
-----------------------------topic procedures CRUD----------------------------------------
-----------------------------topic procedures CRUD----------------------------------------
CREATE or alter PROCEDURE sp_AddTopic
    @topicName NVARCHAR(100),
    @CrsName NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@CrsName;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
	else 
		INSERT INTO [dbo].[Topic] ([Name], [CrsID])
		VALUES (@topicName, @id);
END;
-----------------------------------------
-----------------------------------------
CREATE PROCEDURE sp_UpdateTopicName
    @oldTopicName NVARCHAR(100),
	@newTopicName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Topic WHERE name = @oldTopicName)
	begin
		UPDATE [dbo].[Topic]
		SET [Name] = @newTopicName
		WHERE [Name] = @oldTopicName;
	end
	else
	 print 'No topic found with the specified name'
END;
-----------------------------------------
-----------------------------------------

CREATE or alter PROCEDURE sp_ChangeTopicCourse
    @TopicName NVARCHAR(100),
	@oldCourseName NVARCHAR(100),
	@newCourseName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)and 
	    EXISTS (SELECT 1 FROM course WHERE name = @oldCourseName ) and
		EXISTS (SELECT 1 FROM course WHERE name = @newCourseName )
		begin
			declare @oldCourseId int;
			declare @newCourseId int;
			select @oldCourseId=id from Course where Name=@oldCourseName;
			select @newCourseId=id from Course where Name=@newCourseName;
			UPDATE [dbo].[Topic]
			SET [CrsID] = @newCourseId
			WHERE [CrsID] = @oldCourseId and Name=@TopicName;
		end
	else if not EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)
	 print 'No topic found with the specified name'
	else if not EXISTS (SELECT 1 FROM course WHERE name = @oldCourseName )
	 print 'the course  you want to move the topic from does not exist '
	else if not EXISTS (SELECT 1 FROM course WHERE name = @newCourseName )
	 print 'the course  you want to move the topic to does not exist '
END;
--------------------------------------------------
--------------------------------------------------
CREATE PROCEDURE sp_DeleteTopic
    @TopicName NVARCHAR(100),
	@CourseName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)and 
	    EXISTS (SELECT 1 FROM course WHERE name = @CourseName )
    DELETE FROM [dbo].[Topic]
    WHERE [CrsID] = (select id from Course where Name=@CourseName) and name =@TopicName;
	else if not EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)
	 print 'No topic found with the specified name'
	else if not EXISTS (SELECT 1 FROM course WHERE name = @CourseName )
	 print 'the course you want to remove the topic from does not exist '
END;



--------------------------STORED PROCEDURE FOR EXAM ---------------------
--view specific exam     done
--view all exam          done
--insert exam data       done
--delete specific exam   done
--delete all             done
--update exam start date done


-------------------------------------------------------------
-------------------------------------------------------------
-------------------------------------------------------------
-------------------------------------------------------------
create or alter  procedure generate_exam
@examName nvarchar(100),
@startDate datetime,
@crsID int
with encryption
as
begin 
begin try
  begin transaction
	IF @crsID IS NULL
            PRINT 'Input Course ID cannot be NULL.';
	ELSE IF NOT EXISTS (SELECT 1 FROM COURSE WHERE ID = @CrsID)
	        PRINT 'Input Course ID cannot be found';
   ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@crsID))   
        BEGIN
            PRINT 'Access denied. You are not the instructor for this course.';
            ROLLBACK TRANSACTION;
        END
   else 
	begin
		insert into Exam (Name,StartDate,CrsID) values(@examName,@startDate,@crsID)
		declare @examID int=scope_identity();
		create table #selectedRandomQuestionIDS
		(
		QID int
		); 
		insert into #selectedRandomQuestionIDS
		SELECT TOP 10 id
				 FROM Question
				 WHERE CrsID = @crsID and isDeleted=0
				 ORDER BY NEWID();
	   insert into Answer_Exam (ExamID,QID,StdID) 
	   select @examID ,QID,sc.StdID from #selectedRandomQuestionIDS cross join Std_Crs SC where sc.CrsID=@crsID;
	   INSERT INTO Student_Exam (StdID, ExamID, Grade)
        SELECT 
            StdID AS StdID,
            @examID AS ExamID,
            0 AS Grade 
			FROM std_crs where CrsID=@crsID;
	   print 'exam is generated successefully'
	 commit transaction;
 end
end try 
begin catch 
 print 'error occured in exam generation '
 rollback;
end catch
end

exec generate_exam 'CExam','2029-2-13 11:25:30',3


------------------------------------------------------
-------------------STORED PROCEDURE FOR SUBMIT EXAM ANSWER-----------------------------------
CREATE OR ALTER PROCEDURE sp_submit_exam_answer
@examID INT,
@QID INT,
@stdAnswer INT
WITH ENCRYPTION
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @stdemail NVARCHAR(MAX) = SUSER_SNAME();
        DECLARE @stdid INT;
        DECLARE @crsid INT;
        DECLARE @currentDate DATETIME = GETDATE();
        DECLARE @exam_Start_Date DATETIME;
        DECLARE @exam_end_Date DATETIME;
        SELECT @stdid = p.id FROM Person p WHERE p.email = @stdemail;
        SELECT @crsid = CrsID FROM std_crs WHERE StdID = @stdid;
        SELECT @exam_Start_Date = StartDate, @exam_end_Date = EndDate FROM Exam WHERE ID = @examID;
        IF NOT EXISTS (SELECT 1 FROM COURSE WHERE ID = @crsid)
        BEGIN
            PRINT 'Input Course ID cannot be found.';
            ROLLBACK TRANSACTION;
        END;
       else IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN std_Crs sc ON p.ID = sc.stdid WHERE sc.CrsID =@crsid))   
        BEGIN
            PRINT 'Access denied. You are not a student in this course.';
            ROLLBACK TRANSACTION;
        END;

   
        else IF @exam_end_Date < @currentDate
        BEGIN
            PRINT 'Your exam is finished. Sorry!';
            ROLLBACK TRANSACTION;
        END; 
        else IF EXISTS (
            SELECT 1 FROM Answer_Exam
            WHERE ExamID = @examID AND QID = @QID AND StdID = @stdID
        ) AND @exam_Start_Date <= @currentDate
        BEGIN
          
            UPDATE Answer_Exam
            SET Answer = @stdAnswer
            WHERE ExamID = @examID AND QID = @QID AND StdID = @stdID;
            EXEC sp_calc_student_grade @stdid, @examID;

            PRINT 'Your answer has been submitted successfully.';
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'A problem occurred. Please re-enter your data or exam is not started!';
            ROLLBACK TRANSACTION;
        END;
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while submitting your exam answer.';
        ROLLBACK TRANSACTION;
    END CATCH;
END;




EXEC sp_submit_exam_answer
------------------------------------------------------------
---------------------CALCULATION STUDENT GRADE---------------------------------------
create or alter procedure sp_calc_student_grade
@stdID int,
@examID int 
with encryption 
as 
begin
   begin try
       begin transaction
	   if exists(select 1 from Student_Exam where ExamID=@examID and  StdID=@stdID)
		begin
		 declare @exam_total_grade int;
		 declare @student_total_grade int;
		 declare @student_total_percentage_grade int;
		 select @exam_total_grade=sum(degree) from Question Q inner join Answer_Exam AE on Q.ID=AE.QID 
		  and ExamID=@examID and StdID=@stdID
		 select @student_total_grade=sum(degree) from Question Q inner join Answer_Exam AE on Q.ID=AE.QID 
		  and ExamID=@examID and StdID=@stdID and Answer=CorrectChoice
		 update Student_Exam set Grade=@student_total_grade where ExamID=@examID and StdID=@stdID
		 set @student_total_percentage_grade=(CAST(@student_total_grade AS DECIMAL(10,2)) / 
                                           CAST(@exam_total_grade AS DECIMAL(10,2)))*100;
		 --print 'your percentage grade is '+ CAST(@student_total_percentage_grade AS NVARCHAR(10)) + ' %';
		 commit transaction;
		end
	   else 
	   rollback;
		 print 'your data is not valid '
   end try 
   begin catch 
	   rollback;
      PRINT 'Error occurred while calculating the grade.';
   end catch 
end
EXEC sp_calc_student_grade 61,20



-------------------------STORED PROCEDURE FOR Retrive data about specific exam------------------------

create or alter PROCEDURE ViewSpecificExamInfo
    @EX_ID INT
WITH ENCRYPTION
AS
BEGIN
    declare @crsid int
    select @crsid=CrsID from exam where id =@EX_ID
    IF @EX_ID IS NULL OR LTRIM(RTRIM(@EX_ID)) = ''
    BEGIN
        print 'Department id cannot be empty or NULL.';
    END
   ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@crsid ))   
        BEGIN
            PRINT 'Access denied. You are not the instructor for this exam !.';
        END
    ELSE 
    begin
     IF EXISTS (SELECT 1 FROM Exam WHERE ID = @EX_ID)
     begin
	   select * from exam 
	   where ID=@EX_ID   
     end 

    ELSE
	begin
	  print 'the EXAM is not exists.'
	end
 end
end;

--call
EXEC ViewSpecificExamInfo 20
select * from person



---------------------------------STORED PROC TO RETRIVE all EXAMS INFO --------

CREATE Proc ViewExamsInfo 
with encryption 
as 
  begin
      select * from  Exam 
  end


--call
exec ViewExamsInfo






------------------------STORED PROCEDURE FOR DELETE SPECIFIC EXAM------------*********
create or alter PROCEDURE DeleteSpecificExam
    @EX_ID NVARCHAR(100)
with encryption
AS
BEGIN
    declare @crsid int
	select @crsid=CrsID from exam where id=@EX_ID
    IF @EX_ID IS NULL OR LTRIM(RTRIM(@EX_ID)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END
    ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@CrsID ))   
        BEGIN
            PRINT 'Access denied. You are not the instructor !.';
        END
   ELSE 
   begin
      IF EXISTS (SELECT 1 FROM Exam WHERE ID = @EX_ID) 
       begin
	   delete from Exam WHERE ID = @EX_ID
       print 'The EXAM ' + @EX_ID +  ' deleted.';
       end 

     ELSE
	   print 'The Exam is not exsists.';
	end
   
END;

--call
exec DeleteSpecificExam 17

select * from exam

----------------------STORED PROCEDURE FOR DELETE ALL EXAMS------------
CREATE or alter proc deleteAllExams 
with encryption
as 
  begin
      delete from exam
	  print 'The exams deleted';
  end

--call
EXEC deleteAllExams
select * from exam
--------------------------STORED PROCEDURE TO UPDATE START DATE FOR EXAM-----------------
CREATE or alter PROCEDURE updateExamStartDate
    @EX_id INT, @newdate DATETIME 
With encryption
AS
BEGIN
   begin try
   declare @crsid int
   select @crsid=CrsID from exam where id =@EX_id
    IF @EX_id is null
        print 'Exam id cannot be empty or NULL.'
	else IF @newdate <= GETDATE()
            PRINT 'StartDate cannot be in the past or today or empty.';
	ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@crsid ))   
        BEGIN
            PRINT 'Access denied. You are not the instructor !.';
        END
   ELSE 
    begin
      IF EXISTS (SELECT 1 FROM EXAM WHERE ID = @EX_id) 
     begin
       UPDATE Exam SET StartDate = @newdate  
       WHERE ID = @EX_id
       print 'Update exam start date successfully.';
     end 
	 else
	    PRINT 'Exam with the given ID does not exist.';
	end
  end try
  begin catch
	  print 'there are error occured'
  end catch

end;

EXEC updateExamStartDate  20,'9/9/2029  13:45:30'

---------------------------INSTRUCTOR-COURSE ---------------------------

--VIEW ALL INSTRUCTOR COURSE                         DONE
--VIEW SPECIFIC EACH COURSE FOR INSTRUCTOR           done   
--DELETE ANY INSTRUCOR WITH ALL COURSES              DONE      
--DELETE ANY INSTRUCTOR WITH SPECIFIC COURSE         done  
--DELETE ALL INS_CR TABLE                            DONE
--UPDATE COURSE FOR INSTRUCTOR   RAMI C -->C++       done                                                     
--UPDATE INSTRUCTOR FOR COURSE                       DONE
--INSERT INTO                                        DONE

--------------------------STORED PROCEDURE TO VIEW ALL INSTRUCTOR COURSE-------------   

CREATE PROC ViewAllInstructorCourse
WITH ENCRYPTION
AS
  BEGIN
  	   select ic.InsID as [instructorID],p.Name as[Instructor_Name]  , c.Name as [Cpurse_Name]  ,ic.CrsID
	   from Ins_Crs ic join person p
	   on p.ID=ic.InsID
	   join Course c on  c.ID=ic.CrsID 
  END

--CALL
EXEC ViewAllInstructorCourse


-------------------------STORED PROCEDURE TO VIEW  COURSES FOR SPECIFIC INSTRUCTOR------------------------


CREATE PROCEDURE GetCoursesByInstructor

    @INS_ID INT = NULL  
WITH ENCRYPTION
AS
BEGIN
  begin try
    IF @INS_ID IS NULL 
    BEGIN
        print 'Instructor id cannot be empty or NULL.';
    END

    else IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID)
     begin
	   select InsID as [instructorID],p.Name as[Instructor_Name] ,  c.Name as [Course_Name]  , ic.CrsID AS [Course_ID] 
	   from Ins_Crs ic join person p
	   on p.ID=ic.InsID
	   join Course c on  c.ID=ic.CrsID
	   where InsID=@INS_ID   
     end 

    ELSE
	begin
	  PRINT 'The Instructor with ID ' + CAST(@INS_ID AS NVARCHAR(10)) + ' does not exist.';
	end
  end try
    BEGIN CATCH
        PRINT 'An error occurred, please try again.';
    END CATCH
end;

--call
EXEC GetCoursesByInstructor 7




------------------------STORED PROCEDURE FOR DELETE all courses for specific instructor ------------

create PROCEDURE DeleteInstructorCourses
    @INS_ID INT = NULL  
with encryption
AS
BEGIN
  begin try
    IF @INS_ID IS NULL 
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT * FROM Ins_Crs WHERE InsID = @INS_ID) 
     begin
	   delete from Ins_Crs WHERE InsID = @INS_ID
       print 'The courses for instructor ' + CAST(@INS_ID AS NVARCHAR(10))+ ' deleted.';
     end 
    
	ELSE
	   PRINT 'The Instructor with ID ' + CAST(@INS_ID AS NVARCHAR(10)) + ' does not exist.';
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;

--call
EXEC DeleteInstructorCourses 7



------------------------STORED PROCEDURE TO DELETE ASSIGNED OR SPCECIFFIC course for specific instructor ------------

CREATE PROCEDURE DeleteInstructorAssignedToCourse
    @INS_ID INT = NULL  ,  @CRS_ID INT = NULL        
with encryption
AS
BEGIN
  begin try
    IF @INS_ID IS NULL OR @CRS_ID IS NULL
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID and CRSid=@CRS_ID) 
     begin
	   delete from Ins_Crs WHERE  InsID = @INS_ID and CRSid=@CRS_ID
       print 'The course with ID : '+CAST(@CRS_ID AS NVARCHAR(10)) +' for instructor ' + CAST(@INS_ID AS NVARCHAR(10))+ ' deleted.';
     end 
    
	ELSE
	   PRINT 'The Assignation coures for this instructor does not exist.';
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;

--call
EXEC DeleteInstructorAssignedToCourse 7 , 5







----------------------STORED PROCEDURE FOR DELETE ALL data into instructor_course ------------
CREATE proc deleteAllInstructorCourseData 
with encryption
as 
  begin
      delete from Ins_Crs
	  print 'The Instructor_Course table deleted';
  end

--call
EXEC deleteAllInstructorCourseData
select * from Ins_Crs



-----------------------------------STORED PROCEDURE TO INSERT INSTRUCTOR COURSE ------------------
CREATE PROCEDURE InsertInstructorCourse
     @INS_ID INT = NULL  ,  @CRS_ID INT = NULL
WITH ENCRYPTION
AS
BEGIN
  BEGIN TRY
     IF @INS_ID IS NULL 
       BEGIN
        print 'Input INS_ID cannot be empty or NULL.';
       END

     ELSE IF @CRS_ID IS NULL
            PRINT 'Input Course ID cannot be NULL.';

     ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @CRS_ID)
            PRINT 'The Course with ID: ' + CAST(@CRS_ID AS NVARCHAR(10)) + ' is not found.';
	 ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID = @INS_ID)
            PRINT 'The INSTRUCTOR with ID: ' + CAST(@INS_ID AS NVARCHAR(10)) + ' is not found.';
	ELSE IF EXISTS (SELECT * FROM Ins_Crs WHERE InsID = @INS_ID and CrsID=@CRS_ID)
            PRINT 'The Assigned Between ' + CAST(@INS_ID AS NVARCHAR(10))+' and'+CAST(@CRS_ID AS NVARCHAR(10)) + ' is already exists.';
     ELSE
        BEGIN
            INSERT INTO Ins_Crs( InsID, CrsID)
            VALUES (@INS_ID,@CRS_ID);
			PRINT 'Data inserted successfully.';
	    END
   END TRY
   BEGIN CATCH
            PRINT 'An error occurred.';
   END CATCH
END;

-- CALL
EXEC InsertInstructorCourse  75 , 10

---------------------------------STORED PROCEDURE TO UPDATE COURSE FOR INSTRUCTOR   RAMI  C --> RAMI  C++ -------------
CREATE PROCEDURE ModifyInstructorCourse
    @INS_ID INT = NULL  ,  @Old_CRS_ID INT = NULL   ,@new_CRS_ID INT = NULL 
with encryption
AS
BEGIN
  begin try
     IF @INS_ID IS NULL 
       BEGIN
        print 'Input INSTRUCTOR_ID cannot be empty or NULL.';
       END

     ELSE IF @Old_CRS_ID IS NULL OR @new_CRS_ID IS NULL 
            PRINT 'Input Course ID cannot be NULL.';
     ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID =@INS_ID)
            PRINT 'The instructor with ID: ' + CAST(@INS_ID AS NVARCHAR(10)) + ' is not found.';
	 ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @Old_CRS_ID)
            PRINT 'The old Course with ID: ' + CAST(@Old_CRS_ID AS NVARCHAR(10)) + ' is not found.';
     ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @new_CRS_ID)
            PRINT 'The new Course with ID: ' + CAST(@new_CRS_ID AS NVARCHAR(10)) + ' is not found.';

     ElSE IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID and CRSid=@Old_CRS_ID)  --ins_id  , old
	   begin
	     IF not EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID and CRSid=@new_CRS_ID)
		     begin
			    update Ins_Crs set CrsID=@new_CRS_ID
				where InsID=@INS_ID and CrsID=@Old_CRS_ID 
		      end
		 else
		 begin
		     print 'the assgination with instructor id: '+CAST(@INS_ID AS NVARCHAR(10))+' and course id: '+CAST(@new_CRS_ID AS NVARCHAR(10))+ ' already exists'
		 end
	   end
    else
     begin
          print 'the assgination with instructor id: '+CAST(@INS_ID AS NVARCHAR(10))+' and course id: '+CAST(@Old_CRS_ID AS NVARCHAR(10))+ ' is not exists'
     end 	
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;
--call
 EXEC ModifyInstructorCourse 75,11 , 9


 ---------------------------------STORED PROCEDURE TO UPDATE COURSE FOR INSTRUCTOR   RAMI  C --> hani  C-------------
create PROCEDURE ModifyCourseInstructor
    @oldINS_ID INT = NULL  ,  @CRS_ID INT = NULL   ,@newIns_ID INT = NULL 
with encryption
AS
BEGIN
  begin try
     IF @oldINS_ID IS NULL or @newins_ID is null
       BEGIN
        print 'Input INSTRUCTOR_ID cannot be empty or NULL.';
       END

     ELSE IF @CRS_ID IS NULL  
            PRINT 'Input Course ID cannot be NULL.';
     ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID =@oldINS_ID)
            PRINT 'The old instructor with ID: ' + CAST(@oldINS_ID AS NVARCHAR(10)) + ' is not found.';
	 ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @CRS_ID)
            PRINT 'The Course with ID: ' + CAST(@CRS_ID AS NVARCHAR(10)) + ' is not found.';
     ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID = @newIns_ID)
            PRINT 'The new Instructor with ID: ' + CAST(@newIns_ID AS NVARCHAR(10)) + ' is not found.';

     ElSE IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @oldINS_ID and CRSid=@CRS_ID)  --ins_id  , old
	   begin
	     IF not EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @newIns_ID and CRSid=@CRS_ID)
		     begin
			    update Ins_Crs set InsID=@newIns_ID
				where InsID=@oldINS_ID and CrsID=@CRS_ID 
		      end
		 else
		 begin
		     print 'the assgination with instructor id: '+CAST(@newIns_ID AS NVARCHAR(10))+' and course id: '+CAST(@CRS_ID AS NVARCHAR(10))+ ' already exists'
		 end
	   end
    else
     begin
          print 'the assgination with instructor id: '+CAST(@oldINS_ID AS NVARCHAR(10))+' and course id: '+CAST(@CRS_ID AS NVARCHAR(10))+ ' is not exists'
     end 	
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;
--CALL
EXEC ModifyCourseInstructor 76 , 9, 75



------------------------------------------STUDENT_COURSE---------------------
--1: VIEW ALL STUDENT COURSE                              DONE 
--2: VIEW ALL COURSE BY STUDENT                           DONE
--3: VIEW ALL STUDETN WITH SAME COURSE                    DONE
--4: DELETE STUDENT WITH ALL HIS COURSE                   DONE
--5: DELETE COURSE THAT WILL DELETE ALL STUDENT TOO       DONE
--6: DELETE TABLE                                         DONE
--7: INSERT STUDENT WITH COURSE                           DONE
---------------------------------STORED PROCEDURE VIEW ALL STUDENT COURSE --------------------------------------------
CREATE PROC ViewStudentCourse
WITH ENCRYPTION
AS 

   BEGIN
      SELECT s.StdID as [student_id] ,p.Name as [student_name]  ,s.CrsID as [course_id],c.Name as [course_name] 
	  FROM Std_Crs s join person p 
	  on s.StdID=p.id
	  join Course c on CrsID=c.ID
   END 

--CALL 
EXEC ViewStudentCourse



---------------------------------STORED PROCEDURE VIEW ALL COURSE BY STUDENT    --------------------------------------------
CREATE OR ALTER PROC ViewCoursesByStudent
    @St_id int=null
WITH ENCRYPTION
AS 
 begin
 if @St_id is null
        print 'student ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE StdID = @St_id)
       BEGIN
          SELECT s.StdID as [student_id] ,p.Name as [student_name]  ,s.CrsID as [course_id],c.Name as [course_name] 
	      FROM Std_Crs s join person p 
	      on s.StdID=p.id
	      join Course c on CrsID=c.ID
	     where StdID=@St_id
        END

 else
   begin
     print 'student id: '+CAST(@St_id AS NVARCHAR(10))+ ' not fount'
   end
end
--CALL 
EXEC ViewCoursesByStudent 5
---------------------------------STORED PROCEDURE  VIEW ALL STUDETN WITH SAME COURSE    --------------------------------------------
create PROC ListStudentsForCourse
    @Cr_id int=null
WITH ENCRYPTION
AS 
 begin
 if @Cr_id is null
        print 'Course ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE CrsID = @Cr_id)
       BEGIN
          SELECT s.StdID as [student_id] ,p.Name as [student_name]  ,c.Name as [course_name] 
	      FROM Std_Crs s join person p 
	      on s.StdID=p.id
	      join Course c on CrsID=c.ID
	     where CrsID = @Cr_id
        END

 else
   begin
     print 'course id: '+CAST(@Cr_id AS NVARCHAR(10))+ ' not fount'
   end
end
--CALL 
EXEC ListStudentsForCourse 2

----------------------STORED PROCEDURE TO DELETE STUDENT WITH ALL HIS COURSE----------
CREATE OR ALTER proc  DeleteStudentAndAssociatedCourses
  @ST_ID INT=NULL
WITH ENCRYPTION
AS 
BEGIN
    BEGIN TRY
	    IF @ST_ID is null
           print 'STUDENT ID should not be null OR EMPTY'

		ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE StdID = @ST_ID)
           BEGIN
		     DELETE FROM Std_Crs WHERE StdID=@ST_ID
			 PRINT 'COURSES FOR STUDENT '+CAST(@ST_ID AS NVARCHAR(10))+' DELETED'
           END
	   else
           begin
             print 'STUDENT id: '+CAST(@ST_ID AS NVARCHAR(10))+ ' not fount'
            end
	END TRY
	BEGIN CATCH
	   PRINT 'ERROR OCCURED.'
	END CATCH
END

--CALL
EXECUTE DeleteStudentAndAssociatedCourses 6

----------------------STORED PROCEDURE TO Drop Course And IT'S Enrolled Students----------
CREATE proc  DropCourseAndEnrolledStudents
  @CRS_ID INT=NULL
WITH ENCRYPTION
AS 
BEGIN
    BEGIN TRY
	    IF @CRS_ID is null
           print 'COURSE ID should not be null OR EMPTY'

		ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE CrsID = @CRS_ID)
           BEGIN
		     DELETE FROM Std_Crs WHERE CrsID=@CRS_ID
			 PRINT 'COURSE AND IT IS ENROLLED STUDENT '+CAST(@CRS_ID AS NVARCHAR(10))+' ARE DELETED'
           END
	   else
           begin
             print 'COURSE id: '+CAST(@CRS_ID AS NVARCHAR(10))+ ' not fount'
            end
	END TRY
	BEGIN CATCH
	   PRINT 'ERROR OCCURED.'
	END CATCH
END

--CALL
EXECUTE DropCourseAndEnrolledStudents 3

----------------------STORED PROCEDURE TO Drop STUDENT_COURSE----------
Create PROC DeleteStudentCoureTable
WITH ENCRYPTION
AS 
BEGIN
    BEGIN TRY
           BEGIN
		     DELETE FROM Std_Crs 
			 PRINT 'STUDENT_COURSE DATA DELETED' 
           END

	END TRY
	BEGIN CATCH
	   PRINT 'ERROR OCCURED.'
	END CATCH
END

--CALL
EXECUTE DeleteStudentCoureTable
-----------------------------------STORED PROCEDURE TO INSERT STUDENT COURSE ------------------
CREATE  PROCEDURE InsertStudentCourse
     @St_ID INT = NULL  ,  @CRS_ID INT = NULL
WITH ENCRYPTION
AS
BEGIN
  BEGIN TRY
     IF @St_ID IS NULL 
       BEGIN
        print 'Input Student_ID cannot be empty or NULL.';
       END

     ELSE IF @CRS_ID IS NULL
            PRINT 'Input Course ID cannot be NULL.';
	 ELSE IF NOT EXISTS (SELECT * FROM Student WHERE StdID = @St_ID)
            PRINT 'The Student with ID: ' + CAST(@St_ID AS NVARCHAR(10)) + ' is not found.';
     ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @CRS_ID)
            PRINT 'The Course with ID: ' + CAST(@CRS_ID AS NVARCHAR(10)) + ' is not found.';
	ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE StdID = @St_ID and CrsID=@CRS_ID)
            PRINT 'The Assigned Between ' + CAST(@St_ID AS NVARCHAR(10))+' and'+CAST(@CRS_ID AS NVARCHAR(10)) + ' is already exists.';
    ELSE
        BEGIN
            INSERT INTO Std_Crs( StdID, CrsID)
            VALUES (@St_ID,@CRS_ID);
			PRINT 'Data inserted successfully.';
	    END
   END TRY
   BEGIN CATCH
            PRINT 'An error occurred.';
   END CATCH
END;

-- CALL
EXEC InsertStudentCourse  6, 4



--------------------------------------------QUESTION-------------------------
--------------------------------------------QUESTION-------------------------
--------------------------------------------QUESTION-------------------------
--------------------------------------------QUESTION-------------------------


CREATE or alter PROCEDURE pro_insert_question_choice
    @Body NVARCHAR(MAX),
    @Type NVARCHAR(10) ,
    @Degree INT ,
	@CorrectChoice INT,
	@CrsName NVARCHAR(MAX),
    @Choice1 NVARCHAR(MAX) = NULL,
    @Choice2 NVARCHAR(MAX) = NULL,
    @Choice3 NVARCHAR(MAX) = NULL,
    @Choice4 NVARCHAR(MAX) = NULL
	 
AS
BEGIN
  begin try
    begin transaction;

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
    PRINT 'No course found with the specified name';

   ELSE IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@CrsID))   
        BEGIN
            PRINT 'Access denied. You are not the instructor for this course.';
            ROLLBACK TRANSACTION;
        END
	ELSE
	begin
	INSERT INTO Question (Body, [Type], Degree, CorrectChoice, CrsID)
	VALUES (@Body, @Type, @Degree, @CorrectChoice, @CrsID);

	DECLARE @question_id INT;
    SELECT @question_id = SCOPE_IDENTITY();

	if( @Type='mcq')
	begin
		 if( @Choice1 IS NOT NULL AND @Choice2 IS NOT NULL AND
		      @Choice3 IS NOT NULL AND @Choice4 IS NOT NULL )
			 begin 
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,1, @Choice1);
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,2, @Choice2);
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,3, @Choice3);
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,4, @Choice4);
			commit transaction;
			end 
	      ELSE
            BEGIN
                RAISERROR('All choices must be provided for MCQ questions.', 16, 1);
            END
		
	 end
    else 
		begin 
				INSERT INTO Choice(QID,Choice,body)
				VALUES (@question_id,1, 'T');
				INSERT INTO Choice(QID,Choice,body)
				VALUES (@question_id,2, 'F');
				commit transaction;
		end
	end 
end try 
begin catch
rollback;
print 'error occured when insert qustion'
end catch
END;

EXEC pro_insert_question_choice 
    'What is not the main feature of OOP?', 
    'MCQ', 
    3, 
    4, 
    'Data Structures', 
    'Encapsulation', 
    'Polymorphism', 
    'Inheritance', 
    'primary key';
	select * from Course
	select * from Ins_Crs
-------------------------------------------------------------

---------------------------------------------------------------------
---------------------------------------------------------------------

CREATE or alter PROCEDURE view_allQuestions_bycourse
@CrsName NVARCHAR(MAX)
As 
begin

 
    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;
	IF @@ROWCOUNT = 0
       PRINT 'No course found with the specified name';
	else IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@CrsID))   
	or SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@CrsID
        BEGIN
            PRINT 'Access denied. You are not the instructor for this course.';
        END
	ELSE
	begin
	SELECT 
			q.Body AS QuestionBody,
			MAX(CASE WHEN c.Choice = 1 THEN c.body END) AS Choice1,
			MAX(CASE WHEN c.Choice = 2 THEN c.body END) AS Choice2,
			MAX(CASE WHEN c.Choice = 3 THEN c.body END) AS Choice3,
			MAX(CASE WHEN c.Choice = 4 THEN c.body END) AS Choice4
		FROM Question q
		inner JOIN 
			Choice c ON q.ID = c.QID and q.CrsID = @CrsID
		GROUP BY 
			q.ID, q.Body;
end
end;

exec view_allQuestions_bycourse 'Data Structures';
select * from course
----------------------------view all question by admin---------
create proc view_allQuestionsByAdmin
with encryption
as
begin
   	SELECT 
			q.Body AS QuestionBody,
			MAX(CASE WHEN c.Choice = 1 THEN c.body END) AS Choice1,
			MAX(CASE WHEN c.Choice = 2 THEN c.body END) AS Choice2,
			MAX(CASE WHEN c.Choice = 3 THEN c.body END) AS Choice3,
			MAX(CASE WHEN c.Choice = 4 THEN c.body END) AS Choice4
		FROM Question q
		inner JOIN 
			Choice c ON q.ID = c.QID 
		GROUP BY 
			q.ID, q.Body;
end
exec view_allQuestionsByAdmin
--------------------------------------------------------------------
--------------------------------------------------------------------
--------------------------------------------------------------------

CREATE or alter PROCEDURE delete_course_specific_question
@CrsName NVARCHAR(MAX), 
@QuesID Int
As 
begin

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
       PRINT 'No course found with the specified name';

    else IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@CrsID))   
        BEGIN
            PRINT 'Access denied. You are not the instructor for this course.';
        END
	else
		 begin
		   IF EXISTS (SELECT 1 FROM Question WHERE ID = @QuesID and CrsID= @CrsID ) 
			   begin
					update Question
					set isDeleted = 1
					where ID = @QuesID and CrsID =  @CrsID
				end
			else 
			 PRINT 'No  Question found with the specified id';
		 end
end

exec delete_course_specific_question 'Data Structures', 1;

select * from Question
-----------------------------------------------------------------------------
------------------------------------------------------------------------------
CREATE or alter PROCEDURE delete_course_questions
@CrsName NVARCHAR(MAX)
As 
begin

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
       PRINT 'No course found with the specified name';

    else IF (SUSER_SNAME() not in (SELECT  p.Email FROM Person p JOIN Ins_Crs ic ON p.ID = ic.InsID WHERE ic.CrsID =@CrsID))   
        BEGIN
            PRINT 'Access denied. You are not the instructor for this course.';
        END
	else 
		begin
			update Question
			set isDeleted = 1
			where CrsID =  @CrsID
		 end
end

exec delete_course_questions 'Calculus I';


-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------
--REPORTS ----REPORTS         REPORTS
-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------
----------------------------------stored procedure for reports------------------------
-----------Report that returns the students information according to Department #No parameter.--
create or alter procedure sp_std_info_depart
@deptID int 
with encryption 
as 
begin 
select  p.*,s.IntakeID,s.College from Person p inner join Department d on p.DeptID=d.ID and p.Role='student'
and d.ID=@deptID
inner join Student s on s.StdID=p.ID 
end
sp_std_info_depart 1 
------------------------------------------------------------------------------
---------------Report that takes the student ID and returns the grades of the student in all courses. %-----------
create or alter procedure sp_std_courses_grade
@stdID int 
with encryption 
as 
begin 
select C.Name,E.Name,SE.grade from Student_Exam SE 
inner join exam E on E.id=SE.examid inner join course C on C.ID =E.CrsID where SE.StdID=@stdID
and E.EndDate < GETDATE()
end
exec sp_std_courses_grade 3

-------------Report that takes the instructor ID and returns the name of the courses 
----------------that he teaches and the number of student per course. 
create or alter procedure sp_std_courses_instructor
@instructID int 
with encryption 
as 
begin 
select C.Name ,count(Sc.StdID) as 'stundent number' from course C inner join Ins_Crs IC 
 on C.ID= IC.CrsID 
left join Std_Crs SC on SC.StdID=c.ID and IC.InsID=@instructID group by c.Name
end
sp_std_courses_instructor 2
-----------------Report that takes course ID and returns its topics -------------------------
CREATE or alter PROCEDURE sp_GetCourse_ITS_Topics 
    @CrsID INT
AS
BEGIN

    SELECT 
        t.Name AS TopicName
    FROM Topic t
    WHERE t.CrsID = @CrsID;
END;
exec sp_GetCourse_ITS_Topics  1
----for report builder

CREATE or alter PROCEDURE sp_GetCourse_Topics_by_crsid 
    @CrsID INT
AS
BEGIN
SELECT 
    c.Name AS CourseName,
    t.Name AS TopicName
FROM 
    course c
LEFT JOIN 
    Topic t ON t.CrsID = c.id
WHERE 
    c.id = @CrsID

END;
-----------------Report that takes exam number and returns the Questions in it and chocies--
CREATE or alter procedure sp_GET_exam_question_choice
@examid int 
with encryption 
as 
begin
     declare @crsid int
	 select @crsid=CrsID from exam where id=@examid
    IF @examid IS NULL OR LTRIM(RTRIM(@examid)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END
	else IF NOT EXISTS (
        SELECT p.Email 
        FROM Person p
        LEFT JOIN Ins_Crs ic ON p.ID = ic.InsID AND ic.CrsID = 2
        WHERE p.Email = SUSER_SNAME() AND (ic.InsID IS NOT NULL OR p.Role = 'admin')
    )
      BEGIN
            PRINT 'Access denied. You are not the instructor !.';
      END
   ELSE 
    IF EXISTS (SELECT 1 FROM Exam WHERE ID = @examid)
   begin
    select  q.Body,
        MAX(CASE WHEN c.Choice = 1 THEN c.Body END) AS Choice1,
        MAX(CASE WHEN c.Choice = 2 THEN c.Body END) AS Choice2,
        MAX(CASE WHEN c.Choice = 3 THEN c.Body END) AS Choice3,
        MAX(CASE WHEN c.Choice = 4 THEN c.Body END) AS Choice4
		from Question q left join Choice c on q.ID=c.QID 
        inner join Answer_Exam AE on AE.QID=q.ID and AE.ExamID=@examid group by q.Body
   end
end

exec sp_GET_exam_question_choice 20

select * from person
----------------Report that takes exam number and the student ID then returns
----the Questions in this exam with the student answers.
create or alter procedure sp_GET_EXAM_QUESTIONS_WITH_STUDENT_ANSWER
@examid int ,
@stdID int 
with encryption 
as 
begin
     declare @crsid int
	 select @crsid=CrsID from exam where id=@examid
     IF @examid IS NULL OR LTRIM(RTRIM(@examid)) = ''  
       BEGIN
        print 'Input cannot be empty or NULL.';
       END
       else IF NOT EXISTS (
        SELECT p.Email 
        FROM Person p
        LEFT JOIN Ins_Crs ic ON p.ID = ic.InsID AND ic.CrsID = 2
        WHERE p.Email = SUSER_SNAME() AND (ic.InsID IS NOT NULL OR p.Role = 'admin')
       ) 
      BEGIN
            PRINT 'Access denied. You are not the instructor !.';
      END
   ELSE 
   begin
    IF EXISTS (SELECT 1 FROM Exam WHERE ID = @examid)
      begin
        select  q.Body,c.Body
        from Question q inner join Answer_Exam AE on q.ID=AE.QID
        inner join Choice c on c.Choice =AE.Answer and c.QID=q.ID where AE.ExamID=@examid 
	    and AE.StdID=@stdID 
      end
    else
     print 'exam or student  maybe no exsists'
 end
end






