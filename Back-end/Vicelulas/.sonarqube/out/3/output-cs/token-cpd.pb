È
mC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Abstracao\INegocioBase.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
. 
Abstra√ß√£o %
{ 
public 

	interface 
INegocioBase !
<! "
T" #
># $
where% *
T+ ,
:- .
class/ 4
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
;		 
T

 	
Alterar


 
(

 
int

 
id

 
,

 
T

 
entity

 "
)

" #
;

# $
void 
Deletar 
( 
int 
id 
) 
; 
} 
} ﬁ
dC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\PessoaNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

class 
PessoaNegocio 
{		 
private

 
readonly

 
PessoaRepositorio

 *
_pessoaRepositorio

+ =
;

= >
public 
PessoaNegocio 
( 
) 
{ 	
_pessoaRepositorio 
=  
new! $
PessoaRepositorio% 6
(6 7
)7 8
;8 9
} 	
public 
IEnumerable 
< 
	PessoaDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
return 
_pessoaRepositorio %
.% &

Selecionar& 0
(0 1
)1 2
;2 3
} 	
public 
	PessoaDto 
SelecionarPorId (
(( )
int) ,
id- /
)/ 0
{ 	
var 
obj 
= 
_pessoaRepositorio (
.( )
SelecionarPorId) 8
(8 9
id9 ;
); <
;< =
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 J
)J K
;K L
return 
obj 
; 
} 	
public"" 
IEnumerable"" 
<"" 
	PessoaDto"" $
>""$ %
SelecionarPorNome""& 7
(""7 8
string""8 >
nome""? C
)""C D
{## 	
var$$ 
lista$$ 
=$$ 
_pessoaRepositorio$$ *
.$$* +
SelecionarPorNome$$+ <
($$< =
nome$$= A
)$$A B
;$$B C
if&& 
(&& 
lista&& 
==&& 
null&& 
)&& 
throw'' 
new'' "
NaoEncontradoException'' 0
(''0 1
$str''1 d
)''d e
;''e f
return)) 
lista)) 
;)) 
}** 	
public-- 
IEnumerable-- 
<-- 
	PessoaDto-- $
>--$ % 
SelecionarPorIdSquad--& :
(--: ;
int--; >
id--? A
)--A B
{.. 	
var// 
lista// 
=// 
_pessoaRepositorio// *
.//* + 
SelecionarPorIdSquad//+ ?
(//? @
id//@ B
)//B C
;//C D
if11 
(11 
lista11 
==11 
null11 
)11 
throw22 
new22 "
NaoEncontradoException22 0
(220 1
$str221 b
)22b c
;22c d
return44 
lista44 
;44 
}55 	
}66 
}77 œ
cC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\SquadNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

class 
SquadNegocio 
{		 
private

 
readonly

 
SquadRepositorio

 )
_squadRepositorio

* ;
;

; <
public 
SquadNegocio 
( 
) 
{ 	
_squadRepositorio 
= 
new  #
SquadRepositorio$ 4
(4 5
)5 6
;6 7
} 	
public 
IEnumerable 
< 
SquadDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
return 
_squadRepositorio $
.$ %

Selecionar% /
(/ 0
)0 1
;1 2
} 	
public 
SquadDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
var 
obj 
= 
_squadRepositorio '
.' (
SelecionarPorId( 7
(7 8
id8 :
): ;
;; <
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 I
)I J
;J K
return 
obj 
; 
}   	
public## 
IEnumerable## 
<## 
SquadDto## #
>### $
SelecionarPorNome##% 6
(##6 7
string##7 =
nome##> B
)##B C
{$$ 	
var%% 
lista%% 
=%% 
_squadRepositorio%% )
.%%) *
SelecionarPorNome%%* ;
(%%; <
nome%%< @
)%%@ A
;%%A B
if'' 
('' 
lista'' 
=='' 
null'' 
)'' 
throw(( 
new(( "
NaoEncontradoException(( 0
(((0 1
$str((1 c
)((c d
;((d e
return** 
lista** 
;** 
}++ 	
public.. 
IEnumerable.. 
<.. 
SquadDto.. #
>..# $ 
SelecionarPorIdTribo..% 9
(..9 :
int..: =
id..> @
)..@ A
{// 	
var00 
lista00 
=00 
_squadRepositorio00 )
.00) * 
SelecionarPorIdTribo00* >
(00> ?
id00? A
)00A B
;00B C
if22 
(22 
lista22 
==22 
null22 
)22 
throw33 
new33 "
NaoEncontradoException33 0
(330 1
$str331 a
)33a b
;33b c
return55 
lista55 
;55 
}66 	
}88 
}99 è
cC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\TriboNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

class 
TriboNegocio 
{		 
private

 
readonly

 
TriboRepositorio

 )
_triboRepositorio

* ;
;

; <
public 
TriboNegocio 
( 
) 
{ 	
_triboRepositorio 
= 
new  #
TriboRepositorio$ 4
(4 5
)5 6
;6 7
} 	
public 
IEnumerable 
< 
TriboDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
return 
_triboRepositorio $
.$ %

Selecionar% /
(/ 0
)0 1
;1 2
} 	
public 
TriboDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
var 
obj 
= 
_triboRepositorio '
.' (
SelecionarPorId( 7
(7 8
id8 :
): ;
;; <
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 I
)I J
;J K
return 
obj 
; 
}   	
public## 
IEnumerable## 
<## 
TriboDto## #
>### $
SelecionarPorNome##% 6
(##6 7
string##7 =
nome##> B
)##B C
{$$ 	
var%% 
lista%% 
=%% 
_triboRepositorio%% )
.%%) *
SelecionarPorNome%%* ;
(%%; <
nome%%< @
)%%@ A
;%%A B
if'' 
('' 
lista'' 
=='' 
null'' 
)'' 
throw(( 
new(( "
NaoEncontradoException(( 0
(((0 1
$str((1 c
)((c d
;((d e
return** 
lista** 
;** 
}++ 	
},, 
}-- 