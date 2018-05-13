-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 9.3.0              
-- * Generator date: Feb 16 2016              
-- * Generation date: Sun May 13 11:22:35 2018 
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
     ID numeric(1) not null,
     peso numeric(1),
     data date not null,
     durata numeric(1) not null,
     Ese_ID numeric(1) not null,
     constraint ID_ALLENAMENTI_ID primary key (ID));

create table ESECUZIONIESERCIZI (
     ID numeric(1) not null,
     nomeEsercizio varchar(50) not null,
     Ha_ID numeric(1) not null,
     ESECUZIONIESERCIZIATEMPO numeric(1),
     ESECUZIONIESERCIZIASERIE numeric(1),
     constraint ID_ESECUZIONIESERCIZI_ID primary key (ID));

create table ESECUZIONIESERCIZIASERIE (
     ID numeric(1) not null,
     numeroSerie numeric(1) not null,
     numeroRipetizioni numeric(1) not null,
     tempoDiRecuperoTraSerie numeric(1) not null,
     carico numeric(1),
     constraint FKESE_ESE_ID primary key (ID));

create table ESECUZIONIESERCIZIATEMPO (
     ID numeric(1) not null,
     tempo numeric(1) not null,
     constraint FKESE_ESE_1_ID primary key (ID));

create table GIORNIALLENAMENTI (
     ID numeric(1) not null,
     tempoRecuperoTraEsercizi numeric(1) not null,
     Con_ID numeric(1) not null,
     constraint ID_GIORNIALLENAMENTI_ID primary key (ID));

create table IDs (
     allenamento numeric(1) not null,
     utente numeric(1) not null,
     giornoAllenamento numeric(1) not null,
     esecuzioneEsercizio numeric(1) not null,
     constraint ID_IDs_ID primary key (allenamento, utente, giornoAllenamento, esecuzioneEsercizio));

create table PIANIALLENAMENTO (
     ID numeric(1) not null,
     numeroGiorniAllenamento_ numeric(1) not null,
     tipoAllenamento varchar(13) not null,
     constraint FKrealizza_ID primary key (ID));

create table UTENTI (
     ID numeric(1) not null,
     nome varchar(50) not null,
     cognome varchar(50) not null,
     sesso varchar(7) not null,
     dataNascita date not null,
     peso numeric(2) not null,
     altezza numeric(1) not null,
     constraint ID_UTENTI_ID primary key (ID));

create table UTENTIAUTOMATICI (
     ID numeric(1) not null,
     risorseDisponibili char(1) not null,
     numeroAllenamentiSettimanali numeric(1) not null,
     tipoAllenamento char(1) not null,
     constraint FKUTE_UTE_ID primary key (ID));


-- Constraints Section
-- ___________________ 

alter table ALLENAMENTI add constraint FKesegue_FK
     foreign key (Ese_ID)
     references UTENTI;

alter table ESECUZIONIESERCIZI add constraint EXTONE_ESECUZIONIESERCIZI
     check((ESECUZIONIESERCIZIASERIE is not null and ESECUZIONIESERCIZIATEMPO is null)
           or (ESECUZIONIESERCIZIASERIE is null and ESECUZIONIESERCIZIATEMPO is not null)); 

alter table ESECUZIONIESERCIZI add constraint FKha_FK
     foreign key (Ha_ID)
     references GIORNIALLENAMENTI;

alter table ESECUZIONIESERCIZIASERIE add constraint FKESE_ESE_FK
     foreign key (ID)
     references ESECUZIONIESERCIZI;

alter table ESECUZIONIESERCIZIATEMPO add constraint FKESE_ESE_1_FK
     foreign key (ID)
     references ESECUZIONIESERCIZI;

alter table GIORNIALLENAMENTI add constraint ID_GIORNIALLENAMENTI_CHK
     check(exists(select * from ESECUZIONIESERCIZI
                  where ESECUZIONIESERCIZI.Ha_ID = ID)); 

alter table GIORNIALLENAMENTI add constraint FKcontiene_FK
     foreign key (Con_ID)
     references PIANIALLENAMENTO;

alter table PIANIALLENAMENTO add constraint FKrealizza_CHK
     check(exists(select * from GIORNIALLENAMENTI
                  where GIORNIALLENAMENTI.Con_ID = ID)); 

alter table PIANIALLENAMENTO add constraint FKrealizza_FK
     foreign key (ID)
     references UTENTI;

alter table UTENTI add constraint ID_UTENTI_CHK
     check(exists(select * from PIANIALLENAMENTO
                  where PIANIALLENAMENTO.ID = ID)); 

alter table UTENTIAUTOMATICI add constraint FKUTE_UTE_FK
     foreign key (ID)
     references UTENTI;


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

