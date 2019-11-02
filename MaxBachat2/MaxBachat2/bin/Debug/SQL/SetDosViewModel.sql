SELECT Distinct 
     vim.ProductVendorId,
	pi.ProductItemId
	,pi.LongName

	  ,odos.[DOS1_5]
      ,odos.[DOS6_10]
      ,odos.[DOS11_15]
      ,odos.[DOS16_20]
      ,odos.[DOS21_25]
      ,odos.[DOS26_31]

	  
FROM ProductItem pi

LEFT JOIN mbo.PSOrderingDOS odos on odos.ProductItemid=pi.productitemid
LEFT JOIN [mbo].[PSVendorItemMapping] vim on pi.ProductItemId = vim.ProductItemId

WHERE vim.ProductVendorId=@VendorId 