IF(
(select count(*) from [mbo].PSOrderingDOS where ProductItemid=@pid)=0)
BEGIN
INSERT INTO [mbo].[PSOrderingDOS]([ProductItemId],[DOS1_5],[DOS6_10],[DOS11_15],[DOS16_20],[DOS21_25],[DOS26_31])
VALUES
 (@pid,@dos15,@dos610,@dos1115,@dos1620,@dos2125,@dos2631)
END

ELSE
BEGIN
UPDATE [mbo].[PSOrderingDOS]
SET 
 [DOS1_5] = @dos15
,[DOS6_10] = @dos610
,[DOS11_15] = @dos1115
,[DOS16_20] = @dos1620
,[DOS21_25] = @dos2125
,[DOS26_31] = @dos2631
 WHERE [ProductItemId]=@pid
END