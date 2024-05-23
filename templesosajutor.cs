
temple os

manual in limba romana 

capitolul 1.

ajutor holyc

partea 1 capitolul 1.

a.compileroverview

b.scoping and linkage

c.tipuri de date built-in

U0,  void
I8,  char
U8,  unsigned char
I16, short
U16, unsigned short
I32, int
U32, unsigned int
I64, long 64 biti
U64, usingined long 64 biti
F64, double 
nu include F32 sau float

d. apelul functiilor fara argumente 
dir;
dir("*");
dir();

e. argumentele cu valori default 
pot fi puse oriunde nu doar la final
->exemplu in help

f. PutChar() , Print(), fmt_str
char const -> PutChar()
string -> Print()
fmt_str string literal empty

g.adresele functiilor precum callbacks sunt precedate de &

h.casting de tipuri de date este postfix. 
ToI64()
ToBool()
ToF64()

i.nu exista main() . 
functiile sunt executate in ordinea lor

j.cmpurile de biti sau bit fields nu exista insa exista bit_access o rutina care permite accesul la bytes si cuvinte in interiorul int. 
vezi declaratia I64.
o clasa pate fi accesata la un intreg sau subintreg subint daca adaugi in fata class declaratia I64

vezi exemplu din help

k.functiile cu argumente variabile (...) pot accesa argumentele utilizand this si I64 argc si I64 argv[]

vezi exemplu din help

l.permite instructiuni de forma 5<i<j+1<20 in if 

m. switch[] nu verifica ceea ce switch stmt verifica daca excede valoarea de case min sau max 

n.switch stmts utilizeaza un tabel de jump sau salturi . nu utilizati cu cases pentru seturi de valori mari sau disparate

o.case 4...7 in switch stmts este permis

p.un case nenumeric face ca urmatorul case selectat sa fie urmatorul mai mare din switch stmts

vezi exemplu din help

q.switch poate fi imbricat cu o singura expresie switch sau sub-switch
start/end sunt utilizate ca case de grup.
nu utiliza goto out of ci foloseste o exceptie throe out of sau return out of in start in fata zonei porch

vezi exemplu din help

r.no_warn stmt nu va afisa warnings sau alerte

s.poti avea multipli membri pad sau reserved in class fara ca o alerta sa fie afisata

t.noreg sau reg poate fi plasat inainte de numele unei functii variabile locale. poti optional specifica un reg dupa cuvantul cheie reg 

vezi exemplu din help

u. interrupt, haserrcode, public ,argpop, noargpop sunt flaguri de functii vezi IRQKbd()

v. intre ghilimele simple poti include mai mutle caractere precum un string. 
'ABC' e echivalent cu 0x434241. 
 PutChar() poate prelua mai multe caractere.

vezi exemplul din help

x."`" operatorul de ridicare la putere a unei baze la o putere

z. nu exista ?: operatorul acesta

w. temple os precedenta operatorilor
`, >> ,<<
*,/,%
&
^
|
+,-
<,>,<=,>=
==,!=
&&
||
=,<<=,>>=,*=,/=,^=,+=,-=

y.pentru a gasi paranteze nenecesare in cod utilizati Option(OPTf_WARN_PARN,ON)


partea 2. capitolul 1

a. utilizati Optiion(OPTf_WARN_Dup_TYPES,ON) 
pentru a gasi variabile locale de tip stmts duplicate

b.utilizati #exe{} in codul sursa poti insera text in interiorul unui stream al codului in timpul compilarii. vezi exemplul pentru date/time si promptul la timpul compilarii pentru cfguration data este plasat in program. StremPrint() plaseaza textul in interiorul codului sursa al streamului programului urmand directiva #exe{} blk

c.nu exista o functie #define

d.nu exista typedef utilizati class

e.nu exista verificari ale tipurilor de date

f.nu se poate folosi <> cu #include  ci se foloseste ""

g."$" este un caractere escape. $$ inseamna un $ simbol. vezi DolDoc . In asm sau codul HolyC, face referire la adresa inst sau offset in definitia class

h.union este precum class. nu refeiti a union dupa definire. exista unele union comune in KernelA.HH pentru obiecte de 1,2,4,8 byte. Daca pui un tip de data in fata declaratiei unui union acesta va fi tipul de data utilizat. 

vezi ;;Demo/SubIntAccess.HC

i.membri variabile ale class poate contine meta date. format si data sunt doua meta date utilzate. toate structurile compilerului sunt salvate si poti accesa infor compilerului despre clase si variabile. vezi ''Demo/ClassMeta.HC si DocForm()

j.exista cuvantul cheie lastclass care se poate utiliza ca dft arg.
acesta este setat catre numele clasei arg precedent.
vezi Demo/LastClass.HC, CLassRep(), DocForm() si Demo/Dsk/BlkDevRep.HC

k.vezi Demo/Exceptions.HC 
try{} , catc{} si throw sunt difertie de c++. throw e o functie pe 8 byte sau mai putin de tip char arg. sirul de caractere transmis in throw() poate fi accesat din catch{} utilziand Fs->except_ch.
in catch{} blk poti pune Fs->catch_except in TRUE daca vrei sa termini cautarea pentru un hndlr.
Utilizeaza PutExcept() ca handlr daca doresti.

l.o functie precum sizeof este disponibila pentru a oferi un offset catre un membru al clasei. se numeste offset. poti utiliza numele clasei si ai membrilor in offset(classame.membername). n uare legatura cu codul pe 16-biti. ambele sizeof si offset accepta doar un anumit nimvel de variabile membre. 
de accea poti utiliza offset(classame.membername.submembername)

m.nu exista continue in stmt ci doar goto se poate utiliza

n.lock{} poate fi utilizata pentru a aplia LOCK in asm in prefizul codului pentru acces read-modify-write sigur in modul multicore. codul din interiorul {} al LOCK asm prefix's se aplica insts din interiroul relevante.
e unpic shoddy. vezi Demo/MultiCore/Lock.HC

o.exista functia MSize() care ofera dimensiunea unui obiect alocat pe memoria heap . pentru alocari de dimensiune mare sistemul rotunjeste in sus la o putere de 2 , deci MSize() iti permite sa cunosti dimensiunea reala a.i. poti utiliza asta ca un avantaj.

p.poti elibera prin Free() a pointer NULL ptr. O versiune de MAlloc() se poate gasi . Fiecare task are un heap so poti utiliza MAlloc si Free al altor taskuri heap sau sa faci n heap independent cu HealCtrlInit() .
vei HeapLog() pentru un exemplu.

q.stk stack nu creste datorita memoriei virtuale utilizata. recomand alocarea de variabile de dimensiuen amre pe heap local. poti schimba MEM_DFT_STK si sa recompilezi KErnel sau sa faci request cand utilizezi Spawn() . Poti utiliza CallStkGrow() dar e can aiurea
vezi Demo/StlGrwo.HC



finalul capitolului 1 cu partile 1 si 2

















