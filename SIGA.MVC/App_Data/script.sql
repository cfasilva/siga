/* ============================================================ */
/*   Database name:  MODEL_2                                    */
/*   DBMS name:      Microsoft SQL Server 6.x                   */
/*   Created on:     19/03/2014  20:23                          */
/* ============================================================ */

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMLIPMP')
            and   type = 'U')
   drop table ITEMLIPMP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LIPMP')
            and   type = 'U')
   drop table LIPMP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LIFMEA')
            and   type = 'U')
   drop table LIFMEA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMFMEA')
            and   type = 'U')
   drop table ITEMFMEA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMCIRCUITO')
            and   type = 'U')
   drop table ITEMCIRCUITO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LI')
            and   type = 'U')
   drop table LI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USINA')
            and   type = 'U')
   drop table USINA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMPMP')
            and   type = 'U')
   drop table ITEMPMP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FMEA')
            and   type = 'U')
   drop table FMEA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PMP')
            and   type = 'U')
   drop table PMP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CIRCUITO')
            and   type = 'U')
   drop table CIRCUITO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESPECIALIDADE')
            and   type = 'U')
   drop table ESPECIALIDADE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOPERIODO')
            and   type = 'U')
   drop table TIPOPERIODO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOMANUT')
            and   type = 'U')
   drop table TIPOMANUT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAREFA')
            and   type = 'U')
   drop table TAREFA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPRESA')
            and   type = 'U')
   drop table EMPRESA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROCESSO')
            and   type = 'U')
   drop table PROCESSO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DISCIPLINA')
            and   type = 'U')
   drop table DISCIPLINA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SITE')
            and   type = 'U')
   drop table SITE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FAMILIA')
            and   type = 'U')
   drop table FAMILIA
go

/* ============================================================ */
/*   Table: FAMILIA                                             */
/* ============================================================ */
create table FAMILIA
(
    COD_FAMILIA          varchar(12)           not null,
    DCR_FAMILIA          varchar(128)          not null,
    constraint PK_FAMILIA primary key (COD_FAMILIA)
)
go

/* ============================================================ */
/*   Table: SITE                                                */
/* ============================================================ */
create table SITE
(
    COD_SITE             varchar(12)           not null,
    DCR_SITE             varchar(128)          not null,
    constraint PK_SITE primary key (COD_SITE)
)
go

/* ============================================================ */
/*   Table: DISCIPLINA                                          */
/* ============================================================ */
create table DISCIPLINA
(
    COD_DISCIPLINA       varchar(12)           not null,
    DCR_DISCIPLICA       varchar(32)           not null,
    constraint PK_DISCIPLINA primary key (COD_DISCIPLINA)
)
go

/* ============================================================ */
/*   Table: PROCESSO                                            */
/* ============================================================ */
create table PROCESSO
(
    COD_PROCESSO         varchar(12)           not null,
    DCR_PROCESSO         varchar(128)          not null,
    constraint PK_PROCESSO primary key (COD_PROCESSO)
)
go

/* ============================================================ */
/*   Table: EMPRESA                                             */
/* ============================================================ */
create table EMPRESA
(
    COD_EMPRESA          numeric               identity,
    DCR_EMPRESA          varchar(32)           not null,
    constraint PK_EMPRESA primary key (COD_EMPRESA)
)
go

/* ============================================================ */
/*   Table: TAREFA                                              */
/* ============================================================ */
create table TAREFA
(
    COD_TAREFA           varchar(12)           not null,
    DCR_TAREFA           varchar(128)          not null,
    constraint PK_TAREFA primary key (COD_TAREFA)
)
go

/* ============================================================ */
/*   Table: TIPOMANUT                                           */
/* ============================================================ */
create table TIPOMANUT
(
    COD_TIPOMANUT        varchar(12)           not null,
    DCR_TIPOMANUT        varchar(128)          not null,
    constraint PK_TIPOMANUT primary key (COD_TIPOMANUT)
)
go

/* ============================================================ */
/*   Table: TIPOPERIODO                                         */
/* ============================================================ */
create table TIPOPERIODO
(
    COD_TIPOPERIODO      varchar(12)           not null,
    DCR_TIPOPERIODO      varchar(32)           not null,
    constraint PK_TIPOPERIODO primary key (COD_TIPOPERIODO)
)
go

/* ============================================================ */
/*   Table: ESPECIALIDADE                                       */
/* ============================================================ */
create table ESPECIALIDADE
(
    COD_ESPECIALIDADE    varchar(12)           not null,
    DCR_ESPECIALIDADE    varchar(128)          not null,
    constraint PK_ESPECIALIDADE primary key (COD_ESPECIALIDADE)
)
go

/* ============================================================ */
/*   Table: CIRCUITO                                            */
/* ============================================================ */
create table CIRCUITO
(
    COD_CIRCUITO         varchar(12)           not null,
    DCR_CIRCUITO         varchar(128)          not null,
    constraint PK_CIRCUITO primary key (COD_CIRCUITO)
)
go

