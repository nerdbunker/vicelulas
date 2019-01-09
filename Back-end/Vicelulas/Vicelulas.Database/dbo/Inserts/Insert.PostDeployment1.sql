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

	(1, 'Brinks',null, 1),
	(2, 'Evo. MAPFRE',null, 1),
	(3, 'Finamax',null, 1),
	(4, 'MAPFRE',null, 1),
	(5, 'Formação',null, 1),
	(6, 'Produtos',null, 1),
	(7, 'Consultoria',null, 1)
	

)AS SOURCE (id,nome,id_mentor, ativo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (nome,id_mentor,ativo) 
VALUES (nome,id_mentor,ativo);





/*		 INSERTS TB_squad		*/


MERGE INTO TB_squad AS Target USING (VALUES

(1, null, 'Sequoia',null, 1),
(2, 7,	  'Gestão e Negócios',null, 1),
(3, null, 'Passarela',null, 1),
(4, null, 'Unibanco',null, 1),
(5, 5,    'Nerd Bunker',null, 1),
(6, 5,    'Bug Hunters',null, 1),
(7, 5,    'Lemoris',null, 1),
(8, 5,    'Alpha Noob',null, 1),
(9, 3,   'Fercondini',null, 1),
(10, 3,	  'Tomazini',null, 1),
(11, 4,	  'MAPFRE',null, 1),
(12, 4,	  'NN MAPFRE',null, 1),
(13, 2,	  'Ajlune',null, 1),
(14, 2,	  'Giaretta ',null, 1),
(15, 2,	  'Gustavo',null, 1),
(16, 1,	  'Mara',null, 1),
(17, 1,	  'Daniela',null, 1),
(18, 1,	  'Mansonetto',null, 1),
(19, 6,	  'RDV',null, 1),
(20, 6,	  'Efinance ',null, 1)
	

)AS SOURCE (id, id_tribo, nome,id_mentor, ativo)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_tribo, nome,id_mentor, ativo) 
VALUES (id_tribo, nome,id_mentor, ativo);



/*		 INSERTS TB_pessoas		*/


