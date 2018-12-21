�
oC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Abstração\INegocioBase.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
. 
Abstração %
{ 
public 

	interface 
INegocioBase !
<! "
T" #
># $
where% *
T+ ,
:- .
class/ 4
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
; 
T 	
Alterar
 
( 
int 
id 
, 
T 
entity "
)" #
;# $
void 
Deletar 
( 
int 
id 
) 
; 
} 
} �
cC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\TriboNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{		 
public

 

class

 
TriboNegocio

 
{ 
private 
readonly 
TriboRepositorio )
_triboRepositorio* ;
;; <
public 
TriboNegocio 
( 
) 
{ 	
_triboRepositorio 
= 
new  #
TriboRepositorio$ 4
(4 5
)5 6
;6 7
} 	
public 
IEnumerable 
< 
TriboDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
return 
_triboRepositorio $
.$ %

Selecionar% /
(/ 0
)0 1
;1 2
} 	
public 
TriboDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
var 
obj 
= 
_triboRepositorio '
.' (
SelecionarPorId( 7
(7 8
id8 :
): ;
;; <
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 I
)I J
;J K
return!! 
obj!! 
;!! 
}"" 	
public%% 
IEnumerable%% 
<%% 
TriboDto%% #
>%%# $
SelecionarPorNome%%% 6
(%%6 7
string%%7 =
nome%%> B
)%%B C
{&& 	
var'' 
lista'' 
='' 
_triboRepositorio'' )
.'') *
SelecionarPorNome''* ;
(''; <
nome''< @
)''@ A
;''A B
if)) 
()) 
lista)) 
==)) 
null)) 
))) 
throw** 
new** "
NaoEncontradoException** 0
(**0 1
$str**1 c
)**c d
;**d e
return,, 
lista,, 
;,, 
}-- 	
}.. 
}// 