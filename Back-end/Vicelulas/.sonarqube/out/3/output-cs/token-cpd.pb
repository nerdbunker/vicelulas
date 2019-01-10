�
LC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Abstracao\IRepositorioBase.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Abstração "
{ 
internal 
	interface 
IRepositorioBase '
<' (
T( )
>) *
where+ 0
T1 2
:3 4
class5 :
{ 
IEnumerable 
< 
T 
> 

Selecionar !
(! "
)" #
;# $
T 	
SelecionarPorId
 
( 
int 
id  
)  !
;! "
int		 
Inserir		 
(		 
T		 
entity		 
)		 
;		 
void

 
Alterar

 
(

 
T

 
entity

 
)

 
;

 
} 
} �
IC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\AutenticacaoRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public		 

class		 #
AutenticacaoRepositorio		 (
:		) *$
IAutenticacaoRepositorio		+ C
{

 
public 
	PessoaDto 
Entrar 
(  
string  &
username' /
,/ 0
string1 7
password8 @
)@ A
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
	PessoaDto9 B
>B C
(C D
$"D F`
SSELECT P.Id, P.Nome, P.email, P.id_squads, P.Ativo, P.permissao FROM [TB_pessoa] P 	F �
"
� �
+
� �
$"C E;
/WHERE P.email = @Email AND P.password = @Senha E t
"t u
,u v
neww z
{C D
EmailG L
=M N
usernameO W
,W X
SenhaG L
=M N
passwordO W
}C D
)D E
;E F
return 
obj 
; 
} 
} 	
} 
} �
RC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Configuracao\DbConnectionFactory.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Configuração %
{ 
internal 
static 
class 
DbConnectionFactory -
{ 
public 
static 
string 
SQLConnectionString 0
=>1 3
$str	4 �
;
� �
} 
} �
TC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\IAutenticacaoRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface $
IAutenticacaoRepositorio -
{ 
	PessoaDto 
Entrar 
( 
string 
username  (
,( )
string* 0
password1 9
)9 :
;: ;
}		 
}

 �
NC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\IMentorRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface 
IMentorRepositorio '
{ 
int		 
Inserir		 
(		 
int		 
entity		 
)		 
;		  
IEnumerable

 
<

 
	MentorDto

 
>

 

Selecionar

 )
(

) *
)

* +
;

+ ,
} 
} �
MC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\IPapelRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface 
IPapelRepositorio &
{ 
IEnumerable 
< 
PapelDto 
> 

Selecionar (
(( )
)) *
;* +
}		 
}

 �
NC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\IPessoaRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface 
IPessoaRepositorio '
{ 
void		 
Alterar		 
(		 
Pessoa		 
entity		 "
)		" #
;		# $
void

 !
AtivarDesativarPessoa

 "
(

" #
int

# &
id

' )
,

) *
bool

+ /
ativo

0 5
)

5 6
;

6 7
int 
Inserir 
( 
Pessoa 
entity !
)! "
;" #
IEnumerable 
< 
	PessoaDto 
> 

Selecionar )
() *
)* +
;+ ,
	PessoaDto 
SelecionarPorEmail $
($ %
string% +
email, 1
)1 2
;2 3
	PessoaDto 
SelecionarPorId !
(! "
int" %
id& (
)( )
;) *
IEnumerable 
< 
	PessoaDto 
>  
SelecionarPorIdSquad 3
(3 4
int4 7
?7 8
id9 ;
); <
;< =
IEnumerable 
< 
	PessoaDto 
> 
SelecionarPorNome 0
(0 1
string1 7
nome8 <
)< =
;= >
	PessoaDto '
SelecionarPorNomeEspecifico -
(- .
string. 4
nome5 9
)9 :
;: ;
} 
} �
MC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\ISquadRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface 
ISquadRepositorio &
{ 
void		 
Alterar		 
(		 
Squad		 
entity		 !
)		! "
;		" #
void

 
AlterarStatus

 
(

 
Squad

  
entity

! '
)

' (
;

( )
void  
AtivarDesativarSquad !
(! "
int" %
id& (
,( )
bool* .
ativo/ 4
)4 5
;5 6
int 
Inserir 
( 
Squad 
entity  
)  !
;! "
IEnumerable 
< 
SquadDto 
> 

Selecionar (
(( )
)) *
;* +
SquadDto 
SelecionarPorId  
(  !
int! $
id% '
)' (
;( )
IEnumerable 
< 
SquadDto 
>  
SelecionarPorIdTribo 2
(2 3
int3 6
id7 9
)9 :
;: ;
IEnumerable 
< 
SquadDto 
> 
SelecionarPorNome /
(/ 0
string0 6
nome7 ;
); <
;< =
IEnumerable 
< 
SquadDto 
> $
SelecionarSquadsSemTribo 6
(6 7
)7 8
;8 9
SquadDto '
SelecionarPorNomeEspecifico ,
(, -
string- 3
nome4 8
)8 9
;9 :
} 
} �
MC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\ITriboRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface 
ITriboRepositorio &
{ 
void		 
AlterarNome		 
(		 
Tribo		 
entity		 %
)		% &
;		& '
void

 
AlterarStatus

 
(

 
Tribo

  
entity

! '
)

' (
;

( )
void  
AtivarDesativarTribo !
(! "
int" %
id& (
,( )
bool* .
ativo/ 4
)4 5
;5 6
int 
Inserir 
( 
Tribo 
entity  
)  !
;! "
IEnumerable 
< 
TriboDto 
> 

Selecionar (
(( )
)) *
;* +
TriboDto 
SelecionarPorId  
(  !
int! $
id% '
)' (
;( )
IEnumerable 
< 
TriboDto 
> 
SelecionarPorNome /
(/ 0
string0 6
nome7 ;
); <
;< =
TriboDto '
SelecionarPorNomeEspecifico ,
(, -
string- 3
nome4 8
)8 9
;9 :
} 
} �
OC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Interface\IUnidadeRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public 

	interface 
