«
KC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Abstracao\INegocioBase.cs
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
} ô
HC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\AutenticacaoNegocio.cs
	namespace		 	
	Vicelulas		
 
.		 
Negocio		 
{

 
public 

class 
AutenticacaoNegocio $
:% & 
IAutenticacaoNegocio' ;
{ 
private 
readonly $
IAutenticacaoRepositorio 1$
_autenticacaoRepositorio2 J
;J K
public 
AutenticacaoNegocio "
(" #$
IAutenticacaoRepositorio# ;$
_autenticacaoRepositorio< T
)T U
{ 	
this 
. $
_autenticacaoRepositorio )
=* +$
_autenticacaoRepositorio, D
;D E
} 	
public 
	PessoaDto 
Entrar 
(  
string  &
username' /
,/ 0
string1 7
password8 @
)@ A
{ 	
var 
pwHash 
= 
PasswordHash %
.% &
Create& ,
(, -
password- 5
)5 6
;6 7
var 
obj 
= $
_autenticacaoRepositorio .
.. /
Entrar/ 5
(5 6
username6 >
,> ?
pwHash@ F
)F G
;G H
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 O
)O P
;P Q
if   
(   
!   
obj   
.   
Ativo   
)   
throw!! 
new!! 
RecusadoException!! +
(!!+ ,
$str!!, W
)!!W X
;!!X Y
return## 
obj## 
;## 
}$$ 	
}&& 
}'' Â
SC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\IAutenticacaoNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface  
IAutenticacaoNegocio )
{ 
	PessoaDto		 
Entrar		 
(		 
string		 
username		  (
,		( )
string		* 0
password		1 9
)		9 :
;		: ;
}

 
} ±
MC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\IMentorNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface 
IMentorNegocio #
{ 
IEnumerable 
< 
	MentorDto 
> 

Selecionar )
() *
)* +
;+ ,
}		 
}

 Æ
LC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\IPapelNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface 
IPapelNegocio "
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
 Ô

MC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\IPessoaNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface 
IPessoaNegocio #
{ 
	PessoaDto		 
Alterar		 
(		 
int		 
Id		  
,		  !
Pessoa		" (
entity		) /
)		/ 0
;		0 1
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
)

) *
;

* +
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
	PessoaDto 
SelecionarPorId !
(! "
int" %
id& (
)( )
;) *
IEnumerable 
< 
	PessoaDto 
>  
SelecionarPorIdSquad 3
(3 4
int4 7
?7 8
id9 ;
); <
;< =
IEnumerable 
< 
	PessoaDto 
> 
SelecionarPorNome 0
(0 1
string1 7
nome8 <
)< =
;= >
} 
} ˆ
LC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\ISquadNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface 
ISquadNegocio "
{		 
SquadDto

 
Alterar

 
(

 
int

 
Id

 
,

  
Squad

! &
entity

' -
)

- .
;

. /
void  
AtivarDesativarSquad !
(! "
int" %
id& (
)( )
;) *
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
;8 9
} 
} ô	
LC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\ITriboNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface 
ITriboNegocio "
{ 
TriboDto		 
Alterar		 
(		 
int		 
Id		 
,		  
Tribo		! &
entity		' -
)		- .
;		. /
void

  
AtivarDesativarTribo

 !
(

! "
int

" %
id

& (
)

( )
;

) *
int 
Inserir 
( 
Tribo 
entity  
)  !
;! "
IEnumerable 
< 
TriboDto 
> 

Selecionar (
(( )
)) *
;* +
TriboDto 
SelecionarPorId  
(  !
int! $
id% '
)' (
;( )
IEnumerable 
< 
TriboDto 
> 
SelecionarPorNome /
(/ 0
string0 6
nome7 ;
); <
;< =
} 
} ¥
NC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Interface\IUnidadeNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

	interface 
IUnidadeNegocio $
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
 õ
BC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\MentorNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public		 

