SELECT [Products].[Product],
		[Categories].[Category]
  FROM [Products]
  LEFT OUTER JOIN [Categories]
  ON [Products].[id] = [Categories].[id]
