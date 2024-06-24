/*Table create query*/

create table Artista (
	ID int PRIMARY KEY IDENTITY(1,1),
	Nome NVARCHAR(255) NOT NULL,
	Bio NVARCHAR(255) NOT NULL,
	FotoPerfil NVARCHAR(255) NOT NULL
);

SELECT * FROM Artista;

