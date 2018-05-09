-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 9.3.0              
-- * Generator date: Feb 16 2016              
-- * Generation date: Wed May 09 17:56:37 2018 
-- * LUN file: C:\Users\Edoardo\Desktop\universita\Terzo anno\Ingegneria del software\progetto\PALESTRADB.lun 
-- * Schema: PALESTRA/SQL 
-- ********************************************* 


-- Database Section
-- ________________ 

create database PALESTRA;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table ALLENAMENTI (
     ID char(1) not null,
     Peso numeric(1),
     Data date not null,
     Durata numeric(1) not null,
     Ese_ID char(1) not null,
     constraint ID_ALLENAMENTI_ID primary key (ID));

create table ESERCIZI (
     Nome char(1) not null,
     FasciaMuscolare char(1) not null,
     constraint ID_ESERCIZI_ID primary key (Nome));

create table GIORNIALLENAMENTI (
     ID char(1) not null,
     TempoRecuperoTraEsercizi numeric(1) not null,
     Con_ID char(1) not null,
     constraint ID_GIORNIALLENAMENTI_ID primary key (ID));

create table insiemeSerie (
     ID char(1) not null,
     numeroSerie char(1) not null,
     numeroRipetizioni char(1) not null,
     tempoDiRecuperoTraSerie char(1) not null,
     peso char(1),
     I_G_ID char(1) not null,
     Nome char(1) not null,
     constraint ID_insiemeSerie_ID primary key (ID));

create table PIANOALLENAMENTO (
     ID char(1) not null,
     NumeroGiorniAllenamento_ numeric(1) not null,
     TipoAllenamento char(1) not null,
     constraint FKrealizza_ID primary key (ID));

create table UTENTE (
     ID char(1) not null,
     Nome char(1) not null,
     Cognome char(1) not null,
     Sesso char(1) not null,
     DataNascita date not null,
     Peso numeric(1) not null,
     Altezza numeric(1) not null,
     constraint ID_UTENTE_ID primary key (ID));

create table UTENTEAUTOMATICO (
     ID char(1) not null,
     RisorseDisponibili char(1) not null,
     NumeroAllenamentiSettimanali numeric(1) not null,
     TipoAllenamento char(1) not null,
     constraint FKUTE_UTE_ID primary key (ID));


-- Constraints Section
-- ___________________ 

alter table ALLENAMENTI add constraint FKesegue_FK
     foreign key (Ese_ID)
     references UTENTE;

alter table GIORNIALLENAMENTI add constraint ID_GIORNIALLENAMENTI_CHK
     check(exists(select * from insiemeSerie
                  where insiemeSerie.I_G_ID = ID)); 

alter table GIORNIALLENAMENTI add constraint FKcontiene_FK
     foreign key (Con_ID)
     references PIANOALLENAMENTO;

alter table insiemeSerie add constraint FKins_GIO_FK
     foreign key (I_G_ID)
     references GIORNIALLENAMENTI;

alter table insiemeSerie add constraint FKins_ESE_FK
     foreign key (Nome)
     references ESERCIZI;

alter table PIANOALLENAMENTO add constraint FKrealizza_CHK
     check(exists(select * from GIORNIALLENAMENTI
                  where GIORNIALLENAMENTI.Con_ID = ID)); 

alter table PIANOALLENAMENTO add constraint FKrealizza_FK
     foreign key (ID)
     references UTENTE;

alter table UTENTE add constraint ID_UTENTE_CHK
     check(exists(select * from PIANOALLENAMENTO
                  where PIANOALLENAMENTO.ID = ID)); 

alter table UTENTEAUTOMATICO add constraint FKUTE_UTE_FK
     foreign key (ID)
     references UTENTE;


-- Index Section
-- _____________ 

create unique index ID_ALLENAMENTI_IND
     on ALLENAMENTI (ID);

create index FKesegue_IND
     on ALLENAMENTI (Ese_ID);

create unique index ID_ESERCIZI_IND
     on ESERCIZI (Nome);

create unique index ID_GIORNIALLENAMENTI_IND
     on GIORNIALLENAMENTI (ID);

create index FKcontiene_IND
     on GIORNIALLENAMENTI (Con_ID);

create unique index ID_insiemeSerie_IND
     on insiemeSerie (ID);

create index FKins_GIO_IND
     on insiemeSerie (I_G_ID);

create index FKins_ESE_IND
     on insiemeSerie (Nome);

create unique index FKrealizza_IND
     on PIANOALLENAMENTO (ID);

create unique index ID_UTENTE_IND
     on UTENTE (ID);

create unique index FKUTE_UTE_IND
     on UTENTEAUTOMATICO (ID);

