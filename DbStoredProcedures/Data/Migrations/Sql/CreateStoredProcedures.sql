SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssues 
	@Resolved bit
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk'

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' WHERE IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' WHERE IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByProductName 
	@Resolved bit,
	@ProductName NVARCHAR(200)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND'

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByProductNameVersion 
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@Version NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND
		Version.Version = ''' + @Version + ''' AND'

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByProductNameDateRange 
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@DateFrom DATETIME,
	@DateTo DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND
		Issue.CreationDate BETWEEN ''' + CONVERT(VARCHAR, @DateFrom, 101) + ''' AND ''' + CONVERT(VARCHAR, @DateTo, 101) + ''' AND'

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByProductNameVersionDateRange 
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@Version NVARCHAR(50),
	@DateFrom DATETIME,
	@DateTo DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND
		Version.Version = ''' + @Version + ''' AND
		Issue.CreationDate BETWEEN ''' + CONVERT(VARCHAR, @DateFrom, 101) + ''' AND ''' + CONVERT(VARCHAR, @DateTo, 101) + ''' AND'

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByKeyWords
	@Resolved bit,
	@Keywords NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk'

	DECLARE @pos INT
	DECLARE @len INT
	DECLARE @keyword NVARCHAR(MAX)

	SET @pos = 0
	SET @len = 0

	--Keywords has to end with a comma. If it's not there add it
	IF @Keywords NOT LIKE '%,'
	BEGIN
		SET @Keywords += ','
	END

	WHILE CHARINDEX(',', @Keywords, @pos+1)> 0
	BEGIN
		set @len = CHARINDEX(',', @Keywords, @pos + 1) - @pos
		set @keyword = SUBSTRING(@Keywords, @pos, @len)

		IF @pos = 0
			SET @sql += ' WHERE Issue.Problem LIKE ''%' + @keyword + '%'''
		ELSE
			SET @sql += ' AND Issue.Problem LIKE ''%' + @keyword + '%'''

		set @pos = CHARINDEX(',', @Keywords, @pos+@len) + 1
	END

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' AND IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' AND IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByProductNameKeyWords
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@Keywords NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''''

	DECLARE @pos INT
	DECLARE @len INT
	DECLARE @keyword NVARCHAR(MAX)

	SET @pos = 0
	SET @len = 0

	--Keywords has to end with a comma. If it's not there add it
	IF @Keywords NOT LIKE '%,'
	BEGIN
		SET @Keywords += ','
	END

	WHILE CHARINDEX(',', @Keywords, @pos+1)> 0
	BEGIN
		set @len = CHARINDEX(',', @Keywords, @pos + 1) - @pos
		set @keyword = SUBSTRING(@Keywords, @pos, @len)

		SET @sql += ' AND Issue.Problem LIKE ''%' + @keyword + '%'''

		set @pos = CHARINDEX(',', @Keywords, @pos+@len) + 1
	END

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' AND IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' AND IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllIssuesByProductNameVersionKeyWords
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@Version NVARCHAR(50),
	@Keywords NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND
		Version.Version = ''' + @Version + ''''

	DECLARE @pos INT
	DECLARE @len INT
	DECLARE @keyword NVARCHAR(MAX)

	SET @pos = 0
	SET @len = 0

	--Keywords has to end with a comma. If it's not there add it
	IF @Keywords NOT LIKE '%,'
	BEGIN
		SET @Keywords += ','
	END

	WHILE CHARINDEX(',', @Keywords, @pos+1)> 0
	BEGIN
		set @len = CHARINDEX(',', @Keywords, @pos + 1) - @pos
		set @keyword = SUBSTRING(@Keywords, @pos, @len)

		SET @sql += ' AND Issue.Problem LIKE ''%' + @keyword + '%'''

		set @pos = CHARINDEX(',', @Keywords, @pos+@len) + 1
	END

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' AND IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' AND IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


CREATE PROCEDURE GetAllIssuesByProductNameDateRangeKeywords
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@DateFrom DATETIME,
	@DateTo DATETIME,
	@Keywords NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND
		Issue.CreationDate BETWEEN ''' + CONVERT(VARCHAR, @DateFrom, 101) + ''' AND ''' + CONVERT(VARCHAR, @DateTo, 101) + ''''
		
	DECLARE @pos INT
	DECLARE @len INT
	DECLARE @keyword NVARCHAR(MAX)

	SET @pos = 0
	SET @len = 0

	--Keywords has to end with a comma. If it's not there add it
	IF @Keywords NOT LIKE '%,'
	BEGIN
		SET @Keywords += ','
	END

	WHILE CHARINDEX(',', @Keywords, @pos+1)> 0
	BEGIN
		set @len = CHARINDEX(',', @Keywords, @pos + 1) - @pos
		set @keyword = SUBSTRING(@Keywords, @pos, @len)

		SET @sql += ' AND Issue.Problem LIKE ''%' + @keyword + '%'''

		set @pos = CHARINDEX(',', @Keywords, @pos+@len) + 1
	END		

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' AND IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' AND IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO


CREATE PROCEDURE GetAllIssuesByProductNameDateRangeVersionKeywords
	@Resolved bit,
	@ProductName NVARCHAR(200),
	@DateFrom DATETIME,
	@DateTo DATETIME,
	@Version NVARCHAR(50),
	@Keywords NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'SELECT Issue.Id As IssueId, Issue.StatusFk, Issue.OperatingSystemFk, Issue.VersionFk, Issue.Problem, 
		Issue.CreationDate, Issue.Resolution, Issue.ResolutionDate, Product.Id AS ProductId, Product.Name As ProductName, 
		OperatingSystem.Id AS OsId, OperatingSystem.Name AS OsName, Version.Id AS VersionId, Version.Version,
		IssueStatus.Id AS IssueStatusId, IssueStatus.Name AS IssueStatusName
		FROM Issue
		JOIN IssueStatus ON IssueStatus.Id = Issue.StatusFk
		JOIN OperatingSystem ON OperatingSystem.Id = Issue.OperatingSystemFk
		JOIN Product ON Product.Id = Issue.ProductFk
		JOIN Version ON Version.Id = Issue.VersionFk
		WHERE Product.Name = ''' + @ProductName + ''' AND
		Issue.CreationDate BETWEEN ''' + CONVERT(VARCHAR, @DateFrom, 101) + ''' AND ''' + CONVERT(VARCHAR, @DateTo, 101) + '''
		AND Version.Version = ''' + @Version + ''''
		
	DECLARE @pos INT
	DECLARE @len INT
	DECLARE @keyword NVARCHAR(MAX)

	SET @pos = 0
	SET @len = 0

	--Keywords has to end with a comma. If it's not there add it
	IF @Keywords NOT LIKE '%,'
	BEGIN
		SET @Keywords += ','
	END

	WHILE CHARINDEX(',', @Keywords, @pos+1)> 0
	BEGIN
		set @len = CHARINDEX(',', @Keywords, @pos + 1) - @pos
		set @keyword = SUBSTRING(@Keywords, @pos, @len)

		SET @sql += ' AND Issue.Problem LIKE ''%' + @keyword + '%'''

		set @pos = CHARINDEX(',', @Keywords, @pos+@len) + 1
	END		

	DECLARE @resolvedName varchar(50)
	SET @resolvedName = '''Resolved'''
	IF @Resolved = 1
		SET @sql += ' AND IssueStatus.Name = ' + @resolvedName
	ELSE
		SET @sql += ' AND IssueStatus.Name != ' + @resolvedName

	EXEC(@sql)
END
GO