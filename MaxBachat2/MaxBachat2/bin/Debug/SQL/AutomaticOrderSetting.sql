SELECT pvs.[VendorID]
	,pvoc.OrderEmails
	,pvoc.[OrderPhoneNo]
	,PV.Name
      ,[Mon]
      ,[Tue]
      ,[Wed]
      ,[Thu]
      ,[Fri]
      ,[Sat]
      ,[Sun]
      ,[DayofMonth]
      ,[OrderTime]
      ,[AutoOrdering]
	  ,[OrderMethod]
	  
  FROM [mbo].[PSVendorSchedule] pvs
  left join mbo.PSVendorOrderContacts pvoc on pvoc.VendorId=pvs.VendorID
  left join dbo.ProductVendor pv on pvs.VendorID= pv.ProductVendorId