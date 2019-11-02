Select 
		pv.Name,pv.ProductVendorId 
From
		ProductVendor pv
	 JOIN 
	 COA c on pv.COAId = c.COAID 
	
WHERE
	 IsActiveCOA = 1
	 AND
	 pv.ProductVendorId NOT IN (SELECT VendorID FROM [mbo].PSVendorSchedule )
	 