class		 
MentorNegocio		 
:		  
IMentorNegocio		! /
{

 
private 
readonly 
IMentorRepositorio +
_mentorRepositorio, >
;> ?
public 
MentorNegocio 
( 
IMentorRepositorio /
_mentorRepositorio0 B
)B C
{ 	
this 
. 
_mentorRepositorio #
=$ %
_mentorRepositorio& 8
;8 9
} 	
public 
IEnumerable 
< 
	MentorDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
return 
_mentorRepositorio %
.% &

Selecionar& 0
(0 1
)1 2
;2 3
} 	
} 
} è
AC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\PapelNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

class 
PapelNegocio 
: 
IPapelNegocio  -
{ 
private 
readonly 
IPapelRepositorio *
_papelRepositorio+ <
;< =
public 
PapelNegocio 
( 
IPapelRepositorio -
_papelRepositorio. ?
)? @
{ 	
this 
. 
_papelRepositorio "
=# $
_papelRepositorio% 6
;6 7
} 	
public 
IEnumerable 
< 
PapelDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
return 
_papelRepositorio $
.$ %

Selecionar% /
(/ 0
)0 1
;1 2
} 	
} 
} îO
BC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\PessoaNegocio.cs
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
 
PessoaNegocio

 
:

  
IPessoaNegocio

