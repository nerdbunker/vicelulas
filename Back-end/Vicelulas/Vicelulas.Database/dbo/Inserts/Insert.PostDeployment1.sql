/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


/*		INSERTS TB_endereco		*/

MERGE INTO TB_endereco AS Target USING (VALUES

	(1, 'Brasil', 'SP', 'Jundiai', 'Centro', 'Rua General Osorio', NULL, 61, '3201-400'),
	(2, 'Brasil', 'SP', 'Jundiai', 'Nove de Julho', 'Jobim', NULL, 0, '000-000'),
	(3, 'Brasil', 'SP', 'Sao Paulo', 'Jd Sao Luis', 'Av. Maria Coelho Aguiar', 'Bloco C, 3º Andar', 215, '05804900')

)AS SOURCE (id, pais, estado, cidade, bairro, logradouro, complemento, numero, codigo_postal)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (pais, estado, cidade, bairro, logradouro, complemento, numero, codigo_postal) 
VALUES (pais, estado, cidade, bairro, logradouro, complemento, numero, codigo_postal);


/*		 INSERTS TB_unidade		*/


MERGE INTO TB_unidade AS Target USING (VALUES

	(1, 1, 'General Osorio'),
	(2, 2, 'Edificio Jobim'),
	(3, 3, 'Av. Maria Coelho Aguiar')

)AS SOURCE (id, id_endereco, nome)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_endereco, nome) 
VALUES (id_endereco, nome);


/*		 INSERTS TB_papel		*/