/* ============================================================ */
/*   Table: PMP                                                 */
/* ============================================================ */
create table PMP
(
    COD_PMP              varchar(12)           not null,
    DCR_PMP              varchar(128)          not null,
    constraint PK_PMP primary key (COD_PMP)
)
go

/* ============================================================ */
/*   Table: FMEA                                                */
/* ============================================================ */
create table FMEA
(
    COD_FMEA             varchar(12)           not null,
    COD_SITE             varchar(12)           null    ,
    COD_FAMILIA          varchar(12)           null    ,
    DCR_FMEA             varchar(128)          not null,
    constraint PK_FMEA primary key (COD_FMEA)
)
go

/* ============================================================ */
/*   Table: ITEMPMP                                             */
/* ============================================================ */
create table ITEMPMP
(
    COD_ITEMPMP          numeric               identity,
    COD_PMP              varchar(12)           null    ,
    COD_TIPOMANUT        varchar(12)           null    ,
    COD_TIPOPERIODO      varchar(12)           null    ,
    COD_ESPECIALIDADE    varchar(12)           null    ,
    COD_FMEA             varchar(12)           null    ,
    COD_TAREFA           varchar(12)           null    ,
    DCR_CONDEXEC         varchar(8)            null    ,
    INT_PERIODO          numeric(4)            null    ,
    INT_DURACAO          numeric(4)            null    ,
    INT_QUANTIDADE       numeric(4)            null    ,
    DCR_TURMAEXEC        varchar(32)           null    ,
    DCR_PROCEDIMENTO     varchar(1)            null    ,
    DCR_TAREFA           varchar(128)          null    ,
    DCR_COMPONENTE       varchar(128)          null    ,
    constraint PK_ITEMPMP primary key (COD_ITEMPMP)
)
go

/* ============================================================ */
/*   Table: USINA                                               */
/* ============================================================ */
create table USINA
(
    COD_USINA            varchar(12)           not null,
    COD_EMPRESA          numeric               null    ,
    COD_SITE             varchar(12)           null    ,
    DCR_USINA            varchar(32)           not null,
    constraint PK_USINA primary key (COD_USINA)
)
go

/* ============================================================ */
/*   Table: LI                                                  */
/* ============================================================ */
create table LI
(
    COD_TAG              varchar(32)           not null,
    COD_FAMILIA          varchar(12)           null    ,
    COD_PROCESSO         varchar(12)           null    ,
    COD_USINA            varchar(12)           null    ,
    COD_DISCIPLINA       varchar(12)           null    ,
    SIT_COD_SITE         varchar(12)           null    ,
    DCR_SUBSISTEMA       varchar(128)          not null,
    COD_TAGPAI           varchar(32)           null    ,
    DCR_CRITICO          varchar(12)           not null,
    constraint PK_LI primary key (COD_TAG)
)
go

/* ============================================================ */
/*   Table: ITEMCIRCUITO                                        */
/* ============================================================ */
create table ITEMCIRCUITO
(
    COD_ITEMCIRCUITO     numeric               identity,
    COD_CIRCUITO         varchar(12)           null    ,
    COD_TAG              varchar(32)           null    ,
    constraint PK_ITEMCIRCUITO primary key (COD_ITEMCIRCUITO)
)
go

/* ============================================================ */
/*   Table: ITEMFMEA                                            */
/* ============================================================ */
create table ITEMFMEA
(
    COD_ITEMFMEA         numeric               identity,
    COD_FMEA             varchar(12)           null    ,
    COD_TAREFA           varchar(12)           null    ,
    DCR_FUNCAO           varchar(128)          null    ,
    DCR_FALHAFUNC        varchar(128)          null    ,
    DCR_MODOFALHA        varchar(128)          null    ,
    DCR_CAUSAFALHA       varchar(128)          null    ,
    DCR_EFEITOFALHA      varchar(128)          null    ,
    DCR_S                numeric               null    ,
    DCR_O                numeric               null    ,
    DCR_D                numeric               null    ,
    DCR_NPR              numeric               null    ,
    DCR_GRAURISCO        varchar(8)            null    ,
    DCR_DECISAO          varchar(1)            null    ,
    DCR_P1               varchar(1)            null    ,
    DCR_P2               varchar(1)            null    ,
    DCR_P3               varchar(1)            null    ,
    DCR_P4               varchar(1)            null    ,
    DCR_P5               varchar(1)            null    ,
    DCR_P6               varchar(1)            null    ,
    DCR_ACAO             varchar(128)          null    ,
    DCR_DETTAREFA        varchar(128)          null    ,
    constraint PK_ITEMFMEA primary key (COD_ITEMFMEA)
)
go

/* ============================================================ */
/*   Table: LIFMEA                                              */
/* ============================================================ */
create table LIFMEA
(
    COD_LIFMEA           numeric               identity,
    COD_TAG              varchar(32)           not null,
    COD_FMEA             varchar(12)           not null,
    constraint PK_LIFMEA primary key (COD_LIFMEA)
)
go

/* ============================================================ */
/*   Table: LIPMP                                               */
/* ============================================================ */
create table LIPMP
(
    COD_LIPMP            numeric               identity,
    COD_TAG              varchar(32)           not null,
    COD_PMP              varchar(12)           not null,
    constraint PK_LIPMP primary key (COD_LIPMP)
)
go

