USE CurrencyConverter
GO

INSERT INTO dbo.Currencies
	([Uid], FullName, ShortName, PurchaseRate, SellRate, IsDefaultCurrency, RoundingPolicyCode, SysInsertDateTime, SysInsertUser)
VALUES 
    (NEWID(), 'United States Dollar', 'USD', 1.00, 1.01, 0, 'KAUFM', GETDATE(), 'system'),
    (NEWID(), 'Euro', 'EUR', 0.93, 0.94, 0, 'KAUFM', GETDATE(), 'system'),
    (NEWID(), 'British Pound Sterling', 'GBP', 0.88, 0.89, 0, 'KAUFM', GETDATE(), 'system'),
    (NEWID(), 'Chinese Yuan Renminbi', 'CNY', 6.72, 6.75, 0, 'KAUFM', GETDATE(), 'system'),
    (NEWID(), 'Australian Dollar', 'AUD', 0.78, 0.79, 0, 'KAUFM', GETDATE(), 'system'),
    (NEWID(), 'Canadian Dollar', 'CAD', 0.84, 0.85, 0, 'KAUFM', GETDATE(), 'system'),
    (NEWID(), 'Swiss Franc', 'CHF', 1.00, 1.00, 1, 'KAUFM', GETDATE(), 'system');
GO