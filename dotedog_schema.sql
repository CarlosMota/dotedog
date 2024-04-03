CREATE TABLE UserProfile (
    UserID BIGINT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    Name Text NOT NULL,
    EmailAddress Text NOT NULL UNIQUE,
    DateOfBirth DATE NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL UNIQUE,
    Address Text NOT NULL,
    City VARCHAR(20)NOT NULL,
    State VARCHAR(20)NOT NULL,
    Zipcode VARCHAR(20) NOT NULL
);

CREATE TABLE UserAuth (
    UserID BIGINT PRIMARY KEY,
    Username Text NOT NULL UNIQUE,
    PasswordHash CHAR(60) NOT NULL, -- Considerando o uso de bcrypt, que gera hashes de tamanho fixo
    Salt Text NOT NULL, -- O tamanho do salt pode variar de acordo com a implementação
    AuthToken Text, -- Token opcional para autenticação/recuperação de senha
    CONSTRAINT fk_user_profile
        FOREIGN KEY(UserID) 
        REFERENCES UserProfile(UserID)
        ON DELETE CASCADE
);


CREATE TABLE species(
  Id SERIAL GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
  Name TEXT,
  PRIMARY KEY (Id)
);





