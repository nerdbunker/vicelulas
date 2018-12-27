¿
nC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Abstracao\IRepositorioBase.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Abstra√ß√£o "
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
 
void 
Deletar 
( 
int 
id 
) 
; 
} 
} ï
tC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Configuracao\DbConnectionFactory.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Configura√ß√£o %
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
$str	4 Ö
;
Ö Ü
} 
} µ*
eC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\PessoaRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public		 

class		 
PessoaRepositorio		 "
{

 
public 
IEnumerable 
< 
	PessoaDto $
>$ %

Selecionar& 0
(0 1
)1 2
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
<, -
	PessoaDto- 6
>6 7
(7 8
$"8 :ô
ãSELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P 	: ≈
"
≈ ∆
+
« »
$"8 ::
. INNER JOIN [TB_papel] C ON P.id_papel = C.Id : h
"h i
+j k
$"8 :>
2 INNER JOIN [TB_unidade] U ON P.id_unidade = U.id : l
"l m
)m n
;n o
return 
lista 
; 
} 
} 	
public 
	PessoaDto 
SelecionarPorId (
(( )
int) ,
id- /
)/ 0
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
	PessoaDto9 B
>B C
(C D
$"D Fô
ãSELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P 	F —
"
— “
+
” ‘
$"C E9
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id E r
"r s
+t u
$"C E=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id E v
"v w
+w x
$"C E
WHERE P.Id = E R
{R S
idS U
}U V
"V W
)W X
;X Y
return 
obj 
; 
}   
}!! 	
public## 
IEnumerable## 
<## 
	PessoaDto## $
