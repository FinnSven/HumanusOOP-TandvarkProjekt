CREATE PROCEDURE TestQuery    
	
	
	@FldAccountName nvarchar,
	@Fldpassword nvarchar, 
	@UserTypeID int 
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET COUNT TblUsers (SELECT @FldAccountName,@Fldpassword,@UserTypeID) 
END
GO 