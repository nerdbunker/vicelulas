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

	(1, 'CDS Brinks ', 1),
	(2, 'CDS Evolutivas MAPFRE ', 1),
	(3, 'CDS Finamax   ', 1),
	(4, 'MAPFRE ', 1),
	(5, 'Formação ', 1),
	(6, 'Produtos ', 1),
	(7, 'Viceri ', 1)
	

)AS SOURCE (id, nome, ativo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (nome, ativo) 
VALUES (nome, ativo);


/*		 INSERTS TB_login		*/


MERGE INTO TB_login AS Target USING (VALUES

(1, 'viceri1', '123Aa321'),
(2, 'viceri2', '123Aa321'),
(3, 'viceri3', '123Aa321'),
(4, 'viceri4 ', '123Aa321'),
(5, 'viceri5 ', '123Aa321'),
(6, 'viceri6', '123Aa321'),
(7, 'viceri7', '123Aa321'),
(8, 'viceri8', '123Aa321'),
(9, 'viceri9', '123Aa321'),
(10, 'viceri10', '123Aa321'),
(11, 'viceri11', '123Aa321'),
(12, 'viceri12', '123Aa321'),
(13, 'viceri13', '123Aa321'),
(14, 'viceri14', '123Aa321'),
(15, 'viceri15', '123Aa321'),
(16, 'viceri16', '123Aa321'),
(17, 'viceri17', '123Aa321'),
(18, 'viceri18', '123Aa321'),
(19, 'viceri19', '123Aa321'),
(20, 'viceri20', '123Aa321'),
(21, 'viceri21', '123Aa321'),
(22, 'viceri22', '123Aa321'),
(23, 'viceri23', '123Aa321'),
(24, 'viceri24', '123Aa321'),
(25, 'viceri25', '123Aa321'),
(26, 'viceri26', '123Aa321'),
(27, 'viceri27', '123Aa321'),
(28, 'viceri28', '123Aa321'),
(29, 'viceri29', '123Aa321'),
(30, 'viceri30', '123Aa321'),
(31, 'viceri31', '123Aa321'),
(32, 'viceri32', '123Aa321'),
(33, 'viceri33', '123Aa321'),
(34, 'viceri34', '123Aa321'),
(35, 'viceri35', '123Aa321'),
(36, 'viceri36', '123Aa321'),
(37, 'viceri37', '123Aa321'),
(38, 'viceri38', '123Aa321'),
(39, 'viceri39', '123Aa321'),
(40, 'viceri40', '123Aa321'),
(41, 'viceri41', '123Aa321'),
(42, 'viceri42', '123Aa321'),
(43, 'viceri43', '123Aa321'),
(44, 'viceri44', '123Aa321'),
(45, 'viceri45', '123Aa321'),
(46, 'viceri46', '123Aa321'),
(47, 'viceri47', '123Aa321'),
(48, 'viceri48', '123Aa321'),
(49, 'viceri49', '123Aa321'),
(50, 'viceri50', '123Aa321'),
(51, 'viceri51', '123Aa321'),
(52, 'viceri52', '123Aa321'),
(53, 'viceri53', '123Aa321'),
(54, 'viceri54', '123Aa321'),
(55, 'viceri55', '123Aa321'),
(56, 'viceri56', '123Aa321'),
(57, 'viceri57', '123Aa321'),
(58, 'viceri58', '123Aa321'),
(59, 'viceri59', '123Aa321'),
(60, 'viceri60', '123Aa321'),
(61, 'viceri61', '123Aa321'),
(62, 'viceri62', '123Aa321'),
(63, 'viceri63', '123Aa321'),
(64, 'viceri64', '123Aa321'),
(65, 'viceri65', '123Aa321'),
(66, 'viceri66', '123Aa321'),
(67, 'viceri67', '123Aa321'),
(68, 'viceri68', '123Aa321'),
(69, 'viceri69', '123Aa321'),
(70, 'viceri70', '123Aa321'),
(71, 'viceri71', '123Aa321'),
(72, 'viceri72', '123Aa321'),
(73, 'viceri73', '123Aa321'),
(74, 'viceri74', '123Aa321'),
(75, 'viceri75', '123Aa321'),
(76, 'viceri76', '123Aa321'),
(77, 'viceri77', '123Aa321'),
(78, 'viceri78', '123Aa321'),
(79, 'viceri79', '123Aa321'),
(80, 'viceri80', '123Aa321'),
(81, 'viceri81', '123Aa321'),
(82, 'viceri82', '123Aa321'),
(83, 'viceri83', '123Aa321'),
(84, 'viceri84', '123Aa321'),
(85, 'viceri85', '123Aa321'),
(86, 'viceri86', '123Aa321'),
(87, 'viceri87', '123Aa321'),
(88, 'viceri88', '123Aa321'),
(89, 'viceri89', '123Aa321'),
(90, 'viceri90', '123Aa321'),
(91, 'viceri91', '123Aa321'),
(92, 'viceri92', '123Aa321'),
(93, 'viceri93', '123Aa321'),
(94, 'viceri94', '123Aa321'),
(95, 'viceri95', '123Aa321')
	

)AS SOURCE (id, username, password)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (username, password) 
VALUES (username, password);


/*		 INSERTS TB_squad		*/


MERGE INTO TB_squad AS Target USING (VALUES

(1, 7, 'CDS Sequoia', 1),
(2, 7, 'Gestão e Negócios', 1),
(3, 7, 'CDS Passarela', 1),
(4, 7, 'CDS Unibanco', 1),
(5, 7, 'Consultoria', 1),
(6, 5, 'Nerd Bunker', 1),
(7, 5, 'Bug Hunters', 1),
(8, 5, 'Lemoris Mutoalistas', 1),
(9, 5, 'Alpha Noob', 1),
(10, 3, 'Rafael Zancani Fercondini', 1),
(11, 3, 'Daniel Meireles Tomazini', 1),
(12, 4, 'CSS MAPFRE', 1),
(13, 4, 'CDS NN MAPFRE', 1),
(14, 2, 'Fernando Berstecher Ajlune', 1),
(15, 2, 'Ricardo Marcel Giaretta ', 1),
(16, 2, 'Gustavo Serracchini Ferrari ', 1),
(17, 1, 'Mara Cristina da Rosa ', 1),
(18, 1, 'Daniela Oliveira Francisco Teixeira ', 1),
(19, 1, 'Thiago Mansonetto ', 1),
(20, 6, 'CDP RDV ', 1),
(21, 6, 'CDP Efinance ', 1)
	

)AS SOURCE (id, id_tribo, nome, ativo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_tribo, nome, ativo) 
VALUES (id_tribo, nome, ativo);


/*		 INSERTS TB_pessoas		*/


MERGE INTO TB_pessoa AS Target USING (VALUES

(1, 1, 2, 'Filipe Pereira Colaneri ', 'fpereira@viceri.com.br ', 1, 21, 1, 1),
(2, 2, 3, 'Rafael Lino dos Santos ', 'rsantos@viceri.com.br ', 1, 21, 1, 1),
(3, 3, 6, 'Ednei Betti ', 'ebetti@viceri.com.br ', 1, 21, 1, 1),
(4, 4, 5, 'Gessiane da Silvia Martinelle ', 'gmartinelle@viceri.com.br ', 1, 21, 1, 1),
(5, 5, 2, 'Pablo Zampa ', 'pzampa@viceri.com.br ', 1, 21, 1, 1),
(6, 6, 4, 'Amanda Mayara de Araujo ', 'aaraujo@viceri.com.br ', 1, 21, 1, 1),
(7, 7, 7, 'Filipe de Oliveira Ribeiro ', 'fribeiro@viceri.com.br ', 1, 21, 1, 1),
(8, 8, 5, 'Danilo Cesar de Souza Ferreira ', 'dferreira@viceri.com.br ', 1, 20, 2, 1),
(9, 9, 5, 'Mara Cristina da Rosa ', 'mrosa@viceri.com.br ', 1, 19, 2, 1),
(10, 10, 5, 'Pedro Octavio Rodrigues de Andrade  ', 'pandrade@viceri.com.br ', 1, 19, 2, 1),
(11, 11, 2, 'Thiago Mansonetto ', 'tmansonetto@viceri.com.br ', 1, 21, 2, 1),
(12, 12, 2, 'Daniela Oliveira Francisco Teixeira ', 'dteixeira@viceri.com.br ', 1, 20, 2, 1),
(13, 13, 4, 'Julio César Montalvão ', 'jmontalvao@viceri.com.br ', 1, 20, 2, 1),
(14, 14, 4, 'Sergio do Carmo Torres ', 'storres@viceri.com.br ', 1, 21, 2, 1),
(15, 15, 4, 'Evandro Ribeiro ', 'eribeiro@viceri.com.br ', 1, 19, 2, 1),
(16, 16, 4, 'Lucio Flavio Fransoia ', 'lfransoia@viceri.com.br ', 1, 19, 2, 1),
(17, 17, 4, 'Murilo Eduardo Bacagini Santos ', 'msantos@viceri.com.br ', 1, 19, 2, 1),
(18, 18, 4, 'Marco Aurelio de Souza ', 'msouza@viceri.com.br ', 1, 21, 2, 1),
(19, 19, 4, 'Italo Biguzi Duarte ', 'iduarte@viceri.com.br ', 1, 20, 2, 1),
(20, 20, 7, 'Stephanie Bianca Brescancin ', 'sbrescancin@viceri.com.br ', 1, 20, 2, 1),
(21, 21, 7, 'Guilherme Bordallo de Almeida ', 'galmeida@viceri.com.br ', 1, 19, 2, 1),
(22, 22, 6, 'Ricardo Mean ', 'rmean@viceri.com.br ', 1, 2, 1, 1),
(23, 23, 5, 'Kaique Gustavo Ribeiro do Prado ', 'kprado@viceri.com.br ', 1, 17, 2, 1),
(24, 24, 2, 'Fernando Berstecher Ajlune ', 'fajilune@viceri.com.br ', 1, 16, 2, 1),
(25, 25, 2, 'Ricardo Marcel Giaretta ', 'rgiaretta@viceri.com.br ', 1, 17, 2, 1),
(26, 26, 2, 'Gustavo Serracchiani Ferrari ', 'gferrari@viceri.com.br ', 1, 18, 2, 1),
(27, 27, 4, 'Geovani Lima Azevedo ', 'gazevedo@viceri.com.br ', 1, 16, 2, 1),
(28, 28, 4, 'Fabio Massaretto ', 'fmassaretto@viceri.com.br ', 1, 18, 2, 1),
(29, 29, 4, 'Tiago de Oliveira Teixeira  ', 'tteixeira@viceri.com.br ', 1, 18, 2, 1),
(30, 30, 4, 'William Hartung ', 'whartung@viceri.com.br ', 1, 16, 2, 1),
(31, 31, 4, 'Deleon Henrique da Silva Pinto ', 'dpinto@viceri.com.br ', 1, 16, 2, 1),
(32, 32, 4, 'Evair Pereira Sousa ', 'esousa@viceri.com.br ', 1, 17, 2, 1),
(33, 33, 4, 'Luiz Carlos Cecatti Júnior ', 'ljunior@viceri.com.br ', 1, 18, 2, 1),
(34, 34, 8, 'Rafaela Girotte Sampaio  ', 'rsampaio@viceri.com.br ', 1, 2, 1, 2),
(35, 35, 5, 'Lucas Vendramin Antunes ', 'lantunes@viceri.com.br ', 1, 11, 1, 1),
(36, 36, 2, 'Daniel Meireles Tomazini ', 'dtomazini@viceri.com.br ', 1, 11, 1, 1),
(37, 37, 2, 'Rafael Zancani Fercondini ', 'rfercondini@viceri.com.br ', 1, 10, 1, 1),
(38, 38, 4, 'Ricardo Aparecido Garbati ', 'rgarbati@viceri.com.br ', 1, 10, 1, 1),
(39, 39, 4, 'Gregori Bruno Felicio ', 'gfelicio@viceri.com.br ', 1, 11, 1, 1),
(40, 21, 4, 'Mario Jorge de Araujo Barbosa ', 'mbarbosa@viceri.com.br ', 1, 11, 1, 1),
(41, 41, 4, 'Otavio Augusto Toledo de Paula Cipro ', 'ocipro@viceri.com.br ', 1, 11, 1, 1),
(42, 42, 9, 'Ricardo Alves de Souza Francisco ', 'rfrancisco@viceri.com.br ', 1, 5, 1, 1),
(43, 43, 5, 'Felipe de Mello Oliveira ', 'foliveira@viceri.com.br ', 1, 15, 1, 1),
(44, 44, 2, 'Ricardo Cristiano Tapia ', 'rtapia@viceri.com.br ', 1, 15, 1, 1),
(45, 45, 4, 'Lucas Marques da Silva ', 'lsilva@viceri.com.br ', 1, 15, 1, 1),
(46, 46, 4, 'Cloter Gonçalves Barbosa Junior  ', 'cjunior@viceri.com.br ', 1, 15, 1, 1),
(47, 47, 4, 'Nicolas Tosatti ', 'ntosatti@viceri.com.br ', 1, 15, 1, 1),
(48, 48, 4, 'Mikaeri Ohana Estevam Candido ', 'mcandido@viceri.com.br ', 1, 15, 1, 1),
(49, 49, 8, 'Henrique Fantatho ', 'hfantatho@viceri.com.br ', 1, 2, 3, 2),
(50, 50, 2, 'Emerson Carlos Duarte ', 'eduarte@viceri.com.br ', 1, 1, 3, 1),
(51, 51, 5, 'Tiago Henrique Bernardo ', 'tbernardo@viceri.com.br ', 1, 1, 1, 1),
(52, 52, 2, 'Leandro Codarin ', 'lcodarin@viceri.com.br ', 1, 1, 1, 1),
(53, 53, 4, 'Rodrigo Alves Ferreira de Brito ', 'rbrito@viceri.com.br ', 1, 1, 1, 1),
(54, 54, 4, 'Anderson de Carvalho Bernabé ', 'abernabe@viceri.com.br ', 1, 1, 1, 1),
(55, 55, 4, 'Rafael de Moura Alves  ', 'ralves@viceri.com.br ', 1, 1, 1, 1),
(56, 56, 5, 'Aules Roni Jobstraibizer ', 'ajobstraibizer@viceri.com.br ', 1, 2, 1, 1),
(57, 57, 2, 'Guilherme Cestarolli Seleguim ', 'gseleguim@viceri.com.br ', 1, 2, 1, 1),
(58, 58, 4, 'Gabriel Bruno Traldi ', 'gtraldi@viceri.com.br ', 1, 2, 1, 1),
(59, 59, 9, 'Eduardo Alberto do Santos ', 'esantos@viceri.com.br ', 1, 2, 1, 1),
(60, 60, 9, 'Fernando Mendes ', 'fmendes@viceri.com.br ', 1, 2, 1, 1),
(61, 61, 10, 'Paulo Rogério Spiandorim Mattiuzzo    ', 'pmattiuzzo@viceri.com.br ', 1, 5, 1, 1),
(62, 62, 4, 'Fernando Alcântara Garcia ', 'fgarcia@viceri.com.br ', 1, 14, 1, 1),
(63, 63, 4, 'Ricardo Ramos ', 'rramos@viceri.com.br ', 1, 14, 1, 1),
(64, 64, 4, 'Silvia Cristina Arouche ', 'sarouche@viceri.com.br ', 1, 14, 1, 1),
(65, 65, 4, 'Elaine Viana Costa ', 'ecosta@viceri.com.br ', 1, 14, 1, 1),
(66, 66, 4, 'Leila Santana Ferreira Figueredo ', 'lfigueredo@viceri.com.br ', 1, 14, 1, 1),
(67, 67, 4, 'Ana Clara Marson Rios Bordinhon ', 'abordinhon@viceri.com.br ', 1, 14, 1, 1),
(68, 68, 6, 'Everton Lima ', 'elima@viceri.com.br ', 1, 14, 1, 2),
(69, 69, 3, 'Gabriel William Galdino ', 'ggaldino@viceri.com.br ', 1, 14, 1, 1),
(70, 70, 7, 'Vanderley Neres de Silva ', 'vsilva@viceri.com.br ', 1, 7, 1, 1),
(71, 71, 7, 'Matheus Bio Salles ', 'msalles@viceri.com.br ', 1, 7, 1, 1),
(72, 72, 7, 'Lucas Túmolo Contesini  ', 'lcontesini@viceri.com.br ', 1, 6, 1, 1),
(73, 73, 7, 'Everton Luiz Ferreira ', 'eferreira@viceri.com.br ', 1, 9, 1, 1),
(74, 74, 7, 'Mateus Augusto do Amaral ', 'mamaral@viceri.com.br ', 1, 8, 1, 1),
(75, 75, 7, 'Gléber Michel Alves Schiavo ', 'gschiavo@viceri.com.br ', 1, 8, 1, 1),
(76, 76, 7, 'Luís Antonio Prado Lança ', 'llança@viceri.com.br ', 1, 7, 1, 1),
(77, 77, 7, 'Vanderlei Neres da Silva ', 'vsilva@viceri.com.br ', 1, 7, 1, 1),
(78, 78, 7, 'Pedro Mietto Bruini  ', 'pbruini@viceri.com.br ', 1, 6, 1, 1),
(79, 79, 7, 'Pedro de Souza Moraes ', 'pmoraes@viceri.com.br ', 1, 9, 1, 1),
(80, 80, 7, 'Denise Nogueira dos Santos  ', 'dsantos@viceri.com.br ', 1, 7, 1, 1),
(81, 81, 7, 'Mateus Gonçalves Brito ', 'mbrito@viceri.com.br ', 1, 6, 1, 1),
(82, 82, 7, 'Fábio Vieira Gonçalves  ', 'fgonçalves@viceri.com.br ', 1, 9, 1, 1),
(83, 83, 7, 'Jhonatan Vinícius Martins dos Santos  ', 'jsantos@viceri.com.br ', 1, 9, 1, 1),
(84, 84, 7, 'Caléo de Antonio Caciano ', 'ccaciano@viceri.com.br ', 1, 8, 1, 1),
(85, 85, 7, 'ISAC DANIEL FILDELFLAVIO PETINATE ', 'ipetinate@viceri.com.br ', 1, 6, 1, 1),
(86, 86, 7, 'Fernando Junio da Silva ', 'fsilva@viceri.com.br ', 1, 6, 1, 1),
(87, 87, 7, 'Giovana Seleio Valini  ', 'gvalini@viceri.com.br ', 1, 9, 1, 1),
(88, 88, 7, 'Alex Barletta Araújo ', 'aaraujo@viceri.com.br ', 1, 8, 1, 1),
(89, 89, 7, 'Fernanda Luíza Conti ', 'fconti@viceri.com.br ', 1, 8, 1, 1),
(90, 90, 7, 'Leandro Marques de Oliveira ', 'loliveira@viceri.com.br ', 1, 7, 3, 1),
(91, 91, 12, 'Anderson Soldeira de Lima Cavalcante ', 'acavalcante@viceri.com.br ', 1, 2, 3, 2)
	

)AS SOURCE (id, id_login, id_papel, nome, email, ativo, id_squads, id_unidade,permissao)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_login, id_papel, nome, email, ativo, id_squads, id_unidade,permissao) 
VALUES (id_login, id_papel, nome, email, ativo, id_squads, id_unidade,permissao);