SELECT Distinct 	pi.ProductItemId
	,pi.LongName
	,pi.Barcode
	,(Select SUBSTRING((SELECT ',' + pib.Barcode AS 'data()' FROM ProductItemBarcode pib where pib.ProductItemId = pi.ProductItemId FOR XML PATH('')), 0, 9999)) as AltBarcode
	,(SELECT StockQuantity FROM [dbo].[CalculatedInventory] ci WHERE CompanyBranchId=@BranchId AND ci.ProductItemid=pi.ProductItemId)as Inv
	,pi.CostPrice
	  
	  ,omoq.[MOQ]
      ,omoq.[MOQUnit]
	  
	  ,odos.[DOS1_5]
      ,odos.[DOS6_10]
      ,odos.[DOS11_15]
      ,odos.[DOS16_20]
      ,odos.[DOS21_25]
      ,odos.[DOS26_31]
	  ,(SELECT olimit.[Min] FROM mbo.PSOrderingQtyLimits olimit WHERE CompanyBranchId=@BranchId AND olimit.ProductItemid=pi.ProductItemId)as Min
	  ,(SELECT olimit.[Max] FROM mbo.PSOrderingQtyLimits olimit WHERE CompanyBranchId=@BranchId AND olimit.ProductItemid=pi.ProductItemId)as Max
	  ,(SELECT olimit.[ROP] FROM mbo.PSOrderingQtyLimits olimit WHERE CompanyBranchId=@BranchId AND olimit.ProductItemid=pi.ProductItemId)as ROP

	  
	  ,sqhv.[Total_1M]
      ,sqhv.[Total_2M]
      
FROM ProductItem pi
LEFT JOIN mbo.SaleQtyHistoryView sqhv ON sqhv.ProductItemid=pi.productitemid
LEFT JOIN mbo.PSOrderingDOS odos on odos.ProductItemid=pi.productitemid
LEFT JOIN mbo.PSOrderingMOQ omoq on omoq.ProductItemid=pi.productitemid
LEFT JOIN mbo.PSOrderingQtyLimits olimit on olimit.ProductItemid=pi.productitemid
LEFT JOIN [mbo].[PSVendorItemMapping] vim on pi.ProductItemId = vim.ProductItemId
LEFT JOIN ProductItemBarcode pib on pib.ProductItemId = vim.ProductItemId 
WHERE vim.ProductVendorId=@VendorId 