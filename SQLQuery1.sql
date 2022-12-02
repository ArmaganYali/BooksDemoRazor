DECLARE @id AS INT = 60
            DECLARE @title AS nvarchar(50)
            WHILE @id > 0
            BEGIN
                    SET @title = CONCAT('Test ', @id)
                    INSERT INTO Books(title)
                    VALUES(@title)
                    SET @id = @id -1
            END

--TRUNCATE TABLE Books