MERGE INTO TB_papel AS Target USING (VALUES

	(1, 'Teste'),
	(2, 'Analista de Sistemas '),
	(3, 'Programador '),
	(4, 'Analista Programador '),
	(5, 'Analista de Qualidade '),
	(6, 'Analista de Negócio '),
	(7, 'Estagiario de Programação '),
	(8, 'Coordenador de Desenvolvimento '),
	(9, 'Engenheiro de Software '),
	(10, 'Arquiteto UX/UI '),
	(11, 'Estagiario de Programação '),
	(12, 'Gerente de TI '),
	(13, 'Arquiteto de Testes')
	

)AS SOURCE (id, cargo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (cargo) 
VALUES (cargo);



/*		 INSERTS TB_tribo		*/


MERGE INTO TB_tribo AS Target USING (VALUES

	(1, 'Brinks', 1),
	(2, 'Evo. MAPFRE', 1),
	(3, 'Finamax', 1),
	(4, 'MAPFRE', 1),
	(5, 'Formação', 1),
	(6, 'Produtos', 1),
	(7, 'Consultoria',1)
	

)AS SOURCE (id, nome, ativo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (nome, ativo) 
VALUES (nome, ativo);


/*		 INSERTS TB_squad		*/


MERGE INTO TB_squad AS Target USING (VALUES

(1, null, 'Sequoia', 1),
(2, 7,	  'Gestão e Negócios', 1),
(3, null, 'Passarela', 1),
(4, null, 'Unibanco', 1),
(6, 5,    'Nerd Bunker', 1),
(7, 5,    'Bug Hunters', 1),
(8, 5,    'Lemoris', 1),
(9, 5,    'Alpha Noob', 1),
(10, 3,   'Fercondini', 1),
(11, 3,	  'Tomazini', 1),
(12, 4,	  'MAPFRE', 1),
(13, 4,	  'NN MAPFRE', 1),
(14, 2,	  'Ajlune', 1),
(15, 2,	  'Giaretta ', 1),
(16, 2,	  'Gustavo', 1),
(17, 1,	  'Mara', 1),
(18, 1,	  'Daniela', 1),
(19, 1,	  'Mansonetto', 1),
(20, 6,	  'RDV', 1),
(21, 6,	  'Efinance ', 1)
	

)AS SOURCE (id, id_tribo, nome, ativo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_tribo, nome, ativo) 
VALUES (id_tribo, nome, ativo);


/*		 INSERTS TB_pessoas		*/


MERGE INTO TB_pessoa AS Target USING (VALUES
(1,	 2, 'Filipe Pereira Colaneri ', 'fpereira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(2,  3, 'Rafael Lino dos Santos ', 'rsantos@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(3,  6, 'Ednei Betti ', 'ebetti@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(4,  5, 'Gessiane da Silvia Martinelle ', 'gmartinelle@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(5,  2, 'Pablo Zampa ', 'pzampa@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(6,  4, 'Amanda Mayara de Araujo ', 'aaraujo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(7,  7, 'Filipe de Oliveira Ribeiro ', 'fribeiro@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 1, 1),
(8,  5, 'Danilo Cesar de Souza Ferreira ', 'dferreira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 20, 2, 1),
(9,  5, 'Mara Cristina da Rosa ', 'mrosa@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 19, 2, 1),
(10, 5, 'Pedro Octavio Rodrigues de Andrade  ', 'pandrade@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 19, 2, 1),
(11, 2, 'Thiago Mansonetto ', 'tmansonetto@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 2, 1),
(12, 2, 'Daniela Oliveira Francisco Teixeira ', 'dteixeira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 20, 2, 1),
(13, 4, 'Julio César Montalvão ', 'jmontalvao@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 20, 2, 1),
(14, 4, 'Sergio do Carmo Torres ', 'storres@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 2, 1),
(15, 4, 'Evandro Ribeiro ', 'eribeiro@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 19, 2, 1),
(16, 4, 'Lucio Flavio Fransoia ', 'lfransoia@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 19, 2, 1),
(17, 4, 'Murilo Eduardo Bacagini Santos ', 'msantos@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 19, 2, 1),
(18, 4, 'Marco Aurelio de Souza ', 'msouza@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 21, 2, 1),
(19, 4, 'Italo Biguzi Duarte ', 'iduarte@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 20, 2, 1),
(20, 7, 'Stephanie Bianca Brescancin ', 'sbrescancin@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 20, 2, 1),
(21, 7, 'Guilherme Bordallo de Almeida ', 'galmeida@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 19, 2, 1),
(22, 6, 'Ricardo Mean ', 'rmean@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(23, 5, 'Kaique Gustavo Ribeiro do Prado ', 'kprado@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 17, 2, 1),
(24, 2, 'Fernando Berstecher Ajlune ', 'fajilune@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 16, 2, 1),
(25, 2, 'Ricardo Marcel Giaretta ', 'rgiaretta@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 17, 2, 1),
(26, 2, 'Gustavo Serracchiani Ferrari ', 'gferrari@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 18, 2, 1),
(27, 4, 'Geovani Lima Azevedo ', 'gazevedo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 16, 2, 1),
(28, 4, 'Fabio Massaretto ', 'fmassaretto@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 18, 2, 1),
(29, 4, 'Tiago de Oliveira Teixeira  ', 'tteixeira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 18, 2, 1),
(30, 4, 'William Hartung ', 'whartung@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 16, 2, 1),
(31, 4, 'Deleon Henrique da Silva Pinto ', 'dpinto@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 16, 2, 1),
(32, 4, 'Evair Pereira Sousa ', 'esousa@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 17, 2, 1),
(33, 4, 'Luiz Carlos Cecatti Júnior ', 'ljunior@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 18, 2, 1),
(34, 8, 'Rafaela Girotte Sampaio  ', 'rsampaio@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 2),
(35, 5, 'Lucas Vendramin Antunes ', 'lantunes@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 11, 1, 1),
(36, 2, 'Daniel Meireles Tomazini ', 'dtomazini@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 11, 1, 1),
(37, 2, 'Rafael Zancani Fercondini ', 'rfercondini@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 10, 1, 1),
(38, 4, 'Ricardo Aparecido Garbati ', 'rgarbati@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 10, 1, 1),
(39, 4, 'Gregori Bruno Felicio ', 'gfelicio@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 11, 1, 1),
(40, 4, 'Mario Jorge de Araujo Barbosa ', 'mbarbosa@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 11, 1, 1),
(41, 4, 'Otavio Augusto Toledo de Paula Cipro ', 'ocipro@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 11, 1, 1),
(42, 9, 'Ricardo Alves de Souza Francisco ', 'rfrancisco@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(43, 5, 'Felipe de Mello Oliveira ', 'foliveira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 15, 1, 1),
(44, 2, 'Ricardo Cristiano Tapia ', 'rtapia@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 15, 1, 1),
(45, 4, 'Lucas Marques da Silva ', 'lsilva@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 15, 1, 1),
(46, 4, 'Cloter Gonçalves Barbosa Junior  ', 'cjunior@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 15, 1, 1),
(47, 4, 'Nicolas Tosatti ', 'ntosatti@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 15, 1, 1),
(48, 4, 'Mikaeri Ohana Estevam Candido ', 'mcandido@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 15, 1, 1),
(49, 8, 'Henrique Fantatho ', 'hfantatho@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 3, 2),
(50, 2, 'Emerson Carlos Duarte ', 'eduarte@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 1, 3, 1),
(51, 5, 'Tiago Henrique Bernardo ', 'tbernardo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 1, 1, 1),
(52, 2, 'Leandro Codarin ', 'lcodarin@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 1, 1, 1),
(53, 4, 'Rodrigo Alves Ferreira de Brito ', 'rbrito@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 1, 1, 1),
(54, 4, 'Anderson de Carvalho Bernabé ', 'abernabe@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 1, 1, 1),
(55, 4, 'Rafael de Moura Alves  ', 'ralves@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 1, 1, 1),
(56, 5, 'Aules Roni Jobstraibizer ', 'ajobstraibizer@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(57, 2, 'Guilherme Cestarolli Seleguim ', 'gseleguim@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(58, 4, 'Gabriel Bruno Traldi ', 'gtraldi@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(59, 9, 'Eduardo Alberto do Santos ', 'esantos@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(60, 9, 'Fernando Mendes ', 'fmendes@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(61, 10, 'Paulo Rogério Spiandorim Mattiuzzo    ', 'pmattiuzzo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 1, 1),
(62, 4, 'Fernando Alcântara Garcia ', 'fgarcia@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(63, 4, 'Ricardo Ramos ', 'rramos@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(64, 4, 'Silvia Cristina Arouche ', 'sarouche@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(65, 4, 'Elaine Viana Costa ', 'ecosta@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(66, 4, 'Leila Santana Ferreira Figueredo ', 'lfigueredo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(67, 4, 'Ana Clara Marson Rios Bordinhon ', 'abordinhon@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(68, 6, 'Everton Lima ', 'elima@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 2),
(69, 3, 'Gabriel William Galdino ', 'ggaldino@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 14, 1, 1),
(70, 7, 'Vanderley Neres de Silva ', 'vsilva@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 7, 1, 1),
(71, 7, 'Matheus Bio Salles ', 'msalles@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 7, 1, 1),
(72, 7, 'Lucas Túmolo Contesini  ', 'lcontesini@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 6, 1, 1),
(73, 7, 'Everton Luiz Ferreira ', 'eferreira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 9, 1, 1),
(74, 7, 'Mateus Augusto do Amaral ', 'mamaral@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 8, 1, 1),
(75, 7, 'Gléber Michel Alves Schiavo ', 'gschiavo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 8, 1, 1),
(76, 7, 'Luís Antonio Prado Lança ', 'llança@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 7, 1, 1),
(77, 7, 'Vanderlei Neres da Silva ', 'vsilva@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 7, 1, 1),
(78, 7, 'Pedro Mietto Bruini  ', 'pbruini@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 6, 1, 1),
(79, 7, 'Pedro de Souza Moraes ', 'pmoraes@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 9, 1, 1),
(80, 7, 'Denise Nogueira dos Santos  ', 'dsantos@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 7, 1, 1),
(81, 7, 'Mateus Gonçalves Brito ', 'mbrito@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 6, 1, 1),
(82, 7, 'Fábio Vieira Gonçalves  ', 'fgonçalves@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 9, 1, 1),
(83, 7, 'Jhonatan Vinícius Martins dos Santos  ', 'jsantos@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 9, 1, 1),
(84, 7, 'Caléo de Antonio Caciano ', 'ccaciano@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 8, 1, 1),
(85, 7, 'Isac Petinate ', 'ipetinate@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 6, 1, 1),
(86, 7, 'Fernando Junio da Silva ', 'fsilva@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 6, 1, 1),
(87, 7, 'Giovana Seleio Valini  ', 'gvalini@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 9, 1, 1),
(88, 7, 'Alex Barletta Araújo ', 'aaraujo@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 8, 1, 1),
(89, 7, 'Fernanda Luíza Conti ', 'fconti@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 8, 1, 1),
(90, 7, 'Leandro Marques de Oliveira ', 'loliveira@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 7, 3, 1),
(91, 12, 'Anderson Soldeira de Lima Cavalcante ', 'acavalcante@viceri.com.br ','z2A8fvNuPehbViYpKNR9CBFGoSOAQwXMbBSmI5g4hwM=', 1, 2, 3, 2)
	

)AS SOURCE (id, id_papel, nome, email,password, ativo, id_squads, id_unidade,permissao)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_papel, nome, email,password , ativo, id_squads, id_unidade,permissao) 
VALUES (id_papel, nome, email,password, ativo, id_squads, id_unidade,permissao);