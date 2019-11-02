
WITH tMon AS
(
SELECT (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID])  as Mon,[DayOfMonth] as MonDOM, ROW_NUMBER() OVER ( ORDER BY VendorID) AS RN1 FROM [mbo].[PSVendorSchedule] WHERE [MON]=1
),
tTue AS
(
SELECT  (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID]) as Tue,[DayOfMonth] as TueDOM, ROW_NUMBER() OVER ( ORDER BY VendoriD) AS RN2 FROM [mbo].[PSVendorSchedule] WHERE TUE=1
),
tWed AS
(
SELECT  (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID]) as Wed,[DayOfMonth] as WedDOM, ROW_NUMBER() OVER ( ORDER BY VendoriD) AS RN3 FROM [mbo].[PSVendorSchedule] WHERE Wed=1
),tThu AS
(
SELECT  (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID]) AS Thu,[DayOfMonth] as ThuDOM, ROW_NUMBER() OVER ( ORDER BY VendoriD) AS RN4 FROM [mbo].[PSVendorSchedule] WHERE Thu=1
),
tFri AS
(
SELECT  (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID]) as Fri,[DayOfMonth] as FriDOM, ROW_NUMBER() OVER ( ORDER BY VendoriD) AS RN5 FROM [mbo].[PSVendorSchedule] WHERE Fri=1
),
tSat AS
(
SELECT  (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID]) as Sat,[DayOfMonth] as SatDOM, ROW_NUMBER() OVER ( ORDER BY VendoriD) AS RN6 FROM [mbo].[PSVendorSchedule] WHERE Sat=1
),
tSun AS
(
SELECT  (select pv.Name from [ProductVendor] pv where pv.[ProductVendorId]=[VendorID]) as Sun,[DayOfMonth] as SunDOM, ROW_NUMBER() OVER ( ORDER BY VendoriD) AS RN7 FROM [mbo].[PSVendorSchedule] WHERE Sun=1
)



SELECT * FROM tmon
 FULL OUTER JOIN ttue ON RN1 =RN2
  FULL OUTER JOIN twed ON RN2 =RN3
   FULL OUTER JOIN Tthu ON RN2 =RN4
    FULL OUTER JOIN tfri ON RN2 =RN5
	 FULL OUTER JOIN tSat ON RN5 =RN6
	  FULL OUTER JOIN tSun ON RN6 =RN7
  