IUnidadeRepositorio (
{ 
IEnumerable 
< 

UnidadeDto 
> 

Selecionar  *
(* +
)+ ,
;, -
}		 
}

 �
CC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\MentorRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{		 
public

 

class

 
MentorRepositorio

 "
:

# $
IMentorRepositorio

% 7
{ 
public 
IEnumerable 
< 
	MentorDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -
	MentorDto- 6
>6 7
(7 8
$"8 :L
@SELECT M.id, M.Id_Pessoa, P.nome AS NomePessoa FROM TB_mentor M : z
"z {
+| }
$"8 :8
,INNER JOIN TB_pessoa P ON M.id_pessoa = P.id: f
"f g
)g h
;h i
return 
lista 
; 
} 
} 	
public 
int 
Inserir 
( 
int 
entity %
)% &
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
return 

connection !
.! "
QuerySingle" -
<- .
int. 1
>1 2
(2 3
$"3 5
DECLARE @Id int; 5 F
"F G
+H I
$"3 50
$INSERT INTO [TB_mentor] (Id_Pessoa) 5 Y
"Y Z
+[ \
$"3 5
VALUES(@idPessoa) 5 G
"G H
+I J
$"3 5(
SET @Id = SCOPE_IDENTITY(); 5 Q
"Q R
+S T
$"3 5

SELECT @Id5 ?
"? @
,@ A
newB E
{3 4
idPessoa  7 ?
=  @ A
entity  B H
}!!3 4
)!!4 5
;!!5 6
}"" 
}## 	
}&& 
}'' �
BC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\PapelRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public		 

