-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 9.3.0              
-- * Generator date: Feb 16 2016              
-- * Generation date: Sun May 13 17:31:20 2018 
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
     ID int not null,
     peso int,
     data date not null,
     durata int not null,
     username varchar(50) not null,
     constraint ID_ALLENAMENTI_ID primary key (ID));

create table ESECUZIONIESERCIZI (
     ID int not null,
     nomeEsercizio varchar(50) not null,
     Ha_ID int not null,
     ESECUZIONIESERCIZIATEMPO int,
     ESECUZIONIESERCIZIASERIE int,
     constraint ID_ESECUZIONIESERCIZI_ID primary key (ID));

create table ESECUZIONIESERCIZIASERIE (
     ID int not null,
     numeroSerie int not null,
     numeroRipetizioni int not null,
     tempoDiRecuperoTraSerie int not null,
     carico int,
     constraint FKESE_ESE_ID primary key (ID));

create table ESECUZIONIESERCIZIATEMPO (
     ID int not null,
     tempo int not null,
     constraint FKESE_ESE_1_ID primary key (ID));

create table GIORNIALLENAMENTI (
     ID int not null,
     tempoRecuperoTraEsercizi int not null,
     username varchar(50) not null,
     constraint ID_GIORNIALLENAMENTI_ID primary key (ID));

create table IDs (
     allenamento int not null,
     giornoAllenamento int not null,
     esecuzioneEsercizio int not null,
     constraint ID_IDs_ID primary key (allenamento, giornoAllenamento, esecuzioneEsercizio));

create table PIANIALLENAMENTO (
     username varchar(50) not null,
     constraint FKrealizza_ID primary key (username));


create table UTENTI (
     username varchar(50) not null,
     password varchar(200) not null,
     nome varchar(50) not null,
     cognome varchar(50) not null,
     sesso varchar(7) not null,
     dataNascita date not null,
     peso int not null,
     altezza int not null,
     fotopath varchar(200),
     constraint ID_UTENTI_ID primary key (username));

create table UTENTIAUTOMATICI (
     username varchar(50) not null,
     risorseDisponibili varchar(12) not null,
     tipoAllenamento varchar(13) not null,
     numeroGiorniAllenamento int not null,
     constraint FKUTE_UTE_ID primary key (username));


-- Constraints Section
-- ___________________ 

alter table ALLENAMENTI add constraint FKesegue_FK
     foreign key (username)
     references UTENTI
     ON DELETE CASCADE;

alter table ESECUZIONIESERCIZI add constraint FKha_FK
     foreign key (Ha_ID)
     references GIORNIALLENAMENTI
     ON DELETE CASCADE;

alter table ESECUZIONIESERCIZIASERIE add constraint FKESE_ESE_FK
     foreign key (ID)
     references ESECUZIONIESERCIZI
     ON DELETE CASCADE;

alter table ESECUZIONIESERCIZIATEMPO add constraint FKESE_ESE_1_FK
     foreign key (ID)
     references ESECUZIONIESERCIZI
     ON DELETE CASCADE;

alter table GIORNIALLENAMENTI add constraint FKcontiene_FK
     foreign key (username)
     references PIANIALLENAMENTO
     ON DELETE CASCADE;

alter table PIANIALLENAMENTO add constraint FKrealizza_FK
     foreign key (username)
     references UTENTI
     ON DELETE CASCADE;


alter table UTENTIAUTOMATICI add constraint FKUTE_UTE_FK
     foreign key (username)
     references UTENTI
     ON DELETE CASCADE;

alter table ESECUZIONIESERCIZI add constraint EXTONE_ESECUZIONIESERCIZI
     check((ESECUZIONIESERCIZIASERIE is not null and ESECUZIONIESERCIZIATEMPO is null)
           or (ESECUZIONIESERCIZIASERIE is null and ESECUZIONIESERCIZIATEMPO is not null)); 

alter table GIORNIALLENAMENTI add constraint ID_GIORNIALLENAMENTI_CHK
     check(exists(select * from ESECUZIONIESERCIZI
                  where ESECUZIONIESERCIZI.Ha_ID = ID)); 


alter table PIANIALLENAMENTO add constraint FKrealizza_CHK
     check(exists(select * from GIORNIALLENAMENTI
                  where GIORNIALLENAMENTI.Con_ID = ID)); 


alter table UTENTI add constraint ID_UTENTI_CHK
     check(exists(select * from PIANIALLENAMENTO
                  where PIANIALLENAMENTO.ID = ID)); 


-- Index Section
-- _____________ 

create unique index ID_ALLENAMENTI_IND
     on ALLENAMENTI (ID);

create index FKesegue_IND
     on ALLENAMENTI (Ese_ID);

create unique index ID_ESECUZIONIESERCIZI_IND
     on ESECUZIONIESERCIZI (ID);

create index FKha_IND
     on ESECUZIONIESERCIZI (Ha_ID);

create unique index FKESE_ESE_IND
     on ESECUZIONIESERCIZIASERIE (ID);

create unique index FKESE_ESE_1_IND
     on ESECUZIONIESERCIZIATEMPO (ID);

create unique index ID_GIORNIALLENAMENTI_IND
     on GIORNIALLENAMENTI (ID);

create index FKcontiene_IND
     on GIORNIALLENAMENTI (Con_ID);

create unique index ID_IDs_IND
     on IDs (allenamento, utente, giornoAllenamento, esecuzioneEsercizio);

create unique index FKrealizza_IND
     on PIANIALLENAMENTO (ID);

create unique index ID_UTENTI_IND
     on UTENTI (ID);

create unique index FKUTE_UTE_IND
     on UTENTIAUTOMATICI (ID);

