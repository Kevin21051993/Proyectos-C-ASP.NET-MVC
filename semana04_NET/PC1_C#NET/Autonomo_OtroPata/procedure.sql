USE [bdventas]
GO

/****** Object:  StoredProcedure [dbo].[SPDETA]    Script Date: 01/25/2017 01:10:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPDETA]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPDETA]
GO

USE [bdventas]
GO

/****** Object:  StoredProcedure [dbo].[SPDETA]    Script Date: 01/25/2017 01:10:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPDETA](@FAC CHAR(5))
AS
SELECT A.ART_COD,ART_NOM,ART_PRE,ART_CAN,TOTAL=ART_PRE*ART_CAN
FROM ARTICULOS A INNER JOIN FAC_DETA D
ON A.ART_COD=D.ART_COD
WHERE FAC_NUM=@FAC
GO