>##$ % 
SelecionarPorIdSquad##& :
(##: ;
int##; >
id##? A
)##A B
{$$ 	
using%% 
(%% 
var%% 

connection%% !
=%%" #
new%%$ '
SqlConnection%%( 5
(%%5 6
DbConnectionFactory%%6 I
.%%I J
SQLConnectionString%%J ]
)%%] ^
)%%^ _
{&& 
var'' 
lista'' 
='' 

connection'' &
.''& '
Query''' ,
<'', -
	PessoaDto''- 6
>''6 7
(''7 8
$"''8 :ô
ãSELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P 	'': ≈
"
''≈ ∆
+
''« »
$"((C E9
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id ((E r
"((r s
+((t u
$"))C E=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id ))E v
"))v w
+))x y
$"**C E:
.INNER JOIN [TB_squad] S ON P.id_squads = S.Id **E s
"**s t
+**t u
$"++C E
WHERE S.Id = ++E R
{++R S
id++S U
}++U V
"++V W
)++W X
;++X Y
return,, 
lista,, 
;,, 
}-- 
}.. 	
public11 
IEnumerable11 
<11 
	PessoaDto11 $
>11$ %
SelecionarPorNome11& 7
(117 8
string118 >
nome11? C
)11C D
{22 	
using33 
(33 
var33 

connection33 !
=33" #
new33$ '
SqlConnection33( 5
(335 6
DbConnectionFactory336 I
.33I J
SQLConnectionString33J ]
)33] ^
)33^ _
{44 
var55 
lista55 
=55 

connection55 &
.55& '
Query55' ,
<55, -
	PessoaDto55- 6
>556 7
(557 8
$"558 :ô
ãSELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P 	55: ≈
"
55≈ ∆
+
55« »
$"667 99
-INNER JOIN [TB_papel] C ON P.id_papel = C.Id 669 f
"66f g
+66h i
$"777 9=
1INNER JOIN [TB_unidade] U ON P.id_unidade = U.id 779 j
"77j k
+77l m
$"887 9 
WHERE P.Nome LIKE '%889 M
{88M N
nome88N R
}88R S
%'88S U
"88U V
)88V W
;88W X
return:: 
lista:: 
;:: 
};; 
}<< 	
}== 
}>> õ$
dC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\SquadRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public		 

class		 
SquadRepositorio		 !
{

 
public 
IEnumerable 
< 
SquadDto #
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
SquadDto- 5
>5 6
(6 7
$"7 9\
OSELECT S.Id, S.Id_Tribo,T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S 	9 à
"
à â
+
ä ã
$"7 99
-INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id 9 f
"f g
)g h
;h i
return 
lista 
; 
} 
} 	
public 
SquadDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
SquadDto9 A
>A B
(B C
$"C E\
OSELECT S.Id, S.Id_Tribo,T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S 	E î
"
î ï
+
ï ñ
$"C E9
-INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id E r
"r s
+s t
$"C E
WHERE S.Id = E R
{R S
idS U
}U V
"V W
)W X
;X Y
return 
obj 
; 
} 
} 	
public   
IEnumerable   
<   
SquadDto   #
>  # $
SelecionarPorNome  % 6
(  6 7
string  7 =
nome  > B
)  B C
{!! 	
using"" 
("" 
var"" 

connection"" !
=""" #
new""$ '
SqlConnection""( 5
(""5 6
DbConnectionFactory""6 I
.""I J
SQLConnectionString""J ]
)""] ^
)""^ _
{## 
var$$ 
lista$$ 
=$$ 

connection$$ &
.$$& '
Query$$' ,
<$$, -
SquadDto$$- 5
>$$5 6
($$6 7
$"$$7 9]
PSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S 	$$9 â
"
$$â ä
+
$$ä ã
$"%%7 99
-INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id %%9 f
"%%f g
+%%g h
$"&&7 9 
WHERE S.Nome LIKE '%&&9 M
{&&M N
nome&&N R
}&&R S
%'&&S U
"&&U V
)&&V W
;&&W X
return(( 
lista(( 
;(( 
})) 
}** 	
public,, 
IEnumerable,, 
<,, 
SquadDto,, #
>,,# $ 
SelecionarPorIdTribo,,% 9
(,,9 :
int,,: =
id,,> @
),,@ A
{-- 	
using.. 
(.. 
var.. 

connection.. !
=.." #
new..$ '
SqlConnection..( 5
(..5 6
DbConnectionFactory..6 I
...I J
SQLConnectionString..J ]
)..] ^
)..^ _
{// 
var00 
lista00 
=00 

connection00 &
.00& '
Query00' ,
<00, -
SquadDto00- 5
>005 6
(006 7
$"007 9]
PSELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S 	009 â
"
00â ä
+
00ä ã
$"117 99
-INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id 119 f
"11f g
+11h i
$"227 9
WHERE S.Id_Tribo = 229 L
{22L M
id22M O
}22O P
"22P Q
)22Q R
;22R S
return33 
lista33 
;33 
}44 
}55 	
}66 
}77 °
dC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\TriboRepositorio.cs
	namespace 	
	Vicelulas
 
. 
Dado 
{ 
public		 

class		 
TriboRepositorio		 !
{

 
public 
IEnumerable 
< 
TriboDto #
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
TriboDto- 5
>5 6
(6 7
$"7 9:
.SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T9 g
"g h
)h i
;i j
return 
lista 
; 
} 
} 	
public 
TriboDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
TriboDto9 A
>A B
(B C
$"C EI
<SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T WHERE T.Id = 	E Å
{
Å Ç
id
Ç Ñ
}
Ñ Ö
"
Ö Ü
)
Ü á
;
á à
return 
obj 
; 
} 
} 	
public 
IEnumerable 
< 
TriboDto #
># $
SelecionarPorNome% 6
(6 7
string7 =
nome> B
)B C
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{   
var!! 
lista!! 
=!! 

connection!! &
.!!& '
Query!!' ,
<!!, -
TriboDto!!- 5
>!!5 6
(!!6 7
$"!!7 9O
CSELECT T.Id, T.Nome, T.Ativo FROM [TB_tribo] T WHERE T.Nome LIKE '%!!9 |
{!!| }
nome	!!} Å
}
!!Å Ç
%'
!!Ç Ñ
"
!!Ñ Ö
)
!!Ö Ü
;
!!Ü á
return## 
lista## 
;## 
}$$ 
}%% 	
}&& 
}'' 