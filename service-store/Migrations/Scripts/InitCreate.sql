CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `ServiceTeam` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` longtext NULL,
    CONSTRAINT `PK_ServiceTeam` PRIMARY KEY (`Id`)
);

CREATE TABLE `ServiceItems` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Title` longtext NULL,
    `Description` longtext NULL,
    `AllowAttachments` bit NOT NULL,
    `ServiceTeamId` int NULL,
    CONSTRAINT `PK_ServiceItems` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ServiceItems_ServiceTeam_ServiceTeamId` FOREIGN KEY (`ServiceTeamId`) REFERENCES `ServiceTeam` (`Id`) ON DELETE NO ACTION
);

CREATE INDEX `IX_ServiceItems_ServiceTeamId` ON `ServiceItems` (`ServiceTeamId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181105201201_InitCreate', '2.1.4-rtm-31024');