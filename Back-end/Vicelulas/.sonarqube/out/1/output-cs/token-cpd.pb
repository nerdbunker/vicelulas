¬
pC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Abstra√ß√£o\IRepositorioBase.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Abstra√ß√£o "
{ 
internal 
	interface 
IRepositorioBase '
<' (
T( )
>) *
where+ 0
T1 2
:3 4
class5 :
{ 
IEnumerable		 
<		 
T		 
>		 

Selecionar		 !
(		! "
)		" #
;		# $
T

 	
SelecionarPorId


 
(

 
int

 
id

  
)

  !
;

! "
int 
Inserir 
( 
T 
entity 
) 
; 
void 
Alterar 
( 
T 
entity 
) 
; 
void 
Deletar 
( 
int 
id 
) 
; 
} 
} ó
vC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Configura√ß√£o\DbConnectionFactory.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Configura√ß√£o %
{ 
internal 
static 
class 
DbConnectionFactory -
{ 
public		 
static		 
string		 
SQLConnectionString		 0
=>		1 3
$str			4 Ö
;
		Ö Ü
}

 
} °
dC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\TriboRepositorio.cs
	namespace		 	
	Vicelulas		
 
.		 
Dado		 
{

 
public 

class 
TriboRepositorio !
{ 
public 
IEnumerable 
< 
TriboDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
using 
( 
var 

connection !
=" #
new$ '
SqlConnection( 5
(5 6
DbConnectionFactory6 I
.I J
SQLConnectionStringJ ]
)] ^
)^ _
{ 
var 
lista 
= 

connection &
.& '
Query' ,
<, -
TriboDto- 5
>5 6
(6 7
$"7 9:
.SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T9 g
"g h
)h i
;i j
return 
lista 
; 
} 
} 	
public 
TriboDto 
SelecionarPorId '
(' (
int( +
id, .
). /
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
{ 
var 
obj 
= 

connection $
.$ %
QueryFirstOrDefault% 8
<8 9
TriboDto9 A
>A B
(B C
$"C EI
<SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T WHERE T.Id = 	E Å
{
Å Ç
id
Ç Ñ
}
Ñ Ö
"
Ö Ü
)
Ü á
;
á à
return 
obj 
; 
} 
} 	
public 
IEnumerable 
< 
TriboDto #
># $
SelecionarPorNome% 6
(6 7
string7 =
nome> B
)B C
{   	
using!! 
(!! 
var!! 

connection!! !
=!!" #
new!!$ '
SqlConnection!!( 5
(!!5 6
DbConnectionFactory!!6 I
.!!I J
SQLConnectionString!!J ]
)!!] ^
)!!^ _
{"" 
var## 
lista## 
=## 

connection## &
.##& '
Query##' ,
<##, -
TriboDto##- 5
>##5 6
(##6 7
$"##7 9O
CSELECT T.Id, T.Nome, T.Ativo FROM [TB_tribo] T WHERE T.Nome LIKE '%##9 |
{##| }
nome	##} Å
}
##Å Ç
%'
##Ç Ñ
"
##Ñ Ö
)
##Ö Ü
;
##Ü á
return%% 
lista%% 
;%% 
}&& 
}'' 	
}(( 
})) 