class		 
PapelRepositorio		 !
:		" #
IPapelRepositorio		$ 5
{

 
public 
IEnumerable 
< 
PapelDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -
PapelDto- 5
>5 6
(6 7
$"7 92
&SELECT P.Id, P.Cargo FROM [TB_papel] P9 _
"_ `
)` a
;a b
return 
lista 
; 
} 
} 	
} 
} �x
CC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\PessoaRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{		 
public

 

class

 
PessoaRepositorio

 "
:

# $
IPessoaRepositorio

% 7
{ 
public 
IEnumerable 
< 
	PessoaDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -
	PessoaDto- 6
>6 7
(7 8
$"8 :�
�SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P 	: �
"
� �
+
� �
$"8 :9
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id : g
"g h
+i j
$"8 :=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id : k
"k l
+m n
$"8 ::
.INNER JOIN [TB_squad] S ON P.id_squads = S.id : h
"h i
+j k
$"8 :7
+LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id: e
"e f
)f g
;g h
return 
lista 
; 
} 
} 	
public 
	PessoaDto 
SelecionarPorId (
(( )
int) ,
id- /
)/ 0
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
	PessoaDto9 B
>B C
(C D
$"D F�
�SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P 	F �
"
� �
+
� �
$"C E9
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id E r
"r s
+t u
$"  C E=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id   E v
"  v w
+  x y
$"!!C E9
-LEFT JOIN [TB_squad] S ON P.id_squads = S.id !!E r
"!!r s
+!!t u
$"""C E8
,LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id ""E q
"""q r
+""s t
$"##C E
WHERE P.Id = @Id##E U
"##U V
,##V W
new##X [
{$$C D
Id%%G I
=%%J K
id%%L N
}&&C D
)&&D E
;&&E F
return'' 
obj'' 
;'' 
}(( 
})) 	
public++ 
	PessoaDto++ 
SelecionarPorEmail++ +
(+++ ,
string++, 2
email++3 8
)++8 9
{,, 	
using-- 
(-- 
var-- 

connection-- !
=--" #
new--$ '
SqlConnection--( 5
(--5 6
DbConnectionFactory--6 I
.--I J
SQLConnectionString--J ]
)--] ^
)--^ _
{.. 
var// 
obj// 
=// 

connection// $
.//$ %
QueryFirstOrDefault//% 8
<//8 9
	PessoaDto//9 B
>//B C
(//C D
$"//D F�
�SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P  	//F �
"
//� �
+
//� �
$"00C E9
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id 00E r
"00r s
+00t u
$"11C E=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id 11E v
"11v w
+11x y
$"22C E:
.INNER JOIN [TB_squad] S ON P.id_squads = S.Id 22E s
"22s t
+22u v
$"33C E8
,LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id 33E q
"33q r
+33s t
$"44C E"
WHERE P.email = @Email44E [
"44[ \
,44\ ]
new44^ a
{55C D
Email66G L
=66M N
email66O T
}77C D
)77D E
;77E F
return88 
obj88 
;88 
}99 
}:: 	
public<< 
IEnumerable<< 
<<< 
	PessoaDto<< $
><<$ % 
SelecionarPorIdSquad<<& :
(<<: ;
int<<; >
?<<> ?
id<<@ B
)<<B C
{== 	
using>> 
(>> 
var>> 

connection>> !
=>>" #
new>>$ '
SqlConnection>>( 5
(>>5 6
DbConnectionFactory>>6 I
.>>I J
SQLConnectionString>>J ]
)>>] ^
)>>^ _
{?? 
var@@ 
lista@@ 
=@@ 

connection@@ &
.@@& '
Query@@' ,
<@@, -
	PessoaDto@@- 6
>@@6 7
(@@7 8
$"@@8 :�
�SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P  	@@: �
"
@@� �
+
@@� �
$"AAC E9
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id AAE r
"AAr s
+AAt u
$"BBC E=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id BBE v
"BBv w
+BBx y
$"CCC E:
.INNER JOIN [TB_squad] S ON P.id_squads = S.Id CCE s
"CCs t
+CCu v
$"DDC E8
,LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id DDE q
"DDq r
+DDs t
$"EEC E
WHERE S.Id = @IdEEE U
"EEU V
,EEV W
newEEX [
{FFC D
IdGGG I
=GGJ K
idGGL N
}HHC D
)HHD E
;HHE F
returnII 
listaII 
;II 
}JJ 
}KK 	
publicMM 
IEnumerableMM 
<MM 
	PessoaDtoMM $
>MM$ %
SelecionarPorNomeMM& 7
(MM7 8
stringMM8 >
nomeMM? C
)MMC D
{NN 	
usingOO 
(OO 
varOO 

connectionOO !
=OO" #
newOO$ '
SqlConnectionOO( 5
(OO5 6
DbConnectionFactoryOO6 I
.OOI J
SQLConnectionStringOOJ ]
)OO] ^
)OO^ _
{PP 
varQQ 
listaQQ 
=QQ 

connectionQQ &
.QQ& '
QueryQQ' ,
<QQ, -
	PessoaDtoQQ- 6
>QQ6 7
(QQ7 8
$"QQ8 :�
�SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P   	QQ: �
"
QQ� �
+
QQ� �
$"RR7 99
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id RR9 f
"RRf g
+RRh i
$"SS7 9=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id SS9 j
"SSj k
+SSl m
$"TT7 99
-LEFT JOIN [TB_squad] S ON P.id_squads = S.Id TT9 f
"TTf g
+TTh i
$"UU7 98
,LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id UU9 e
"UUe f
+UUg h
$"VV7 9$
WHERE P.Nome LIKE @Nome VV9 Q
"VVQ R
,VVR S
newVVT W
{WW7 8
NomeXX; ?
=XX@ A
$strXXB E
+XXF G
nomeXXH L
+XXM N
$strXXO R
}YY7 8
)YY8 9
;YY9 :
return[[ 
lista[[ 
;[[ 
}\\ 
}]] 	
public__ 
	PessoaDto__ '
SelecionarPorNomeEspecifico__ 4
(__4 5
string__5 ;
nome__< @
)__@ A
{`` 	
usingaa 
(aa 
varaa 

connectionaa !
=aa" #
newaa$ '
SqlConnectionaa( 5
(aa5 6
DbConnectionFactoryaa6 I
.aaI J
SQLConnectionStringaaJ ]
)aa] ^
)aa^ _
{bb 
varcc 
objcc 
=cc 

connectioncc $
.cc$ %
QueryFirstOrDefaultcc% 8
<cc8 9
	PessoaDtocc9 B
>ccB C
(ccC D
$"ccD F{
nSELECT P.Id, P.Id_Papel, P.Nome, P.email, P.Ativo, P.id_squads , P.id_unidade, P.permissao FROM [TB_pessoa] P 	ccF �
"
cc� �
+
cc� �
$"ddD F 
WHERE P.Nome = @NomeddF Z
"ddZ [
,dd[ \
newdd] `
{eeD E
NomeffH L
=ffM N
nomeffO S
}ggD E
)ggE F
;ggF G
returnhh 
objhh 
;hh 
}ii 
}jj 	
publicll 
intll 
Inserirll 
(ll 
Pessoall !
entityll" (
)ll( )
{mm 	
usingnn 
(nn 
varnn 

connectionnn !
=nn" #
newnn$ '
SqlConnectionnn( 5
(nn5 6
DbConnectionFactorynn6 I
.nnI J
SQLConnectionStringnnJ ]
)nn] ^
)nn^ _
{oo 
returnpp 

connectionpp !
.pp! "
QuerySinglepp" -
<pp- .
intpp. 1
>pp1 2
(pp2 3
$"pp3 5
DECLARE @Id int;pp5 E
"ppE F
+ppG H
$"qq3 5p
cINSERT INTO [TB_pessoa] (Id_papel, Nome, Email, password, ativo, Id_squads, Id_unidade, Permissao) 	qq5 �
"
qq� �
+
qq� �
$"rr3 5
VALUES(@idPapel, rr5 F
"rrF G
+rrH I
$"ss3 5
@nome, ss5 <
"ss< =
+ss> ?
$"tt3 5
@email, tt5 =
"tt= >
+tt? @
$"uu3 5
@senha, uu5 =
"uu= >
+uu? @
$"vv3 5
@ativo,vv5 <
"vv< =
+vv> ?
$"ww3 5
	@idSquad,ww5 >
"ww> ?
+ww@ A
$"xx3 5
@idUnidade,xx5 @
"xx@ A
+xxB C
$"yy3 5
@permissao); yy5 B
"yyB C
+yyD E
$"zz3 5'
SET @Id = SCOPE_IDENTITY();zz5 P
"zzP Q
+zzR S
$"{{3 5

SELECT @Id{{5 ?
"{{? @
,{{@ A
new{{B E
{||3 4
idPapel}}7 >
=}}? @
entity}}A G
.}}G H
Id_papel}}H P
,}}P Q
nome~~7 ;
=~~< =
entity~~> D
.~~D E
Nome~~E I
,~~I J
email7 <
== >
entity? E
.E F
EmailF K
,K L
senha
��7 <
=
��= >
entity
��? E
.
��E F
Senha
��F K
,
��K L
ativo
��7 <
=
��= >
entity
��? E
.
��E F
Ativo
��F K
,
��K L
idSquad
��7 >
=
��? @
entity
��A G
.
��G H
Id_squad
��H P
,
��P Q
	idUnidade
