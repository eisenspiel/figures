/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT [Products].[Product],
		[Categories].[Category]
  FROM [Products]
  LEFT OUTER JOIN [Categories]
  ON [Products].[id] = [Categories].[id]