! /
{ 
private 
readonly 
IPessoaRepositorio +
_pessoaRepositorio, >
;> ?
private 
readonly 
IMentorRepositorio +
_mentorRepositorio, >
;> ?
public 
PessoaNegocio 
( 
IPessoaRepositorio /
_pessoaRepositorio0 B
,B C
IMentorRepositorioD V
_mentorRepositorioW i
)i j
{ 	
this 
. 
_pessoaRepositorio #
=$ %
_pessoaRepositorio& 8
;8 9
this 
. 
_mentorRepositorio #
=$ %
_mentorRepositorio& 8
;8 9
} 	
public 
IEnumerable 
< 
	PessoaDto %
>% &

Selecionar' 1
(1 2
)2 3
{ 	
return 
_pessoaRepositorio &
.& '

Selecionar' 1
(1 2
)2 3
;3 4
} 	
public 
	PessoaDto 
SelecionarPorId (
(( )
int) ,
id- /
)/ 0
{ 	
var 
obj 
= 
_pessoaRepositorio (
.( )
SelecionarPorId) 8
(8 9
id9 ;
); <
;< =
if 
( 
obj 
== 
null 
) 
throw   
new   "
NaoEncontradoException   0
(  0 1
$str  1 J
)  J K
;  K L
return"" 
obj"" 
;"" 
}## 	
public&& 
IEnumerable&& 
<&& 
	PessoaDto&& %
>&&% &
SelecionarPorNome&&' 8
(&&8 9
string&&9 ?
nome&&@ D
)&&D E
{'' 	
var(( 
lista(( 
=(( 
_pessoaRepositorio(( *
.((* +
SelecionarPorNome((+ <
(((< =
nome((= A
)((A B
;((B C
if** 
(** 
lista** 
==** 
null** 
)** 
throw++ 
new++ "
NaoEncontradoException++ 0
(++0 1
$str++1 d
)++d e
;++e f
return-- 
lista-- 
;-- 
}.. 	
public11 
IEnumerable11 
<11 
	PessoaDto11 %
>11% & 
SelecionarPorIdSquad11' ;
(11; <
int11< ?
?11? @
id11A C
)11C D
{22 	
var33 
lista33 
=33 
_pessoaRepositorio33 *
.33* + 
SelecionarPorIdSquad33+ ?
(33? @
id33@ B
)33B C
;33C D
if55 
(55 
lista55 
==55 
null55 
)55 
throw66 
new66 "
NaoEncontradoException66 0
(660 1
$str661 b
)66b c
;66c d
return88 
lista88 
;88 
}99 	
public<< 
int<< 
Inserir<< 
(<< 
Pessoa<< !
entity<<" (
)<<( )
{== 	
var>> 
NomeExistente>> 
=>> 
_pessoaRepositorio>>  2
.>>2 3'
SelecionarPorNomeEspecifico>>3 N
(>>N O
entity>>O U
.>>U V
Nome>>V Z
)>>Z [
;>>[ \
if@@ 
(@@ 
string@@ 
.@@ 
IsNullOrEmpty@@ $
(@@$ %
entity@@% +
.@@+ ,
Nome@@, 0
)@@0 1
)@@1 2
throwAA 
newAA 
ConflitoExceptionAA +
(AA+ ,
$strAA, Q
)AAQ R
;AAR S
ifCC 
(CC 
NomeExistenteCC 
!=CC  
nullCC! %
)CC% &
throwDD 
newDD 
ConflitoExceptionDD +
(DD+ ,
$"DD, .;
/J√° existe uma Pessoa cadastrada com este nome DD. \
{DD\ ]
entityDD] c
.DDc d
NomeDDd h
}DDh i
!DDi j
"DDj k
)DDk l
;DDl m
varFF 
EmailExistenteFF 
=FF  
_pessoaRepositorioFF! 3
.FF3 4
SelecionarPorEmailFF4 F
(FFF G
entityFFG M
.FFM N
EmailFFN S
)FFS T
;FFT U
ifHH 
(HH 
EmailExistenteHH 
!=HH !
nullHH" &
)HH& '
throwII 
newII 
ConflitoExceptionII +
(II+ ,
$"II, .<
0J√° existe uma Pessoa cadastrada com este Email II. ]
{II] ^
entityII^ d
.IId e
EmailIIe j
}IIj k
!IIk l
"IIl m
)IIm n
;IIn o
ifKK 
(KK 
entityKK 
.KK 
Id_squadKK 
==KK  "
$numKK# $
)KK$ %
entityLL 
.LL 
Id_squadLL 
=LL  !
nullLL" &
;LL& '
entityMM 
.MM 
SenhaMM 
=MM 
PasswordHashMM '
.MM' (
CreateMM( .
(MM. /
entityMM/ 5
.MM5 6
SenhaMM6 ;
.MM; <
ToStringMM< D
(MMD E
)MME F
)MMF G
;MMG H
varOO 
IdPessoaOO 
=OO 
_pessoaRepositorioOO -
.OO- .
InserirOO. 5
(OO5 6
entityOO6 <
)OO< =
;OO= >
ifQQ 
(QQ 
entityQQ 
.QQ 
	PermissaoQQ  
==QQ! #
$numQQ$ %
)QQ% &
_mentorRepositorioRR "
.RR" #
InserirRR# *
(RR* +
IdPessoaRR+ 3
)RR3 4
;RR4 5
returnSS 
IdPessoaSS 
;SS 
}TT 	
publicWW 
	PessoaDtoWW 
AlterarWW  
(WW  !
intWW! $
IdWW% '
,WW' (
PessoaWW) /
entityWW0 6
)WW6 7
{XX 	
varYY 
idExistenteYY 
=YY 
_pessoaRepositorioYY 0
.YY0 1
SelecionarPorIdYY1 @
(YY@ A
IdYYA C
)YYC D
;YYD E
if\\ 
(\\ 
idExistente\\ 
==\\ 
null\\ #
)\\# $
{]] 
throw^^ 
new^^ "
NaoEncontradoException^^ 0
(^^0 1
$"^^1 3$
N√£o existe esta Pessoa!^^3 J
"^^J K
)^^K L
;^^L M
}__ 
varaa 
NomeExistenteaa 
=aa 
_pessoaRepositorioaa  2
.aa2 3'
SelecionarPorNomeEspecificoaa3 N
(aaN O
entityaaO U
.aaU V
NomeaaV Z
)aaZ [
;aa[ \
ifcc 
(cc 
NomeExistentecc 
!=cc  
nullcc! %
&&cc& (
idExistentecc) 4
.cc4 5
Idcc5 7
!=cc8 :
entitycc; A
.ccA B
IdccB D
)ccD E
throwdd 
newdd 
ConflitoExceptiondd +
(dd+ ,
$"dd, .;
/J√° existe uma Pessoa cadastrada com este nome dd. \
{dd\ ]
entitydd] c
.ddc d
Nomeddd h
}ddh i
!ddi j
"ddj k
)ddk l
;ddl m
varff 
EmailExistenteff 
=ff  
_pessoaRepositorioff! 3
.ff3 4
SelecionarPorEmailff4 F
(ffF G
entityffG M
.ffM N
EmailffN S
)ffS T
;ffT U
ifhh 
(hh 
EmailExistentehh 
!=hh !
nullhh" &
&&hh' )
idExistentehh* 5
.hh5 6
Idhh6 8
!=hh9 ;
entityhh< B
.hhB C
IdhhC E
)hhE F
throwii 
newii 
ConflitoExceptionii +
(ii+ ,
$"ii, .=
1J√° esxiste uma pessoa cadastrada com este email ii. ^
{ii^ _
entityii_ e
.iie f
Emailiif k
}iik l
!iil m
"iim n
)iin o
;iio p
ifkk 
(kk 
entitykk 
.kk 
Id_squadkk 
==kk  "
$numkk# $
)kk$ %
entityll 
.ll 
Id_squadll 
=ll  !
nullll" &
;ll& '
entitymm 
.mm 
Idmm 
=mm 
Idmm 
;mm 
_pessoaRepositorionn 
.nn 
Alterarnn &
(nn& '
entitynn' -
)nn- .
;nn. /
returnpp 
_pessoaRepositoriopp &
.pp& '
SelecionarPorIdpp' 6
(pp6 7
Idpp7 9
)pp9 :
;pp: ;
}qq 	
publictt 
voidtt !
AtivarDesativarPessoatt )
(tt) *
inttt* -
idtt. 0
)tt0 1
{uu 	
varvv 
objvv 
=vv 
_pessoaRepositoriovv (
.vv( )
SelecionarPorIdvv) 8
(vv8 9
idvv9 ;
)vv; <
;vv< =
ifxx 
(xx 
objxx 
==xx 
nullxx 
)xx 
throwyy 
newyy "
NaoEncontradoExceptionyy 0
(yy0 1
$"yy1 3,
 N√£o existe uma Pessoa com o id yy3 R
{yyR S
idyyS U
}yyU V
"yyV W
)yyW X
;yyX Y
_pessoaRepositorio{{ 
.{{ !
AtivarDesativarPessoa{{ 3
({{3 4
id{{4 6
,{{6 7
!{{8 9
obj{{9 <
.{{< =
Ativo{{= B
){{B C
;{{C D
}|| 	
}~~ 
} àB
AC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\SquadNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public		 

class		 
SquadNegocio		 
:		 
ISquadNegocio		  -
{

 
private 
readonly 
ISquadRepositorio *
_squadRepositorio+ <
;< =
public 
SquadNegocio 
( 
ISquadRepositorio -
_squadRepositorio. ?
)? @
{ 	
this 
. 
_squadRepositorio "
=# $
_squadRepositorio% 6
;6 7
} 	
public 
IEnumerable 
< 
SquadDto $
>$ %

Selecionar& 0
(0 1
)1 2
{ 	
return 
_squadRepositorio %
.% &

Selecionar& 0
(0 1
)1 2
;2 3
} 	
public 
SquadDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
var 
obj 
= 
_squadRepositorio '
.' (
SelecionarPorId( 7
(7 8
id8 :
): ;
;; <
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 I
)I J
;J K
return   
obj   
;   
}!! 	
public$$ 
IEnumerable$$ 
<$$ 
SquadDto$$ $
>$$$ %
SelecionarPorNome$$& 7
($$7 8
string$$8 >
nome$$? C
)$$C D
{%% 	
var&& 
lista&& 
=&& 
_squadRepositorio&& )
.&&) *
SelecionarPorNome&&* ;
(&&; <
nome&&< @
)&&@ A
;&&A B
if(( 
((( 
lista(( 
==(( 
null(( 
)(( 
throw)) 
new)) "
NaoEncontradoException)) 0
())0 1
$str))1 c
)))c d
;))d e
return++ 
lista++ 
;++ 
},, 	
public.. 
IEnumerable.. 
<.. 
SquadDto.. $
>..$ %$
SelecionarSquadsSemTribo..& >
(..> ?
)..? @
{// 	
return00 
_squadRepositorio00 #
.00# $$
SelecionarSquadsSemTribo00$ <
(00< =
)00= >
;00> ?
}11 	
public44 
IEnumerable44 
<44 
SquadDto44 $
>44$ % 
SelecionarPorIdTribo44& :
(44: ;
int44; >
id44? A
)44A B
{55 	
var66 
lista66 
=66 
_squadRepositorio66 )
.66) * 
SelecionarPorIdTribo66* >
(66> ?
id66? A
)66A B
;66B C
if88 
(88 
lista88 
==88 
null88 
)88 
throw99 
new99 "
NaoEncontradoException99 0
(990 1
$str991 a
)99a b
;99b c
return;; 
lista;; 
;;; 
}<< 	
public?? 
int?? 
Inserir?? 
(?? 
Squad??  
entity??! '
)??' (
{@@ 	
varAA 
NomeExistenteAA 
=AA 
_squadRepositorioAA  1
.AA1 2'
SelecionarPorNomeEspecificoAA2 M
(AAM N
entityAAN T
.AAT U
NomeAAU Y
)AAY Z
;AAZ [
ifCC 
(CC 
stringCC 
.CC 
IsNullOrEmptyCC $
(CC$ %
entityCC% +
.CC+ ,
NomeCC, 0
)CC0 1
)CC1 2
throwDD 
newDD 
ConflitoExceptionDD +
(DD+ ,
$strDD, L
)DDL M
;DDM N
ifFF 
(FF 
NomeExistenteFF 
!=FF  
nullFF! %
)FF% &
throwGG 
newGG 
ConflitoExceptionGG +
(GG+ ,
$"GG, .:
.J√° existe uma Squad cadastrada com este nome GG. [
{GG[ \
entityGG\ b
.GGb c
NomeGGc g
}GGg h
!GGh i
"GGi j
)GGj k
;GGk l
ifII 
(II 
entityII 
.II 
Id_triboII 
==II  "
$numII# $
)II$ %
entityJJ 
.JJ 
Id_triboJJ 
=JJ  !
nullJJ" &
;JJ& '
ifKK 
(KK 
entityKK 
.KK 
	Id_MentorKK  
==KK! #
$numKK$ %
)KK% &
entityLL 
.LL 
	Id_MentorLL  
=LL! "
nullLL# '
;LL' (
returnNN 
_squadRepositorioNN $
.NN$ %
InserirNN% ,
(NN, -
entityNN- 3
)NN3 4
;NN4 5
}OO 	
publicRR 
SquadDtoRR 
AlterarRR  
(RR  !
intRR! $
IdRR% '
,RR' (
SquadRR) .
entityRR/ 5
)RR5 6
{SS 	
varTT 
idExistenteTT 
=TT 
_squadRepositorioTT /
.TT/ 0
SelecionarPorIdTT0 ?
(TT? @
IdTT@ B
)TTB C
;TTC D
ifVV 
(VV 
idExistenteVV 
==VV 
nullVV #
)VV# $
throwWW 
newWW "
NaoEncontradoExceptionWW 0
(WW0 1
$"WW1 3#
N√£o existe esta Squad!WW3 I
"WWI J
)WWJ K
;WWK L
varZZ 
NomeExistenteZZ 
=ZZ 
_squadRepositorioZZ  1
.ZZ1 2'
SelecionarPorNomeEspecificoZZ2 M
(ZZM N
entityZZN T
.ZZT U
NomeZZU Y
)ZZY Z
;ZZZ [
if\\ 
(\\ 
NomeExistente\\ 
!=\\  
null\\! %
&&\\& (
idExistente\\) 4
.\\4 5
Id\\5 7
!=\\8 :
entity\\; A
.\\A B
Id\\B D
)\\D E
throw]] 
new]] 
ConflitoException]] +
(]]+ ,
$"]], .:
.J√° existe uma Squad cadastrada com este nome ]]. [
{]][ \
entity]]\ b
.]]b c
Nome]]c g
}]]g h
!]]h i
"]]i j
)]]j k
;]]k l
if__ 
(__ 
entity__ 
.__ 
Id_tribo__ 
==__  "
$num__# $
)__$ %
entity`` 
.`` 
Id_tribo`` 
=``  !
null``" &
;``& '
ifaa 
(aa 
entityaa 
.aa 
	Id_Mentoraa  
==aa! #
$numaa$ %
)aa% &
entitybb 
.bb 
	Id_Mentorbb  
=bb! "
nullbb# '
;bb' (
entitydd 
.dd 
Iddd 
=dd 
Iddd 
;dd 
_squadRepositorioee 
.ee 
Alteraree %
(ee% &
entityee& ,
)ee, -
;ee- .
returngg 
_squadRepositoriogg %
.gg% &
SelecionarPorIdgg& 5
(gg5 6
Idgg6 8
)gg8 9
;gg9 :
}hh 	
publickk 
voidkk  
AtivarDesativarSquadkk (
(kk( )
intkk) ,
idkk- /
)kk/ 0
{ll 	
varmm 
objmm 
=mm 
_squadRepositoriomm '
.mm' (
SelecionarPorIdmm( 7
(mm7 8
idmm8 :
)mm: ;
;mm; <
ifoo 
(oo 
objoo 
==oo 
nulloo 
)oo 
throwpp 
newpp "
NaoEncontradoExceptionpp 0
(pp0 1
$"pp1 3+
N√£o existe uma Squad com o id pp3 Q
{ppQ R
idppR T
}ppT U
"ppU V
)ppV W
;ppW X
_squadRepositoriorr 
.rr  
AtivarDesativarSquadrr 2
(rr2 3
idrr3 5
,rr5 6
!rr7 8
objrr8 ;
.rr; <
Ativorr< A
)rrA B
;rrB C
}ss 	
}uu 
}vv ê6
AC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\TriboNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public		 

class		 
TriboNegocio		 
:		 
ITriboNegocio		  -
{

 
private 
readonly 
ITriboRepositorio *
_triboRepositorio+ <
;< =
public 
TriboNegocio 
( 
ITriboRepositorio -
_triboRepositorio. ?
)? @
{ 	
this 
. 
_triboRepositorio "
=# $
_triboRepositorio% 6
;6 7
} 	
public 
IEnumerable 
< 
TriboDto #
># $

Selecionar% /
(/ 0
)0 1
{ 	
return 
_triboRepositorio $
.$ %

Selecionar% /
(/ 0
)0 1
;1 2
} 	
public 
TriboDto 
SelecionarPorId '
(' (
int( +
id, .
). /
{ 	
var 
obj 
= 
_triboRepositorio '
.' (
SelecionarPorId( 7
(7 8
id8 :
): ;
;; <
if 
( 
obj 
== 
null 
) 
throw 
new "
NaoEncontradoException 0
(0 1
$str1 I
)I J
;J K
return   
obj   
;   
}!! 	
public$$ 
IEnumerable$$ 
<$$ 
TriboDto$$ #
>$$# $
SelecionarPorNome$$% 6
($$6 7
string$$7 =
nome$$> B
)$$B C
{%% 	
var&& 
lista&& 
=&& 
_triboRepositorio&& )
.&&) *
SelecionarPorNome&&* ;
(&&; <
nome&&< @
)&&@ A
;&&A B
if(( 
((( 
lista(( 
==(( 
null(( 
)(( 
throw)) 
new)) "
NaoEncontradoException)) 0
())0 1
$str))1 c
)))c d
;))d e
return++ 
lista++ 
;++ 
},, 	
public.. 
int.. 
Inserir.. 
(.. 
Tribo..  
entity..! '
)..' (
{// 	
var00 
NomeExistente00 
=00 
_triboRepositorio00  1
.001 2'
SelecionarPorNomeEspecifico002 M
(00M N
entity00N T
.00T U
Nome00U Y
)00Y Z
;00Z [
if22 
(22 
string22 
.22 
IsNullOrEmpty22 $
(22$ %
entity22% +
.22+ ,
Nome22, 0
)220 1
)221 2
throw33 
new33 
ConflitoException33 +
(33+ ,
$str33, L
)33L M
;33M N
if55 
(55 
NomeExistente55 
!=55  
null55! %
)55% &
throw66 
new66 
ConflitoException66 +
(66+ ,
$"66, .:
.J√° existe uma Tribo cadastrada com este nome 66. [
{66[ \
entity66\ b
.66b c
Nome66c g
}66g h
!66h i
"66i j
)66j k
;66k l
if88 
(88 
entity88 
.88 
	Id_Mentor88  
==88! #
$num88$ %
)88% &
entity99 
.99 
	Id_Mentor99  
=99! "
null99# '
;99' (
return;; 
_triboRepositorio;; $
.;;$ %
Inserir;;% ,
(;;, -
entity;;- 3
);;3 4
;;;4 5
}<< 	
public>> 
TriboDto>> 
Alterar>> 
(>>  
int>>  #
Id>>$ &
,>>& '
Tribo>>( -
entity>>. 4
)>>4 5
{?? 	
var@@ 
idExistente@@ 
=@@ 
_triboRepositorio@@ /
.@@/ 0
SelecionarPorId@@0 ?
(@@? @
Id@@@ B
)@@B C
;@@C D
ifBB 
(BB 
idExistenteBB 
==BB 
nullBB "
)BB" #
throwCC 
newCC "
NaoEncontradoExceptionCC 0
(CC0 1
$"CC1 3#
N√£o existe esta tribo!CC3 I
"CCI J
)CCJ K
;CCK L
varFF 
NomeExistenteFF 
=FF 
_triboRepositorioFF  1
.FF1 2'
SelecionarPorNomeEspecificoFF2 M
(FFM N
entityFFN T
.FFT U
NomeFFU Y
)FFY Z
;FFZ [
ifHH 
(HH 
NomeExistenteHH 
!=HH  
nullHH! %
&&HH& (
idExistenteHH) 4
.HH4 5
IdHH5 7
!=HH8 :
entityHH; A
.HHA B
IdHHB D
)HHD E
throwII 
newII 
ConflitoExceptionII +
(II+ ,
$"II, .:
.J√° existe uma Tribo cadastrada com este nome II. [
{II[ \
entityII\ b
.IIb c
NomeIIc g
}IIg h
!IIh i
"IIi j
)IIj k
;IIk l
ifKK 
(KK 
entityKK 
.KK 
	Id_MentorKK  
==KK! #
$numKK$ %
)KK% &
entityLL 
.LL 
	Id_MentorLL  
=LL! "
nullLL# '
;LL' (
entityNN 
.NN 
IdNN 
=NN 
IdNN 
;NN 
_triboRepositorioOO 
.OO 
AlterarNomeOO )
(OO) *
entityOO* 0
)OO0 1
;OO1 2
returnQQ 
_triboRepositorioQQ $
.QQ$ %
SelecionarPorIdQQ% 4
(QQ4 5
IdQQ5 7
)QQ7 8
;QQ8 9
}RR 	
publicUU 
voidUU  
AtivarDesativarTriboUU (
(UU( )
intUU) ,
idUU- /
)UU/ 0
{VV 	
varWW 
objWW 
=WW 
_triboRepositorioWW '
.WW' (
SelecionarPorIdWW( 7
(WW7 8
idWW8 :
)WW: ;
;WW; <
ifYY 
(YY 
objYY 
==YY 
nullYY 
)YY 
throwZZ 
newZZ "
NaoEncontradoExceptionZZ 0
(ZZ0 1
$"ZZ1 3+
N√£o existe uma Tribo com o id ZZ3 Q
{ZZQ R
idZZR T
}ZZT U
"ZZU V
)ZZV W
;ZZW X
_triboRepositorio\\ 
.\\  
AtivarDesativarTribo\\ 2
(\\2 3
id\\3 5
,\\5 6
!\\6 7
obj\\7 :
.\\: ;
Ativo\\; @
)\\@ A
;\\A B
}^^ 	
}`` 
}aa ß
CC:\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\UnidadeNegocio.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
{ 
public 

class 
UnidadeNegocio 
:  !
IUnidadeNegocio" 1
{ 
private		 
readonly		 
IUnidadeRepositorio		 ,
_UnidadeRepositorio		- @
;		@ A
public 
UnidadeNegocio 
( 
IUnidadeRepositorio 1
_UnidadeRepositorio2 E
)E F
{ 	
this 
. 
_UnidadeRepositorio $
=% &
_UnidadeRepositorio' :
;: ;
} 	
public 
IEnumerable 
< 

UnidadeDto %
>% &

Selecionar' 1
(1 2
)2 3
{ 	
return 
_UnidadeRepositorio &
.& '

Selecionar' 1
(1 2
)2 3
;3 4
} 	
} 
} 