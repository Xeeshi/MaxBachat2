IF(
(select count(*) from [mbo].PSVendorOrderContacts where VendorId=@vid)=0)
BEGIN
INSERT INTO [mbo].[PSVendorOrderContacts]([VendorId],[OrderEmails],[OrderPhoneNo]) values (@vid,@email,@phone)
END

ELSE
BEGIN
UPDATE [mbo].PSVendorOrderContacts SET OrderEmails=@email,[OrderPhoneNo]=@phone
 WHERE [VendorId]=@vid
END
