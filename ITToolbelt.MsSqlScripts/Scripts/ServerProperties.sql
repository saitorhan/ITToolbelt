SELECT  
  SERVERPROPERTY('MachineName') AS ComputerName,
  SERVERPROPERTY('ServerName') AS ServerName,  
  SERVERPROPERTY('Edition') AS Edition,
  SERVERPROPERTY('ProductLevel') AS ProductLevel,
  SERVERPROPERTY('ProductUpdateLevel') as ProductUpdateLevel,
  SERVERPROPERTY('ProductVersion') AS ProductVersion, 
  SERVERPROPERTY('Collation') AS Collation,  
  SERVERPROPERTY('ProductMajorVersion') AS ProductMajorVersion,
  SERVERPROPERTY('ProductMinorVersion') as ProductMinorVersion,
  SERVERPROPERTY('InstanceName') as InstanceName