MERGE INTO TB_pessoa AS Target USING (VALUES
(1,	 2, 'Filipe Pereira Colaneri ', 'fpereira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(2,  3, 'Rafael Lino dos Santos ', 'rsantos@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(3,  6, 'Ednei Betti ', 'ebetti@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(4,  5, 'Gessiane da Silvia Martinelle ', 'gmartinelle@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(5,  2, 'Pablo Zampa ', 'pzampa@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(6,  4, 'Amanda Mayara de Araujo ', 'aaraujo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(7,  7, 'Filipe de Oliveira Ribeiro ', 'fribeiro@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 1, 3),
(8,  5, 'Danilo Cesar de Souza Ferreira ', 'dferreira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 19, 2, 3),
(9,  5, 'Mara Cristina da Rosa ', 'mrosa@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 18, 2, 3),
(10, 5, 'Pedro Octavio Rodrigues de Andrade  ', 'pandrade@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 18, 2, 3),
(11, 2, 'Thiago Mansonetto ', 'tmansonetto@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 2, 3),
(12, 2, 'Daniela Oliveira Francisco Teixeira ', 'dteixeira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 19, 2, 3),
(13, 4, 'Julio César Montalvão ', 'jmontalvao@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 19, 2, 3),
(14, 4, 'Sergio do Carmo Torres ', 'storres@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 2, 3),
(15, 4, 'Evandro Ribeiro ', 'eribeiro@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 18, 2, 3),
(16, 4, 'Lucio Flavio Fransoia ', 'lfransoia@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 18, 2, 3),
(17, 4, 'Murilo Eduardo Bacagini Santos ', 'msantos@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 18, 2, 3),
(18, 4, 'Marco Aurelio de Souza ', 'msouza@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 20, 2, 3),
(19, 4, 'Italo Biguzi Duarte ', 'iduarte@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 19, 2, 3),
(20, 7, 'Stephanie Bianca Brescancin ', 'sbrescancin@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 19, 2, 3),
(21, 7, 'Guilherme Bordallo de Almeida ', 'galmeida@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 18, 2, 3),
(22, 6, 'Ricardo Mean ', 'rmean@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(23, 5, 'Kaique Gustavo Ribeiro do Prado ', 'kprado@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 16, 2, 3),
(24, 2, 'Fernando Berstecher Ajlune ', 'fajilune@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 15, 2, 3),
(25, 2, 'Ricardo Marcel Giaretta ', 'rgiaretta@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 16, 2, 3),
(26, 2, 'Gustavo Serracchiani Ferrari ', 'gferrari@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 17, 2, 3),
(27, 4, 'Geovani Lima Azevedo ', 'gazevedo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 15, 2, 3),
(28, 4, 'Fabio Massaretto ', 'fmassaretto@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 17, 2, 3),
(29, 4, 'Tiago de Oliveira Teixeira  ', 'tteixeira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 17, 2, 3),
(30, 4, 'William Hartung ', 'whartung@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 15, 2, 3),
(31, 4, 'Deleon Henrique da Silva Pinto ', 'dpinto@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 15, 2, 3),
(32, 4, 'Evair Pereira Sousa ', 'esousa@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 16, 2, 3),
(33, 4, 'Luiz Carlos Cecatti Júnior ', 'ljunior@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 17, 2, 3),
(34, 8, 'Rafaela Girotte Sampaio  ', 'rsampaio@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 2),
(35, 5, 'Lucas Vendramin Antunes ', 'lantunes@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 10, 1, 3),
(36, 2, 'Daniel Meireles Tomazini ', 'dtomazini@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 10, 1, 3),
(37, 2, 'Rafael Zancani Fercondini ', 'rfercondini@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 9, 1, 3),
(38, 4, 'Ricardo Aparecido Garbati ', 'rgarbati@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 9, 1, 3),
(39, 4, 'Gregori Bruno Felicio ', 'gfelicio@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 10, 1, 3),
(40, 4, 'Mario Jorge de Araujo Barbosa ', 'mbarbosa@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 10, 1, 3),
(41, 4, 'Otavio Augusto Toledo de Paula Cipro ', 'ocipro@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 10, 1, 3),
(42, 9, 'Ricardo Alves de Souza Francisco ', 'rfrancisco@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(43, 5, 'Felipe de Mello Oliveira ', 'foliveira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 14, 1, 3),
(44, 2, 'Ricardo Cristiano Tapia ', 'rtapia@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 14, 1, 3),
(45, 4, 'Lucas Marques da Silva ', 'lsilva@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 14, 1, 3),
(46, 4, 'Cloter Gonçalves Barbosa Junior  ', 'cjunior@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 14, 1, 3),
(47, 4, 'Nicolas Tosatti ', 'ntosatti@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 14, 1, 3),
(48, 4, 'Mikaeri Ohana Estevam Candido ', 'mcandido@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 14, 1, 3),
(49, 8, 'Henrique Fantatho ', 'hfantatho@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 3, 2),
(50, 2, 'Emerson Carlos Duarte ', 'eduarte@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 1, 3, 3),
(51, 5, 'Tiago Henrique Bernardo ', 'tbernardo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 1, 1, 3),
(52, 2, 'Leandro Codarin ', 'lcodarin@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 1, 1, 3),
(53, 4, 'Rodrigo Alves Ferreira de Brito ', 'rbrito@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 1, 1, 3),
(54, 4, 'Anderson de Carvalho Bernabé ', 'abernabe@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 1, 1, 3),
(55, 4, 'Rafael de Moura Alves  ', 'ralves@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 1, 1, 3),
(56, 5, 'Aules Roni Jobstraibizer ', 'ajobstraibizer@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(57, 2, 'Guilherme Cestarolli Seleguim ', 'gseleguim@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(58, 4, 'Gabriel Bruno Traldi ', 'gtraldi@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(59, 9, 'Eduardo Alberto do Santos ', 'esantos@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(60, 9, 'Fernando Mendes ', 'fmendes@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(61, 10, 'Paulo Rogério Spiandorim Mattiuzzo    ', 'pmattiuzzo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 1, 3),
(62, 4, 'Fernando Alcântara Garcia ', 'fgarcia@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(63, 4, 'Ricardo Ramos ', 'rramos@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(64, 4, 'Silvia Cristina Arouche ', 'sarouche@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(65, 4, 'Elaine Viana Costa ', 'ecosta@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(66, 4, 'Leila Santana Ferreira Figueredo ', 'lfigueredo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(67, 4, 'Ana Clara Marson Rios Bordinhon ', 'abordinhon@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(68, 6, 'Everton Lima ', 'elima@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 2),
(69, 3, 'Gabriel William Galdino ', 'ggaldino@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 13, 1, 3),
(70, 7, 'Vanderley Neres de Silva ', 'vsilva@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 6, 1, 3),
(71, 7, 'Matheus Bio Salles ', 'msalles@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 6, 1, 3),
(72, 7, 'Lucas Túmolo Contesini  ', 'lcontesini@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 5, 1, 3),
(73, 7, 'Everton Luiz Ferreira ', 'eferreira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 8, 1, 3),
(74, 7, 'Mateus Augusto do Amaral ', 'mamaral@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 7, 1, 3),
(75, 7, 'Gléber Michel Alves Schiavo ', 'gschiavo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 7, 1, 3),
(76, 7, 'Luís Antonio Prado Lança ', 'llança@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 6, 1, 3),
(77, 7, 'Vanderlei Neres da Silva ', 'vsilva@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 6, 1, 3),
(78, 7, 'Pedro Mietto Bruini  ', 'pbruini@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 5, 1, 3),
(79, 7, 'Pedro de Souza Moraes ', 'pmoraes@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 8, 1, 3),
(80, 7, 'Denise Nogueira dos Santos  ', 'dsantos@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 6, 1, 3),
(81, 7, 'Mateus Gonçalves Brito ', 'mbrito@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 5, 1, 3),
(82, 7, 'Fábio Vieira Gonçalves  ', 'fgonçalves@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 8, 1, 3),
(83, 7, 'Jhonatan Vinícius Martins dos Santos  ', 'jsantos@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 8, 1, 3),
(84, 7, 'Caléo de Antonio Caciano ', 'ccaciano@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 7, 1, 3),
(85, 7, 'Isac Petinate ', 'ipetinate@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 5, 1, 3),
(86, 7, 'Fernando Junio da Silva ', 'fsilva@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 5, 1, 3),
(87, 7, 'Giovana Seleio Valini  ', 'gvalini@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 8, 1, 3),
(88, 7, 'Alex Barletta Araújo ', 'aaraujo@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 7, 1, 3),
(89, 7, 'Fernanda Luíza Conti ', 'fconti@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 7, 1, 3),
(90, 7, 'Leandro Marques de Oliveira ', 'loliveira@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 6, 3, 3),
(91, 12, 'Anderson Soldeira de Lima Cavalcante ', 'acavalcante@viceri.com.br ','Tf8v2icK9WBwyyrhqy0xK0i+n5qolRLBe9Qa+zVlPZs==', 1, 2, 3, 2)
	

)AS SOURCE (id, id_papel, nome, email,password, ativo, id_squads, id_unidade,permissao)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN 
INSERT (id_papel, nome, email,password , ativo, id_squads, id_unidade,permissao) 
VALUES (id_papel, nome, email,password, ativo, id_squads, id_unidade,permissao);



MERGE INTO TB_mentor AS TARGET USING (VALUES
(1, 34),
(2, 49),
(3, 68),
(4, 91)
)AS SOURCE (id, id_pessoa)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN
INSERT(id_pessoa)
VALUES(id_pessoa);