��7 @
=
��A B
entity
��C I
.
��I J

Id_unidade
��J T
,
��T U
	permissao
��7 @
=
��A B
entity
��C I
.
��I J
	Permissao
��J S
}
��3 4
)
��4 5
;
��5 6
}
�� 
}
�� 	
public
�� 
void
�� 
Alterar
�� 
(
�� 
Pessoa
�� "
entity
��# )
)
��) *
{
�� 	
using
�� 
(
�� 
var
�� 

connection
�� !
=
��" #
new
��$ '
SqlConnection
��( 5
(
��5 6!
DbConnectionFactory
��6 I
.
��I J!
SQLConnectionString
��J ]
)
��] ^
)
��^ _
{
�� 

connection
�� 
.
�� 
Execute
�� "
(
��" #
$"
��# %!
UPDATE [TB_pessoa] 
��% 8
"
��8 9
+
��: ;
$"
�� !&
SET Id_papel = @idPapel,
��! 9
"
��9 :
+
��; <
$"
�� !
Nome = @nome,
��! .
"
��. /
+
��0 1
$"
�� !
Email = @email,
��! 0
"
��0 1
+
��2 3
$"
�� !
Ativo = @ativo,
��! 0
"
��0 1
+
��2 3
$"
�� !#
Id_squads = @idSquad,
��! 6
"
��6 7
+
��8 9
$"
�� !&
Id_unidade = @idUnidade,
��! 9
"
��9 :
+
��; <
$"
�� !%
Permissao = @permissao 
��! 8
"
��8 9
+
��: ;
$"
�� !
WHERE Id = @id
��! /
"
��/ 0
,
��0 1
new
��2 5
{
��  
idPapel
��# *
=
��+ ,
entity
��- 3
.
��3 4
Id_papel
��4 <
,
��< =
nome
��# '
=
��( )
entity
��* 0
.
��0 1
Nome
��1 5
,
��5 6
email
��# (
=
��) *
entity
��+ 1
.
��1 2
Email
��2 7
,
��7 8
ativo
��# (
=
��) *
entity
��+ 1
.
��1 2
Ativo
��2 7
,
��7 8
idSquad
��# *
=
��+ ,
entity
��- 3
.
��3 4
Id_squad
��4 <
,
��< =
	idUnidade
��# ,
=
��- .
entity
��/ 5
.
��5 6

Id_unidade
��6 @
,
��@ A
	permissao
��# ,
=
��- .
entity
��/ 5
.
��5 6
	Permissao
��6 ?
,
��? @
id
��# %
=
��& '
entity
��( .
.
��. /
Id
��/ 1
}
��  
)
��  !
;
��! "
}
�� 
}
�� 	
public
�� 
void
�� #
AtivarDesativarPessoa
�� )
(
��) *
int
��* -
id
��. 0
,
��0 1
bool
��2 6
ativo
��7 <
)
��< =
{
�� 	
using
�� 
(
�� 
var
�� 

connection
�� !
=
��" #
new
��$ '
SqlConnection
��( 5
(
��5 6!
DbConnectionFactory
��6 I
.
��I J!
SQLConnectionString
��J ]
)
��] ^
)
��^ _
{
�� 

connection
�� 
.
�� 
Execute
�� "
(
��" #
$"
��# % 
UPDATE [TB_pessoa]
��% 7
"
��7 8
+
��9 :
$"
��# %!
SET Ativo = @Ativo 
��% 8
"
��8 9
+
��: ;
$"
��# %
WHERE Id = @Id
��% 3
"
��3 4
,
��5 6
new
��7 :
{
��# $
Ativo
��' ,
=
��- .
ativo
��/ 4
,
��4 5
Id
��' )
=
��* +
id
��, .
}
��# $
)
��$ %
;
��% &
}
�� 
}
�� 	
}
�� 
}�� �q
BC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\SquadRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{		 
public

 

class

 
SquadRepositorio

 !
:

" #
ISquadRepositorio

$ 5
{ 
public 
IEnumerable 
< 
SquadDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -
SquadDto- 5
>5 6
(6 7
$"7 9�
xSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S 	9 �
"
� �
+
� �
$"7 98
,LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id 9 e
"e f
+g h
$"7 98
,LEFT JOIN TB_mentor M ON S.id_mentor = M.id 9 e
"e f
+g h
$"7 98
,LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id 9 e
"e f
)f g
;g h
return 
lista 
; 
} 
} 	
public 
SquadDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
SquadDto9 A
>A B
(B C
$"C E�
xSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S 	E �
"
� �
+
� �
$"C E8
,LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id E q
"q r
+s t
$"C E8
,LEFT JOIN TB_mentor M ON S.id_mentor = M.id E q
"q r
+s t
$"C E8
,LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id E q
"q r
+s t
$"  C E
WHERE S.Id = @Id  E U
"  U V
,  V W
new  X [
{!!C D
Id""G I
=""J K
id""L N
}##C D
)##D E
;##E F
return$$ 
obj$$ 
;$$ 
}%% 
}&& 	
public(( 
IEnumerable(( 
<(( 
SquadDto(( $
>(($ %
SelecionarPorNome((& 7
(((7 8
string((8 >
nome((? C
)((C D
{)) 	
using** 
(** 
var** 

connection** !
=**" #
new**$ '
SqlConnection**( 5
(**5 6
DbConnectionFactory**6 I
.**I J
SQLConnectionString**J ]
)**] ^
)**^ _
{++ 
var,, 
lista,, 
=,, 

connection,, &
.,,& '
Query,,' ,
<,,, -
SquadDto,,- 5
>,,5 6
(,,6 7
$",,7 9�
xSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S 	,,9 �
"
,,� �
+
,,� �
$"--7 98
,LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id --9 e
"--e f
+--g h
$"..7 98
,LEFT JOIN TB_mentor M ON S.id_mentor = M.id ..9 e
"..e f
+..g h
$"//7 98
,LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id //9 e
"//e f
+//g h
$"007 9$
WHERE S.Nome LIKE @Nome 009 Q
"00Q R
,00R S
new00T W
{117 8
Nome22; ?
=22@ A
$str22B E
+22F G
nome22H L
+22M N
$str22O R
}337 8
)338 9
;339 :
return55 
lista55 
;55 
}66 
}77 	
public99 
SquadDto99 '
SelecionarPorNomeEspecifico99 4
(994 5
string995 ;
nome99< @
)99@ A
{:: 	
using;; 
(;; 
var;; 

connection;; !
=;;" #
new;;$ '
SqlConnection;;( 5
(;;5 6
DbConnectionFactory;;6 I
.;;I J
SQLConnectionString;;J ]
);;] ^
);;^ _
{<< 
var== 
obj== 
=== 

connection== $
.==$ %
QueryFirstOrDefault==% 8
<==8 9
SquadDto==9 A
>==A B
(==B C
$"==C E�
xSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S 	==E �
"
==� �
+
==� �
$">>C E8
,LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id >>E q
">>q r
+>>s t
$"??C E8
,LEFT JOIN TB_mentor M ON S.id_mentor = M.id ??E q
"??q r
+??s t
$"@@C E8
,LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id @@E q
"@@q r
+@@s t
$"AAC E!
WHERE S.Nome = @Nome AAE Z
"AAZ [
,AA[ \
newAA] `
{BBC D
NomeCCG K
=CCL M
nomeCCN R
}DDC D
)DDD E
;DDE F
returnEE 
objEE 
;EE 
}FF 
}GG 	
publicII 
IEnumerableII 
<II 
SquadDtoII $
>II$ % 
SelecionarPorIdTriboII& :
(II: ;
intII; >
idII? A
)IIA B
{JJ 	
usingKK 
(KK 
varKK 

connectionKK !
=KK" #
newKK$ '
SqlConnectionKK( 5
(KK5 6
DbConnectionFactoryKK6 I
.KKI J
SQLConnectionStringKKJ ]
)KK] ^
)KK^ _
{LL 
varMM 
listaMM 
=MM 

connectionMM &
.MM& '
QueryMM' ,
<MM, -
SquadDtoMM- 5
>MM5 6
(MM6 7
$"MM7 9�
xSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S 	MM9 �
"
MM� �
+
MM� �
$"NN7 99
-INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id NN9 f
"NNf g
+NNh i
$"OO7 98
,LEFT JOIN TB_mentor M ON S.id_mentor = M.id OO9 e
"OOe f
+OOg h
$"PP7 98
,LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id PP9 e
"PPe f
+PPg h
$"QQ7 9#
WHERE S.Id_Tribo = @Id QQ9 P
"QQP Q
,QQQ R
newQQS V
{RR7 8
IdSS; =
=SS> ?
idSS@ B
}TT7 8
)TT8 9
;TT9 :
returnUU 
listaUU 
;UU 
}VV 
}WW 	
publicYY 
IEnumerableYY 
<YY 
SquadDtoYY $
>YY$ %$
SelecionarSquadsSemTriboYY& >
(YY> ?
)YY? @
{ZZ 	
using[[ 
([[ 
var[[ 

connection[[ !
=[[" #
new[[$ '
SqlConnection[[( 5
([[5 6
DbConnectionFactory[[6 I
.[[I J
SQLConnectionString[[J ]
)[[] ^
)[[^ _
{\\ 
var]] 
lista]] 
=]] 

connection]] &
.]]& '
Query]]' ,
<]], -
SquadDto]]- 5
>]]5 6
(]]6 7
$"]]7 9�
xSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S 	]]9 �
"
]]� �
+
]]� �
$"^^7 98
,LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id ^^9 e
"^^e f
+^^g h
$"__7 98
,LEFT JOIN TB_mentor M ON S.id_mentor = M.id __9 e
"__e f
+__g h
$"``7 98
,LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id ``9 e
"``e f
+``g h
$"aa7 9$
WHERE S.Id_Tribo IS NULLaa9 Q
"aaQ R
)aaR S
;aaS T
returnbb 
listabb 
;bb 
}cc 
}dd 	
publicff 
intff 
Inserirff 
(ff 
Squadff  
entityff! '
)ff' (
{gg 	
usinghh 
(hh 
varhh 

connectionhh !
=hh" #
newhh$ '
SqlConnectionhh( 5
(hh5 6
DbConnectionFactoryhh6 I
.hhI J
SQLConnectionStringhhJ ]
)hh] ^
)hh^ _
{ii 
returnjj 

connectionjj !
.jj! "
QuerySinglejj" -
<jj- .
intjj. 1
>jj1 2
(jj2 3
$"jj3 5
DECLARE @Id int;jj5 E
"jjE F
+jjG H
$"kk3 5F
:INSERT INTO [TB_squad] (Id_tribo, Nome, Id_mentor, Ativo) kk5 o
"kko p
+kkq r
$"ll3 5
VALUES(@idTribo,ll5 E
"llE F
+llG H
$"mm3 5
@nome,mm5 ;
"mm; <
+mm= >
$"nn3 5

@IdMentor,nn5 ?
"nn? @
+nnA B
$"oo3 5
@ativo);oo5 =
"oo= >
+oo? @
$"pp3 5'
SET @Id = SCOPE_IDENTITY();pp5 P
"ppP Q
+ppR S
$"qq3 5

SELECT @Idqq5 ?
"qq? @
,qq@ A
newqqB E
{rr3 4
idTriboss7 >
=ss? @
entityssA G
.ssG H
Id_tribossH P
,ssP Q
nomett7 ;
=tt< =
entitytt> D
.ttD E
NomettE I
,ttI J
IdMentoruu7 ?
=uu@ A
entityuuB H
.uuH I
	Id_MentoruuI R
,uuR S
ativovv7 <
=vv= >
entityvv? E
.vvE F
AtivovvF K
}ww3 4
)ww4 5
;ww5 6
}xx 
}yy 	
public{{ 
void{{ 
Alterar{{ 
({{ 
Squad{{ !
entity{{" (
){{( )
{|| 	
using}} 
(}} 
var}} 

connection}} !
=}}" #
new}}$ '
SqlConnection}}( 5
(}}5 6
DbConnectionFactory}}6 I
.}}I J
SQLConnectionString}}J ]
)}}] ^
)}}^ _
{~~ 

connection 
. 
Execute "
(" #
$"# %
UPDATE [TB_squad] % 7
"7 8
+9 :
$"
��& (
SET Nome = @nome,
��( 9
"
��9 :
+
��; <
$"
��& (&
 Id_mentor = @idMentor, 
��( @
"
��@ A
+
��B C
$"
��& ("
Id_tribo = @idTribo 
��( <
"
��< =
+
��> ?
$"
��& (
WHERE Id = @id
��( 6
"
��6 7
,
��7 8
new
��9 <
{
��& '
nome
��* .
=
��/ 0
entity
��1 7
.
��7 8
Nome
��8 <
,
��< =
idMentor
��* 2
=
��3 4
entity
��5 ;
.
��; <
	Id_Mentor
��< E
,
��E F
idTribo
��* 1
=
��2 3
entity
��4 :
.
��: ;
Id_tribo
��; C
,
��C D
id
��* ,
=
��- .
entity
��/ 5
.
��5 6
Id
��6 8
}
��& '
)
��' (
;
��( )
}
�� 
}
�� 	
public
�� 
void
�� 
AlterarStatus
�� !
(
��! "
Squad
��" '
entity
��( .
)
��. /
{
�� 	
using
�� 
(
�� 
var
�� 

connection
�� !
=
��" #
new
��$ '
SqlConnection
��( 5
(
��5 6!
DbConnectionFactory
��6 I
.
��I J!
SQLConnectionString
��J ]
)
��] ^
)
��^ _
{
�� 

connection
�� 
.
�� 
Execute
�� "
(
��" #
$"
��# % 
UPDATE [TB_squad] 
��% 7
"
��7 8
+
��9 :
$"
��# %"
SET Ativo = @ativo, 
��% 9
"
��9 :
+
��; <
$"
��# %
Nome = @nome,
��% 2
"
��2 3
+
��4 5
$"
��# %#
Id_mentor = @idMentor
��% :
"
��: ;
+
��< =
$"
��# %
WHERE Id = @id
��% 3
"
��3 4
,
��4 5
new
��6 9
{
��# $
ativo
��' ,
=
��- .
entity
��/ 5
.
��5 6
Ativo
��6 ;
,
��; <
nome
��' +
=
��, -
entity
��. 4
.
��4 5
Nome
��5 9
,
��9 :
idMentor
��' /
=
��0 1
entity
��2 8
.
��8 9
	Id_Mentor
��9 B
,
��B C
id
��' )
=
��* +
entity
��, 2
.
��2 3
Id
��3 5
}
��# $
)
��$ %
;
��% &
}
�� 
}
�� 	
public
�� 
void
�� "
AtivarDesativarSquad
�� (
(
��( )
int
��) ,
id
��- /
,
��/ 0
bool
��1 5
ativo
��6 ;
)
��; <
{
�� 	
using
�� 
(
�� 
var
�� 

connection
�� !
=
��" #
new
��$ '
SqlConnection
��( 5
(
��5 6!
DbConnectionFactory
��6 I
.
��I J!
SQLConnectionString
��J ]
)
��] ^
)
��^ _
{
�� 

connection
�� 
.
�� 
Execute
�� "
(
��" #
$"
��# %
UPDATE [TB_squad]
��% 6
"
��6 7
+
��8 9
$"
��# %!
SET Ativo = @Ativo 
��% 8
"
��8 9
+
��: ;
$"
��# %
WHERE Id = @Id
��% 3
"
��3 4
,
��4 5
new
��6 9
{
��# $
Ativo
��' ,
=
��- .
ativo
��/ 4
,
��4 5
Id
��' )
=
��* +
id
��, .
}
��# $
)
��$ %
;
��% &
}
�� 
}
�� 	
}
�� 
}�� �Q
BC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\TriboRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{		 
public

 

class

 
TriboRepositorio

 !
:

" #
ITriboRepositorio

$ 5
{ 
public 
IEnumerable 
< 
TriboDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -
TriboDto- 5
>5 6
(6 7
$"7 9d
WSELECT T.id, T.nome, T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T 	9 �
"
� �
+
� �
$"7 98
,LEFT JOIN TB_mentor M ON T.id_mentor = M.id 9 e
"e f
+g h
$"7 9%
LEFT JOIN TB_pessoa P ON 9 R
"R S
+T U
$"7 9
M.id_pessoa = P.id9 K
"K L
)L M
;M N
return 
lista 
; 
} 
} 	
public 
TriboDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
TriboDto9 A
>A B
(B C
$"C Ee
XSELECT T.id, T.nome , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T 	E �
"
� �
+
� �
$"C E8
,LEFT JOIN TB_mentor M ON T.id_mentor = M.id E q
"q r
+s t
$"C E%
LEFT JOIN TB_pessoa P ON E ^
"^ _
+` a
$"C E/
#M.id_pessoa = P.id WHERE T.Id = @IdE h
"h i
,i j
newk n
{  C D
Id!!G I
=!!J K
id!!L N
}""C D
)""D E
;""E F
return## 
obj## 
;## 
}$$ 
}%% 	
public'' 
TriboDto'' '
SelecionarPorNomeEspecifico'' 4
(''4 5
string''5 ;
nome''< @
)''@ A
{(( 	
using)) 
()) 
var)) 

connection)) !
=))" #
new))$ '
SqlConnection))( 5
())5 6
DbConnectionFactory))6 I
.))I J
SQLConnectionString))J ]
)))] ^
)))^ _
{** 
var++ 
obj++ 
=++ 

connection++ $
.++$ %
QueryFirstOrDefault++% 8
<++8 9
TriboDto++9 A
>++A B
(++B C
$"++C Ee
XSELECT T.id, T.nome , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T 	++E �
"
++� �
+
++� �
$",,C E8
,LEFT JOIN TB_mentor M ON T.id_mentor = M.id ,,E q
",,q r
+,,s t
$"--C E%
LEFT JOIN TB_pessoa P ON --E ^
"--^ _
+--` a
$"..C E3
'M.id_pessoa = P.id WHERE T.Nome = @Nome..E l
"..l m
,..m n
new..o r
{//C D
Nome00G K
=00L M
nome00N R
}11C D
)11D E
;11E F
return22 
obj22 
;22 
}33 
}44 	
public66 
IEnumerable66 
<66 
TriboDto66 $
>66$ %
SelecionarPorNome66& 7
(667 8
string668 >
nome66? C
)66C D
{77 	
using88 
(88 
var88 

connection88 !
=88" #
new88$ '
SqlConnection88( 5
(885 6
DbConnectionFactory886 I
.88I J
SQLConnectionString88J ]
)88] ^
)88^ _
{99 
var:: 
lista:: 
=:: 

connection:: &
.::& '
Query::' ,
<::, -
TriboDto::- 5
>::5 6
(::6 7
$"::7 9e
XSELECT T.id, T.nome , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T 	::9 �
"
::� �
+
::� �
$";;7 98
,LEFT JOIN TB_mentor M ON T.id_mentor = M.id ;;9 e
";;e f
+;;g h
$"<<7 9%
LEFT JOIN TB_pessoa P ON <<9 R
"<<R S
+<<T U
$"==7 96
*M.id_pessoa = P.id WHERE T.Nome LIKE @Nome==9 c
"==c d
,==e f
new==g j
{>>7 8
Nome??; ?
=??@ A
$str??B E
+??F G
nome??H L
+??M N
$str??O R
}@@7 8
)@@8 9
;@@9 :
returnBB 
listaBB 
;BB 
}CC 
}DD 	
publicFF 
intFF 
InserirFF 
(FF 
TriboFF  
entityFF! '
)FF' (
{GG 	
usingHH 
(HH 
varHH 

connectionHH !
=HH" #
newHH$ '
SqlConnectionHH( 5
(HH5 6
DbConnectionFactoryHH6 I
.HHI J
SQLConnectionStringHHJ ]
)HH] ^
)HH^ _
{II 
returnJJ 

connectionJJ !
.JJ! "
QuerySingleJJ" -
<JJ- .
intJJ. 1
>JJ1 2
(JJ2 3
$"JJ3 5
DECLARE @Id int;JJ5 E
"JJE F
+JJG H
$"KK3 5<
0INSERT INTO [TB_tribo] (Nome, Id_mentor, Ativo) KK5 e
"KKe f
+KKg h
$"LL3 5
VALUES(@nome, LL5 C
"LLC D
+LLE F
$"MM3 5
 @idMentor, MM5 A
"MMA B
+MMC D
$"NN3 5
@ativo);NN5 =
"NN= >
+NN? @
$"OO3 5'
SET @Id = SCOPE_IDENTITY();OO5 P
"OOP Q
+OOR S
$"PP3 5

SELECT @IdPP5 ?
"PP? @
,PP@ A
newPPB E
{QQ3 4
nomeRR7 ;
=RR< =
entityRR> D
.RRD E
NomeRRE I
,RRI J
idMentorSS7 ?
=SS@ A
entitySSB H
.SSH I
	Id_MentorSSI R
,SSR S
ativoTT7 <
=TT= >
entityTT? E
.TTE F
AtivoTTF K
}UU3 4
)UU4 5
;UU5 6
}VV 
}WW 	
publicYY 
voidYY 
AlterarNomeYY 
(YY  
TriboYY  %
entityYY& ,
)YY, -
{ZZ 	
using[[ 
([[ 
var[[ 

connection[[ !
=[[" #
new[[$ '
SqlConnection[[( 5
([[5 6
DbConnectionFactory[[6 I
.[[I J
SQLConnectionString[[J ]
)[[] ^
)[[^ _
{\\ 

connection]] 
.]] 
Execute]] "
(]]" #
$"]]# %
UPDATE [TB_tribo] ]]% 7
"]]7 8
+]]9 :
$"^^& (
SET Nome = @nome ^^( 9
"^^9 :
+^^; <
$"__& (
WHERE Id = @id__( 6
"__6 7
,__7 8
new__9 <
{``& '
nomeaa* .
=aa/ 0
entityaa1 7
.aa7 8
Nomeaa8 <
,aa< =
idbb* ,
=bb- .
entitybb/ 5
.bb5 6
Idbb6 8
}cc& '
)cc' (
;cc( )
}dd 
}ee 	
publicgg 
voidgg 
AlterarStatusgg !
(gg! "
Tribogg" '
entitygg( .
)gg. /
{hh 	
usingii 
(ii 
varii 

connectionii !
=ii" #
newii$ '
SqlConnectionii( 5
(ii5 6
DbConnectionFactoryii6 I
.iiI J
SQLConnectionStringiiJ ]
)ii] ^
)ii^ _
{jj 

connectionkk 
.kk 
Executekk "
(kk" #
$"kk# %
UPDATE [TB_tribo] kk% 7
"kk7 8
+kk9 :
$"ll# % 
SET Ativo = @ativo, ll% 9
"ll9 :
+ll; <
$"mm# %
Nome = @nome, mm% 3
"mm3 4
+mm5 6
$"nn# %"
Id_Mentor = @idMentor nn% ;
"nn; <
+nn= >
$"oo# %
WHERE Id = @idoo% 3
"oo3 4
,oo4 5
newoo6 9
{pp# $
ativoqq' ,
=qq- .
entityqq/ 5
.qq5 6
Ativoqq6 ;
,qq; <
nomerr' +
=rr, -
entityrr. 4
.rr4 5
Nomerr5 9
,rr9 :
idMentorss' /
=ss0 1
entityss2 8
.ss8 9
	Id_Mentorss9 B
,ssB C
idtt' )
=tt* +
entitytt, 2
.tt2 3
Idtt3 5
}uu# $
)uu$ %
;uu% &
}vv 
}ww 	
public~~ 
void~~  
AtivarDesativarTribo~~ (
(~~( )
int~~) ,
id~~- /
,~~/ 0
bool~~1 5
ativo~~6 ;
)~~; <
{ 	
using
�� 
(
�� 
var
�� 

connection
�� !
=
��" #
new
��$ '
SqlConnection
��( 5
(
��5 6!
DbConnectionFactory
��6 I
.
��I J!
SQLConnectionString
��J ]
)
��] ^
)
��^ _
{
�� 

connection
�� 
.
�� 
Execute
�� "
(
��" #
$"
��# %
UPDATE [TB_tribo]
��% 6
"
��6 7
+
��8 9
$"
��# %!
SET Ativo = @Ativo 
��% 8
"
��8 9
+
��: ;
$"
��# %
WHERE Id = @Id
��% 3
"
��3 4
,
��4 5
new
��6 9
{
��# $
Ativo
��' ,
=
��- .
ativo
��/ 4
,
��4 5
Id
��' )
=
��* +
id
��, .
}
��# $
)
��$ %
;
��% &
}
�� 
}
�� 	
}
�� 
}�� �

DC:\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\UnidadeRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public		 

class		 
UnidadeRepositorio		 #
:		$ %
IUnidadeRepositorio		& 9
{

 
public 
IEnumerable 
< 

UnidadeDto %
>% &

Selecionar' 1
(1 2
)2 3
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -

UnidadeDto- 7
>7 8
(8 9
$"9 ;�
�SELECT U.id, U.nome, E.pais, E.estado, E.cidade, E.bairro, E.logradouro, E.complemento, E.numero, E.codigo_postal FROM TB_unidade U 	; �
"
� �
+
� �
$"9 ;6
*INNER JOIN [TB_endereco] E ON U.id = E.id ; e
"e f
)f g
;g h
return 
lista 
; 
} 
} 	
} 
} 