/* ============================================================ */
/*   Table: ITEMLIPMP                                           */
/* ============================================================ */
create table ITEMLIPMP
(
    COD_ITEMLIPMP        numeric               identity,
    COD_TAG              varchar(32)           null    ,
    COD_ITEMPMP          numeric               null    ,
    INT_SEMANAINICIO     numeric(2)            null    ,
    INT_PERIODO          numeric(4)            not null,
    INT_PERIODOEQUIPA    numeric(4)            not null,
    INT_PERIODOCIRCUITO  numeric(4)            not null,
    constraint PK_ITEMLIPMP primary key (COD_ITEMLIPMP)
)
go

alter table FMEA
    add constraint FK_FMEA_REF_80_SITE foreign key  (COD_SITE)
       references SITE (COD_SITE)
go

alter table FMEA
    add constraint FK_FMEA_REF_84_FAMILIA foreign key  (COD_FAMILIA)
       references FAMILIA (COD_FAMILIA)
go

alter table ITEMPMP
    add constraint FK_ITEMPMP_REF_131_PMP foreign key  (COD_PMP)
       references PMP (COD_PMP)
go

alter table ITEMPMP
    add constraint FK_ITEMPMP_REF_135_TIPOMANU foreign key  (COD_TIPOMANUT)
       references TIPOMANUT (COD_TIPOMANUT)
go

alter table ITEMPMP
    add constraint FK_ITEMPMP_REF_139_TIPOPERI foreign key  (COD_TIPOPERIODO)
       references TIPOPERIODO (COD_TIPOPERIODO)
go

alter table ITEMPMP
    add constraint FK_ITEMPMP_REF_143_ESPECIAL foreign key  (COD_ESPECIALIDADE)
       references ESPECIALIDADE (COD_ESPECIALIDADE)
go

alter table ITEMPMP
    add constraint FK_ITEMPMP_REF_147_FMEA foreign key  (COD_FMEA)
       references FMEA (COD_FMEA)
go

alter table ITEMPMP
    add constraint FK_ITEMPMP_REF_151_TAREFA foreign key  (COD_TAREFA)
       references TAREFA (COD_TAREFA)
go

alter table USINA
    add constraint FK_USINA_REF_361_EMPRESA foreign key  (COD_EMPRESA)
       references EMPRESA (COD_EMPRESA)
go

alter table USINA
    add constraint FK_USINA_REF_377_SITE foreign key  (COD_SITE)
       references SITE (COD_SITE)
go

alter table LI
    add constraint FK_LI_REF_37_FAMILIA foreign key  (COD_FAMILIA)
       references FAMILIA (COD_FAMILIA)
go

alter table LI
    add constraint FK_LI_REF_45_PROCESSO foreign key  (COD_PROCESSO)
       references PROCESSO (COD_PROCESSO)
go

alter table LI
    add constraint FK_LI_REF_49_USINA foreign key  (COD_USINA)
       references USINA (COD_USINA)
go

alter table LI
    add constraint FK_LI_REF_53_DISCIPLI foreign key  (COD_DISCIPLINA)
       references DISCIPLINA (COD_DISCIPLINA)
go

alter table LI
    add constraint FK_LI_REF_373_SITE foreign key  (SIT_COD_SITE)
       references SITE (COD_SITE)
go

alter table ITEMCIRCUITO
    add constraint FK_ITEMCIRC_REF_92_CIRCUITO foreign key  (COD_CIRCUITO)
       references CIRCUITO (COD_CIRCUITO)
go

alter table ITEMCIRCUITO
    add constraint FK_ITEMCIRC_REF_96_LI foreign key  (COD_TAG)
       references LI (COD_TAG)
go

alter table ITEMFMEA
    add constraint FK_ITEMFMEA_REF_102_FMEA foreign key  (COD_FMEA)
       references FMEA (COD_FMEA)
go

alter table ITEMFMEA
    add constraint FK_ITEMFMEA_REF_106_TAREFA foreign key  (COD_TAREFA)
       references TAREFA (COD_TAREFA)
go

alter table LIFMEA
    add constraint FK_LIFMEA_REF_170_LI foreign key  (COD_TAG)
       references LI (COD_TAG)
go

alter table LIFMEA
    add constraint FK_LIFMEA_REF_174_FMEA foreign key  (COD_FMEA)
       references FMEA (COD_FMEA)
go

alter table LIPMP
    add constraint FK_LIPMP_REF_180_LI foreign key  (COD_TAG)
       references LI (COD_TAG)
go

alter table LIPMP
    add constraint FK_LIPMP_REF_184_PMP foreign key  (COD_PMP)
       references PMP (COD_PMP)
go

alter table ITEMLIPMP
    add constraint FK_ITEMLIPM_REF_192_LI foreign key  (COD_TAG)
       references LI (COD_TAG)
go

alter table ITEMLIPMP
    add constraint FK_ITEMLIPM_REF_196_ITEMPMP foreign key  (COD_ITEMPMP)
       references ITEMPMP (COD_ITEMPMP)
go

